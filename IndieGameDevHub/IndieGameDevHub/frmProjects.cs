using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UT = IndieGameDevHub.UIUtilities;

namespace IndieGameDevHub
{
    public partial class frmProjects : Form
    {
        public frmProjects()
        {
            InitializeComponent();
        }

        int currentProjectId = 0;
        int firstProjectId = 0;
        int lastProjectId = 0;
        int? previousProjectId;
        int? nextProjectId;

        #region [Form Events]
        private void btnAdd_Click(object sender, EventArgs e)
        {
            UT.ClearControls(this.grpProjects.Controls);

            btnSave.Text = "Create";
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;

            NavigationState(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (txtProjectId.Text == string.Empty)
                    {
                        //Create
                        CreateProject();
                    }
                    else
                    {
                        SaveProjectChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = $@"
                DELETE FROM Projects WHERE ProjectId = {currentProjectId}
            ";

            int rowsAffected = DataAccess.ExecuteNonQuery(sql);

            if (rowsAffected == 1)
            {
                MessageBox.Show($"ProjectId: {txtProjectId.Text} was deleted");
                LoadFirstProject();
            }
            else if (rowsAffected == 0)
            {
                MessageBox.Show($"ProjectId: {txtProjectId.Text} does not exist. May already have been delete.");
                LoadFirstProject();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadProjectDetails();

            btnSave.Text = "Save";
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;

            NavigationState(true);
            NextPreviousButtonManagement();
        }

        private void frmProjects_Load(object sender, EventArgs e)
        {
            try
            {
                // Load ESRB Rating combobox
                LoadRating();


                // Load dimension type combobox
                LoadDimensionType();
                // Load the first records in the Project table
                LoadFirstProject();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LoadDimensionType()
        {
            UIUtilities.BindComboBox(cmbType, DataAccess.GetData("SELECT ProjectId, DimensionType FROM Projects ORDER BY DimensionType"), "DimensionType", "ProjectId");
        }

        private void LoadRating()
        {
            string sqlRating = @"
                SELECT ProjectId, EsrbRating
                FROM Projects
                ORDER BY EsrbRating
            ";

            UIUtilities.BindComboBox(cmbRating, DataAccess.GetData(sqlRating), "EsrbRating", "ProjectId");


        }


        #endregion

        private void SaveProjectChanges()
        {
            string sql = $@"
                 UPDATE [dbo].[Projects]
                    SET [Title] = '{txtTitle.Text.Trim()}'
                        ,[Genre] = '{txtGenre.Text.Trim()}'
                        ,[Engine] = '{txtEngine.Text.Trim()}'
                        ,[EsrbRating] = '{cmbRating.SelectedValue}'
                        ,[DimensionType] = '{cmbType.SelectedValue}'
                        ,[Description] = '{txtDescription.Text.Trim()}'
                        ,[StartDate] = '{txtStartDate.Text.Trim()}'
                        ,[EstimatedCompletionDate] = '{txtEstimatedDate.Text.Trim()}'
                        ,[StatusOfTheProject] = '{txtStatusProject.Text.Trim()}'
                WHERE ProjectId = {txtProjectId.Text.Trim()}
            ";

            int rowsAffected = DataAccess.ExecuteNonQuery(sql);

            if (rowsAffected == 1)
            {
                MessageBox.Show($"ProjectId: {txtProjectId.Text} changes saved");
            }
            else
            {
                MessageBox.Show($"Update to ProjectId: {txtProjectId.Text} was not updated.");
            }
        }

        private void CreateProject()
        {
            
            string sqlInsertProject = $@"
                INSERT INTO [dbo].[Projects]
                (
                     [Title]
                    ,[Genre]
                    ,[Engine]
                    ,[EsrbRating]
                    ,[DimensionType]
                    ,[Description]
                    ,[StartDate]
                    ,[EstimatedCompletionDate]
                    ,[StatusOfTheProject]
                )
                VALUES
                (
                    '{txtTitle.Text.Trim()}'
                    ,'{txtGenre.Text.Trim()}'
                    ,'{txtEngine.Text.Trim()}'
                    ,'{cmbRating.SelectedValue}'
                    ,'{cmbType.SelectedValue}'
                    ,'{txtDescription.Text.Trim()}'
                    ,'{txtStartDate.Text.Trim()}'
                    ,'{txtEstimatedDate.Text.Trim()}'
                    ,'{txtStatusProject.Text.Trim()}'
                )
            ";

            int rowsAffected = DataAccess.ExecuteNonQuery(sqlInsertProject);

            if (rowsAffected == 1)
            {
                MessageBox.Show("Project was created");
                btnCancel_Click(null, null);
                NextPreviousButtonManagement();
                LoadFirstProject();
            }
            else
            {
                MessageBox.Show("No Project Created");
            }
        }
        private void LoadFirstProject()
        {
            try
            {
                object ProjectId = DataAccess.GetValue("SELECT TOP (1) ProjectId FROM Projects ORDER BY Title");

                if (ProjectId == null)
                {
                    NavigationState(false);


                    btnAdd_Click(null, null);
                    btnCancel.Enabled = false;
                    return;
                }

                NavigationState(true);

                firstProjectId = Convert.ToInt32(ProjectId);
                currentProjectId = firstProjectId;
                LoadProjectDetails();
                NextPreviousButtonManagement();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void LoadProjectDetails()
        {
            errProvider.Clear();

            string[] sqlStatements = new string[]
            {
                $"SELECT * FROM Projects WHERE ProjectId = {currentProjectId}",
                $@"
                SELECT 
                (
                    SELECT TOP(1) ProjectId as FirstProjectId FROM Projects ORDER BY Title
                ) as FirstProjectId,
                q.PreviousProjectId,
                q.NextProjectId,
                (
                    SELECT TOP(1) ProjectId as LastProjectId FROM Projects ORDER BY Title Desc
                ) as LastProjectId
                FROM
                (
                    SELECT ProjectId, Title,
                    LEAD(ProjectId) OVER(ORDER BY Title) AS NextProjectId,
                    LAG(ProjectId) OVER(ORDER BY Title) AS PreviousProjectId,
                    ROW_NUMBER() OVER(ORDER BY Title) AS 'RowNumber'
                    FROM Projects
                ) AS q
                WHERE q.ProjectId = {currentProjectId}
                ORDER BY q.Title"
            };

            try
            {
                DataSet ds = new DataSet();
                ds = DataAccess.GetData(sqlStatements);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    DataRow selectedProject = ds.Tables[0].Rows[0];

                    txtProjectId.Text       = selectedProject["ProjectId"].ToString();
                    txtTitle.Text           = selectedProject["Title"].ToString();
                    txtGenre.Text           = selectedProject["Genre"].ToString();
                    txtEngine.Text          = selectedProject["Engine"].ToString();
                    cmbRating.Text          = selectedProject["EsrbRating"].ToString();
                    cmbType.Text            = selectedProject["DimensionType"].ToString();
                    txtDescription.Text     = selectedProject["Description"].ToString();
                    txtStartDate.Text       = selectedProject["StartDate"].ToString();
                    txtEstimatedDate.Text   = selectedProject["EstimatedCompletionDate"].ToString();
                    txtStatusProject.Text   = selectedProject["StatusOfTheProject"].ToString();


                    firstProjectId      = Convert.ToInt32(ds.Tables[1].Rows[0]["FirstProjectId"]);
                    previousProjectId   = ds.Tables[1].Rows[0]["PreviousProjectId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["PreviousProjectId"]) : (int?)null;
                    nextProjectId       = ds.Tables[1].Rows[0]["NextProjectId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["NextProjectId"]) : (int?)null;
                    lastProjectId       = Convert.ToInt32(ds.Tables[1].Rows[0]["LastProjectId"]);
                }
                else
                {
                    LoadFirstProject();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }


        #region [Navigation Helpers]

        /// <summary>
        /// Helps manage the enable state of our next and previous navigation buttons
        /// Depending on where we are in products we may need to set enable state based on position
        /// navigation through product records
        /// </summary>
        private void NextPreviousButtonManagement()
        {
            btnPrevious.Enabled = previousProjectId != null;
            btnNext.Enabled = nextProjectId != null;
        }

        /// <summary>
        /// Handle navigation button interaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Navigation_Handler(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            switch (b.Name)
            {
                case "btnFirst":
                    currentProjectId = firstProjectId;
                    break;
                case "btnLast":
                    currentProjectId = lastProjectId;
                    break;
                case "btnPrevious":
                    currentProjectId = previousProjectId.Value;
                    break;
                case "btnNext":
                    currentProjectId = nextProjectId.Value;
                    break;
            }

            LoadProjectDetails();
            NextPreviousButtonManagement();
        }

        /// <summary>
        /// Helper method to set state of all nav buttons
        /// </summary>
        /// <param name="enableState"></param>
        private void NavigationState(bool enableState)
        {
            btnFirst.Enabled = enableState;
            btnLast.Enabled = enableState;
            btnNext.Enabled = enableState;
            btnPrevious.Enabled = enableState;
        }

        #endregion

        #region [Validation]

        /// <summary>
        /// Textbox validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string txtBoxName = txt.Tag.ToString();
            string errMsg = null;
            bool failedValidation = false;

            if (txt.Text == string.Empty)
            {
                errMsg = $"{txtBoxName} is required";
                failedValidation = true;
            }

            if (txt.Name == "txtCredit" || txt.Name == "txtHours")
            {
                if (!Validator.IsNumeric(txt.Text))
                {
                    errMsg = $"{txtBoxName} required to be numeric";
                    failedValidation = true;
                }
            }

            e.Cancel = failedValidation;

            errProvider.SetError(txt, errMsg);
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndieGameDevHub
{
    public partial class frmProjectContributor : Form
    {
        public frmProjectContributor()
        {
            InitializeComponent();
        }



        #region [Navigation]

        private int currentDeveloperId;
        private int currentProjectId;
        private int currentContributionId;

        private int firstDeveloperId;
        private int firstProjectId;
        private int firstContributionId;

        private int lastDeveloperId;
        private int lastProjectId;
        private int lastContributionId;

        private int? previousDeveloperId;
        private int? previousProjectId;
        private int? previousContributionId;

        private int? nextDeveloperId;
        private int? nextProjectId;
        private int? nextContributionId;

        #endregion

        private void frmProjectContributor_Load(object sender, EventArgs e)
        {
            // Load Projects combobox
            LoadProjects();

            // Load Developers combobox
            LoadDevelopers();

            // Load the first records in the Contributors table
            LoadFirstContributor();

        }

        private void LoadFirstContributor()
        {
            DataTable dt = DataAccess.GetData("SELECT TOP 1 * FROM ProjectContributors");

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                currentDeveloperId = Convert.ToInt32(dr["DeveloperDeveloperId"]);
                currentProjectId = Convert.ToInt32(dr["ProjectProjectId"]);
                currentContributionId = Convert.ToInt32(dr["ContributionId"]);

                firstDeveloperId = currentDeveloperId;
                firstProjectId = currentProjectId;
                firstContributionId = currentContributionId;

                LoadContributionDetails();
                NextPreviousButtonManagement();
            }
            else
            {
                MessageBox.Show("No Project Contributions in the system");
            }
        }

        private void LoadContributionDetails()
        {
            errProvider.Clear();

            string[] sqlStatements = new string[]
            {
                $@"
					SELECT * FROM ProjectContributors
					WHERE 
					DeveloperDeveloperId = {currentDeveloperId}
					AND ProjectProjectId = {currentProjectId}
					AND ContributionId = {currentContributionId};
				",
                $@"
                    SELECT 
                    (
                        SELECT TOP(1) DeveloperDeveloperId FROM ProjectContributors
                    ) as FirstDeveloperId,
                    (
                        SELECT TOP(1) ProjectProjectId FROM ProjectContributors
                    ) as FirstProjectId,
                    (
                        SELECT TOP(1) ContributionId FROM ProjectContributors
                    ) as FirstContributionId,
                    q.PreviousDeveloperId,
                    q.PreviousProjectId,
                    q.PreviousContributionId,
                    q.NextDeveloperId,
                    q.NextProjectId,
                    q.NextContributionId,
                    (
                        SELECT TOP(1) DeveloperDeveloperId FROM ProjectContributors ORDER BY DeveloperDeveloperId DESC
                    ) as LastDeveloperId,
                    (
                        SELECT TOP(1) ProjectProjectId FROM ProjectContributors ORDER BY DeveloperDeveloperId DESC
                    ) as LastProjectId,
                    (
                        SELECT TOP(1) ContributionId FROM ProjectContributors ORDER BY DeveloperDeveloperId DESC
                    ) as LastContributionId
                    FROM
                    (
                        SELECT DeveloperDeveloperId, ProjectProjectId, ContributionId,
                        LEAD(DeveloperDeveloperId) OVER(ORDER BY DeveloperDeveloperId) AS NextDeveloperId,
                        LEAD(ProjectProjectId) OVER(ORDER BY DeveloperDeveloperId) AS NextProjectId,  
                        LEAD(ContributionId) OVER(ORDER BY DeveloperDeveloperId) AS NextContributionId,  
                        LAG(DeveloperDeveloperId) OVER(ORDER BY DeveloperDeveloperId) AS PreviousDeveloperId,
                        LAG(ProjectProjectId) OVER(ORDER BY DeveloperDeveloperId) AS PreviousProjectId,
                        LAG(ContributionId) OVER(ORDER BY DeveloperDeveloperId) AS PreviousContributionId,
                        ROW_NUMBER() OVER(ORDER BY DeveloperDeveloperId) AS 'RowNumber'
                        FROM ProjectContributors
                    ) AS q
                    WHERE q.DeveloperDeveloperId = {currentDeveloperId}
                    AND q.ProjectProjectId = {currentProjectId}  
                    AND q.ContributionId = {currentContributionId}
                    ORDER BY q.DeveloperDeveloperId, q.ProjectProjectId, q.ContributionId
				"
            };

            DataSet dsData = DataAccess.GetData(sqlStatements);

            if (dsData.Tables[0].Rows.Count == 1)
            {
                DataRow selectedContribution = dsData.Tables[0].Rows[0];
                DataRow navMeta = dsData.Tables[1].Rows[0];

                int ProjectContributor = Convert.ToInt32(selectedContribution["ContributionId"]);
                int ProjectId = Convert.ToInt32(selectedContribution["ProjectProjectId"]);
                int DeveloperId = Convert.ToInt32(selectedContribution["DeveloperDeveloperId"]);

                cmbProjectId.SelectedValue = ProjectId;
                cmbDeveloperId.SelectedValue = DeveloperId;
                txtContributionId.Text = ProjectContributor.ToString();

                firstDeveloperId = Convert.ToInt32(navMeta["FirstDeveloperId"]);
                firstProjectId = Convert.ToInt32(navMeta["FirstProjectId"]);
                firstContributionId = Convert.ToInt32(navMeta["FirstContributionId"]);
                
                lastDeveloperId = Convert.ToInt32(navMeta["LastDeveloperId"]);
                lastProjectId = Convert.ToInt32(navMeta["LastProjectId"]);
                lastContributionId = Convert.ToInt32(navMeta["LastContrinutionId"]);

                previousDeveloperId = navMeta["PreviousDeveloperId"] != DBNull.Value ? Convert.ToInt32(navMeta["PreviousDeveloperId"]) : (int?)null;
                previousProjectId = navMeta["PreviousProjectId"] != DBNull.Value ? Convert.ToInt32(navMeta["PreviousProjectId"]) : (int?)null;
                previousContributionId = navMeta["PreviousContributionId"] != DBNull.Value ? Convert.ToInt32(navMeta["PreviousContributionId"]) : (int?)null;

                nextDeveloperId = navMeta["NextDeveloperId"] != DBNull.Value ? Convert.ToInt32(navMeta["NextDeveloperId"]) : (int?)null;
                nextProjectId = navMeta["NextProjectId"] != DBNull.Value ? Convert.ToInt32(navMeta["NextProjectId"]) : (int?)null;
                nextContributionId = navMeta["NextContributionId"] != DBNull.Value ? Convert.ToInt32(navMeta["NextContributionId"]) : (int?)null;


            }
            else
            {
                object assignmentCount = DataAccess.GetValue("SELECT COUNT(*) FROM ProjectContributors");

                if (assignmentCount == DBNull.Value)
                {
                    MessageBox.Show("No Contributions in the system");
                }
                else
                {
                    MessageBox.Show("The Contribution no longer exists");
                    LoadFirstContributor();
                }
            }
        }



        private void LoadDevelopers()
        {
            string sql = @"
				SELECT DeveloperId, FirstName + ' ' + LastName AS WholeName
				FROM Developers
				ORDER BY FirstName, LastName
			";

            DataTable dtDevelopers = DataAccess.GetData(sql);

            cmbDeveloperId.Bind(dtDevelopers, "WholeName", "DeveloperId", "--Select a Developer--");
        }

        private void LoadProjects()
        {
            string sql = @"
                SELECT ProjectId, Title
                FROM Projects
                ORDER BY Title
            ";

            DataTable dtProjects = DataAccess.GetData(sql);

            cmbProjectId.Bind(dtProjects, "Title", "ProjectId", "--Select a Project--");
        }

        #region [Navigation Helpers]

        /// <summary>
        /// Helps manage the enable state of our next and previous navigation buttons
        /// Depending on where we are in products we may need to set enable state based on position
        /// navigation through product records
        /// </summary>
        private void NextPreviousButtonManagement()
        {
            btnPrevious.Enabled = previousDeveloperId != null;
            btnNext.Enabled = nextDeveloperId != null;

        }

        /// <summary>
        /// Navigation button handling
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Navigation_Handler(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            switch (b.Name)
            {
                case "btnFirst":
                    currentDeveloperId = firstDeveloperId;
                    currentProjectId = firstProjectId;
                    currentContributionId = firstContributionId;
                    break;
                case "btnLast":
                    currentDeveloperId = lastDeveloperId;
                    currentProjectId = lastProjectId;
                    currentContributionId = lastContributionId;
                    break;
                case "btnPrevious":
                    currentDeveloperId = previousDeveloperId.Value;
                    currentProjectId = previousProjectId.Value;
                    currentContributionId = previousContributionId.Value;
                    break;
                case "btnNext":
                    currentDeveloperId = nextDeveloperId.Value;
                    currentProjectId = nextProjectId.Value;
                    currentContributionId = nextContributionId.Value;
                    break;
            }

            //Load Assignment Details as we navigate forward and backward through assignments
            LoadContributionDetails();
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

        #region [Validations]

        /// <summary>
        /// ComboBox Validating Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            string cmbName = cmb.Tag.ToString();

            string errMsg = null;
            bool failedValidation = false;

            if (cmb.SelectedIndex == -1 || string.IsNullOrEmpty(cmb.SelectedValue.ToString()))
            {
                errMsg = $"{cmbName} is required";
                failedValidation = true;
            }

            e.Cancel = failedValidation;
            errProvider.SetError(cmb, errMsg);
        }

        /// <summary>
        /// TextBox Validating event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

            if (txt.Name == "txtTerm")
            {
                if (!Validator.IsNumeric(txt.Text))
                {
                    errMsg = $"{txtBoxName} is not numeric";
                    failedValidation = true;
                }
            }

            e.Cancel = failedValidation;

            errProvider.SetError(txt, errMsg);
        }

        #endregion

        private void frmAssignments_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                UIUtilities.ClearControls(this.Controls);

                //Load the latest course and Instructors
                LoadProjects();

                LoadDevelopers();

                NavigationState(false);

                btnAdd.Enabled = false;
                btnDelete.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    CreateContributor();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateContributor()
        {
            int developerId = Convert.ToInt32(cmbDeveloperId.SelectedValue);
            int projectId = Convert.ToInt32(cmbProjectId.SelectedValue);
            int contributionId = Convert.ToInt32(txtContributionId.Text);



            if (CanAddContribution(developerId))
            {
                string sqlInsert = $@"INSERT INTO [dbo].[ProjectContributors]
                     (
                        [DeveloperDeveloperId]
                        ,[ProjectProjectId]
                        ,[Role]
                        ,[StartDate]
                        ,[EndDate]
                    )
                 VALUES
                    (
                        {developerId}
                        ,{projectId}
                        ,'{txtRole.Text.Trim()}'
                        ,'{txtStartDate.Text.Trim()}'
                        ,'{txtEndDate.Text.Trim()}'
                    )";
                int rowsAffected = DataAccess.ExecuteNonQuery(sqlInsert);

                if (rowsAffected == 1)
                {
                    MessageBox.Show("Contribution was created");
                    currentDeveloperId = developerId;
                    currentProjectId = projectId;
                    currentContributionId = contributionId;
                    LoadContributionDetails();
                    NavigationState(true);
                    NextPreviousButtonManagement();

                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Database error. No record inserted.");
                }
            }
            else
            {
                MessageBox.Show($"The user has 3 active contributions. Cannot assign additional contributions.");
            }
        }

        private bool CanAddContribution(int developerId)
        {
            bool canAdd = true;
            string sqlCountContribution = $@"
                SELECT COUNT(*) 
                FROM ProjectContributors pc
                JOIN Projects p ON pc.ProjectProjectId = p.ProjectId
                WHERE pc.DeveloperDeveloperId = {developerId}
                AND p.StatusOfTheProject = 'Active'"; 

            object result = DataAccess.GetValue(sqlCountContribution);

            int currentActiveContributions = Convert.ToInt32(result);

            if (currentActiveContributions == 3)
            {
                canAdd = false;

                return canAdd;
            }

            return canAdd;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlDeleteContribution = $@"
					DELETE FROM ProjectContributors
					WHERE DeveloperDeveloperId = {currentDeveloperId}
					AND ProjectProjectId = {currentProjectId}
					AND ContributionId = {currentContributionId}
				";

                int rowsAffected = DataAccess.ExecuteNonQuery(sqlDeleteContribution);

                if (rowsAffected == 1)
                {
                    MessageBox.Show("Contribution was deleted. Click Ok to load first Contribution if Any");

                    LoadFirstContributor();
                }
                else if (rowsAffected > 1)
                {
                    MessageBox.Show("Multiple deletions reported");
                }
                else
                {
                    MessageBox.Show("No deletions reported");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void btnCancel_Click(object sender, EventArgs e)
            {
                try
                {
                    LoadContributionDetails();
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    NavigationState(true);
                    NextPreviousButtonManagement();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UT = IndieGameDevHub.UIUtilities;

namespace IndieGameDevHub
{
    public partial class frmDevelopers : Form
    {

        public frmDevelopers()
        {
            InitializeComponent();


        }

        int currentDeveloperId = 0;
        int firstDeveloperId = 0;
        int lastDeveloperId = 0;
        int? previousDeveloperId;
        int? nextDeveloperId;

        /// <summary>
        /// Form Load Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDevelopers_Load(object sender, EventArgs e)
        {
            LoadFirstDeveloper();
        }

        private void LoadFirstDeveloper()
        {
            try
            {

                string[] sqlStatements = new string[]
                {
                    $"SELECT * FROM Developers WHERE DeveloperId = {LoggedInUserInfo.CurrentDeveloperId}",
                };


                DataSet ds = new DataSet();
                ds = DataAccess.GetData(sqlStatements);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //DataRow selectedDeveloper = ds.Tables[0].Rows[0];


                    //int developerId = Convert.ToInt32(selectedDeveloper["DeveloperId"]);
                    //string firstName = Convert.ToString(selectedDeveloper["FirstName"]);
                    //string lastName = Convert.ToString(selectedDeveloper["LastName"]);
                    //string? studioName = Convert.ToString(selectedDeveloper["StudioName"]);
                    //string location = Convert.ToString(selectedDeveloper["Location"]);
                    //string? website = Convert.ToString(selectedDeveloper["Website"]);
                    //string email = Convert.ToString(selectedDeveloper["Email"]);

                    //txtDeveloperId.Text = developerId.ToString();
                    //txtFirstName.Text = firstName;
                    //txtLastName.Text = lastName;
                    //txtStudioName.Text = studioName;
                    //txtLocation.Text = location;
                    //txtWebsite.Text = website;
                    //txtEmail.Text = email;

                    NavigationState(true);

                    firstDeveloperId = LoggedInUserInfo.CurrentDeveloperId;
                    currentDeveloperId = firstDeveloperId;

                    LoadDeveloperDetails();
                    NextPreviousButtonManagement();



                }
                else
                {
                    NavigationState(false);
                    btnAdd_Click(null, null);
                    btnCancel.Enabled = false;
                    return;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void LoadDeveloperDetails()
        {
            errProvider.Clear();
            string[] sqlStatements = new string[]
           {
                $"SELECT * FROM Developers WHERE DeveloperId = {currentDeveloperId}",
                $@"
                SELECT 
                (
                    SELECT TOP(1) DeveloperId as FirstDeveloperId FROM Developers ORDER BY LastName,FirstName
                ) as FirstDeveloperId,
                q.PreviousDeveloperId,
                q.NextDeveloperId,
                (
                    SELECT TOP(1) DeveloperId as LastDeveloperId FROM Developers ORDER BY LastName Desc,FirstName Desc
                ) as LastDeveloperId
                FROM
                (
                    SELECT DeveloperId, LastName, FirstName,
                    LEAD(DeveloperId) OVER(ORDER BY LastName,FirstName) AS NextDeveloperId,
                    LAG(DeveloperId) OVER(ORDER BY LastName,FirstName) AS PreviousDeveloperId,
                    ROW_NUMBER() OVER(ORDER BY LastName, FirstName) AS 'RowNumber'
                    FROM Developers
                ) AS q
                WHERE q.DeveloperId = {currentDeveloperId}
                ORDER BY q.LastName,q.FirstName"
           };


            DataSet ds = new DataSet();
            ds = DataAccess.GetData(sqlStatements);

            if (ds.Tables[0].Rows.Count == 1)
            {
                DataRow selectedDeveloper = ds.Tables[0].Rows[0];
                //DataRow navMeta = ds.Tables[1].Rows[0];

                int developerId = Convert.ToInt32(selectedDeveloper["DeveloperId"]);
                string firstName = Convert.ToString(selectedDeveloper["FirstName"]);
                string lastName = Convert.ToString(selectedDeveloper["LastName"]);
                string? studioName = Convert.ToString(selectedDeveloper["StudioName"]);
                string location = Convert.ToString(selectedDeveloper["Location"]);
                string? website = Convert.ToString(selectedDeveloper["Website"]);
                string email = Convert.ToString(selectedDeveloper["Email"]);

                txtDeveloperId.Text = developerId.ToString();
                txtFirstName.Text = firstName;
                txtLastName.Text = lastName;
                txtStudioName.Text = studioName;
                txtLocation.Text = location;
                txtWebsite.Text = website;
                txtEmail.Text = email;

                firstDeveloperId = Convert.ToInt32(ds.Tables[1].Rows[0]["FirstDeveloperId"]);
                previousDeveloperId = ds.Tables[1].Rows[0]["PreviousDeveloperId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["PreviousDeveloperId"]) : (int?)null;
                nextDeveloperId = ds.Tables[1].Rows[0]["NextDeveloperId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["NextDeveloperId"]) : (int?)null;
                lastDeveloperId = Convert.ToInt32(ds.Tables[1].Rows[0]["LastDeveloperId"]);
            }
            else
            {
                LoadFirstDeveloper();
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
            btnPrevious.Enabled = previousDeveloperId != null;
            btnNext.Enabled = nextDeveloperId != null;
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
                    currentDeveloperId = firstDeveloperId;
                    break;
                case "btnLast":
                    currentDeveloperId = lastDeveloperId;
                    break;
                case "btnPrevious":
                    currentDeveloperId = previousDeveloperId.Value;
                    break;
                case "btnNext":
                    currentDeveloperId = nextDeveloperId.Value;
                    break;
            }

            LoadDeveloperDetails();
            NextPreviousButtonManagement();
        }

        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UT.ClearControls(this.grpDevelopers.Controls);

            btnSave.Text = "Create";
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;

            NavigationState(false);


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadDeveloperDetails();

            btnSave.Text = "Save";
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;

            NavigationState(true);
            NextPreviousButtonManagement();
        }

        private void DeleteDeveloper()
        {
            if (currentDeveloperId == LoggedInUserInfo.CurrentDeveloperId)
            {
                MessageBox.Show("You cannot delete yourself");
            }
            else
            {
                string sqlDelLogin = $@"
                    DELETE FROM Logins WHERE DeveloperDeveloperId = {currentDeveloperId}
                ";

                int rowsAffectedLogin = DataAccess.ExecuteNonQuery(sqlDelLogin);

                string sqlDelDev = $@"
                    DELETE FROM Developers WHERE DeveloperId = {currentDeveloperId}
                ";

                int rowsAffectedDev = DataAccess.ExecuteNonQuery(sqlDelDev);

                if (rowsAffectedDev == 1 && rowsAffectedLogin == 1)
                {
                    MessageBox.Show($"DeveloperId: {txtDeveloperId.Text} was deleted");
                    LoadFirstDeveloper();
                }
                else if (rowsAffectedDev == 0 && rowsAffectedLogin == 0)
                {
                    MessageBox.Show($"DeveloperId: {txtDeveloperId.Text} does not exist. May already have been deleted.");
                    LoadFirstDeveloper();
                }
            }
        }



        //private void btnUpdate_Click(object sender, EventArgs e)
        //{

        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteDeveloper();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (string.IsNullOrEmpty(txtDeveloperId.Text))
                    {
                        CreateDeveloper();
                    }
                    else
                    {
                        SaveDeveloperChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void SaveDeveloperChanges()
        {
            string sql = $@"
                UPDATE [dbo].[Developers]
                   SET [FirstName] = '{txtFirstName.Text.Trim()}'
                      ,[LastName] = '{txtLastName.Text.Trim()}'
                      ,[StudioName] = '{txtStudioName.Text.Trim()}'
                      ,[Location] = '{txtLocation.Text.Trim()}'
                      ,[Website] = '{txtWebsite.Text.Trim()}'
                      ,[Email] = '{txtEmail.Text.Trim()}'
                WHERE DeveloperId = {txtDeveloperId.Text.Trim()}

            ";

            int rowsAffected = DataAccess.ExecuteNonQuery(sql);

            if (rowsAffected == 1)
            {
                MessageBox.Show($"InstructorId: {txtDeveloperId.Text} changes saved");
            }
            else
            {
                MessageBox.Show($"Update to DeveloperId: {txtDeveloperId.Text} was not updated.");
            }
        }

        private void CreateDeveloper()
        {
            string sqlInsertDeveloper = $@"
                INSERT INTO [dbo].[Developers]
                           ([FirstName]
                           ,[LastName]
                           ,[StudioName]
                           ,[Location]
                           ,[Website]
                           ,[Email])
                     VALUES
                    (
                            '{txtFirstName.Text.Trim()}'
                           ,'{txtLastName.Text.Trim()}'
                           ,'{txtStudioName.Text.Trim()}'
                           ,'{txtLocation.Text.Trim()}'
                           ,'{txtWebsite.Text.Trim()}'
                           ,'{txtEmail.Text.Trim()}'
                    )
            ";

            int rowsAffected = DataAccess.ExecuteNonQuery(sqlInsertDeveloper);

            if (rowsAffected == 1)
            {
                string sqlInsertLoginDeveloper = $@"
                    INSERT INTO [dbo].[Logins] 
	                            ([User]
	                            ,[Password]
	                            ,[DeveloperDeveloperId])
                        SELECT 
                                 d.FirstName, 
                                 d.FirstName + '123', 
                                 d.DeveloperId
                        FROM 
                                Developers d
                        WHERE  
                                d.DeveloperId = (SELECT MAX(DeveloperId) FROM Developers)
                
                ";

                int rowsAffectedLogin = DataAccess.ExecuteNonQuery(sqlInsertLoginDeveloper);

                if (rowsAffectedLogin == 1)
                {
                    MessageBox.Show("Developer and Login info was created");
                    btnCancel_Click(null, null);
                    NextPreviousButtonManagement();
                    LoadFirstDeveloper();
                }
                else
                {
                    MessageBox.Show("Developer was created but login info was not");
                }
            }
            else
            {
                MessageBox.Show("The database reported no rows affected, Not Created");
            }
        }

        /// <summary>
        /// TextBox validation
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



            e.Cancel = failedValidation;

            errProvider.SetError(txt, errMsg);
        }
    }
}

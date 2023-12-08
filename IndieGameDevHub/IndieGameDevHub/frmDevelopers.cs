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

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

 

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using IndieGameDevHub;

namespace IndieGameDevHub
{
    public partial class frmBrowseDevelopers : Form
    {
        public frmBrowseDevelopers()
        {
            InitializeComponent();

        }
        private void frmBrowseDevelopers_Load(object sender, EventArgs e)
        {
            LoadDevelopers();


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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {

                string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    string query = $@"
                                    SELECT 
                                                p.Title, 
                                                p.Genre, 
                                                pc.Role
                                    FROM 
                                                Developers d
                                    INNER JOIN 
                                                ProjectContributors pc ON d.DeveloperId = pc.DeveloperDeveloperId
                                    INNER JOIN 
                                                Projects p ON pc.ProjectProjectId = p.ProjectId
                                    WHERE 
                                                d.DeveloperId = {cmbDeveloperId.SelectedValue}
                                    ";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);


                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}


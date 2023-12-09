using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace IndieGameDevHub
{
    public partial class frmBrowseProjects : Form
    {
        public frmBrowseProjects()
        {
            InitializeComponent();
        }



        private void frmBrowseProjects_Load(object sender, EventArgs e)
        {
            LoadProjects();

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
        private void btnUpdate_Click(object sender, EventArgs e)
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
                                        d.FirstName + ' ' + d.LastName AS DeveloperName, 
                                        pc.Role,
                                        p.EstimatedCompletionDate,
                                        p.StatusOfTheProject
                                    FROM 
                                        Projects p
                                    INNER JOIN 
                                        ProjectContributors pc ON p.ProjectId = pc.ProjectProjectId
                                    INNER JOIN 
                                        Developers d ON pc.DeveloperDeveloperId = d.DeveloperId
                                    WHERE 
                                        p.ProjectId = {cmbProjectId.SelectedValue};
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

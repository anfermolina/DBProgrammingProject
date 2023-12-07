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
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		int currentLoginId = 1;

		private void frmLogin_Load(object sender, EventArgs e)
		{
			this.Text = $"{Application.ProductName} - Login";
            LoadLoginDetails();
            //txtUser.Text = Environment.UserName;
		}

        private void LoadLoginDetails()
        {
            string[] sqlStatements = new string[]
            {
                $"SELECT * FROM Logins WHERE LoginId = {currentLoginId}"
            };

            DataSet ds = new DataSet();
			ds = DataAccess.GetData(sqlStatements);

            if (ds.Tables[0].Rows.Count == 1)
            {
                DataRow selectedLogin = ds.Tables[0].Rows[0];
                txtUser.Text = selectedLogin["User"].ToString();
                txtPassword.Text = selectedLogin["Password"].ToString();
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			/*
			if (chkShowPassword.Checked)
			{
				txtPassword.UseSystemPasswordChar = false;
			}
			else
			{
				txtPassword.UseSystemPasswordChar = true;
			}
			*/

			txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (isRightLogin())
			{
				// success
				DialogResult = DialogResult.OK;
			}
			else
			{
				// Failure
				DialogResult = DialogResult.Abort;
			}

		}

        private bool isRightLogin()
        {
            // set to false first
            bool isRightLogin = false;
            // set to true if login is correct
            string currentUser = txtUser.Text;
            string currentPassword = txtPassword.Text;

            string[] sqlStatements = new string[]
           {
                $@"	SELECT * 
					FROM Logins 
					WHERE [User] = '{currentUser}'
					AND [Password] = '{currentPassword}'"
           };

            DataSet ds = new DataSet();
            ds = DataAccess.GetData(sqlStatements);

            if (ds.Tables[0].Rows.Count == 1)
            {
                DataRow selectedLogin = ds.Tables[0].Rows[0];
                if (selectedLogin["User"].ToString() == currentUser && selectedLogin["Password"].ToString() == currentPassword)
                {
                    isRightLogin = true;
                }
            }

            return isRightLogin;
        }



        

        private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
}

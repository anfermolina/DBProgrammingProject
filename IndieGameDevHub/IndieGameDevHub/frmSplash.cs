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
	public partial class frmSplash : Form
	{
		public frmSplash()
		{
			InitializeComponent();
		}

		private void frmSplash_Load(object sender, EventArgs e)
		{
			lblProduct.Text = Application.ProductName;
			lblVersion.Text = Application.ProductVersion;
			lblCompany.Text = Application.CompanyName;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (prgLoading.Value < 100)
				prgLoading.Increment(2);
			else
			{
				timer1.Enabled = false;
				frmMDIParent f = new();

				f.Show();

				f.FormClosed += new FormClosedEventHandler(mdiClose);
				this.Hide();
			}
		}


		private void mdiClose(object? sender, FormClosedEventArgs e)
		{
			this.Close();
		}
	}
}

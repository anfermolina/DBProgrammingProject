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
    public partial class frmMDIParent : Form
    {
        private int childFormNumber = 0;

        public frmMDIParent()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = null;
            object tag = ((ToolStripMenuItem)sender).Tag;

            switch (tag.ToString())
            {
                case "projects":
                    childForm = new frmProjects();
                    break;
                case "developers":
                    childForm = new frmDevelopers();
                    break;
                case "browse":
                    childForm = new frmBrowse();
                    break;
                case "contributors":
                    childForm = new frmProjectContributor();
                    break;
                case "browsedevelopers":
                    childForm = new frmBrowseDevelopers();
                    break;
                case "browseprojects":
                    childForm = new frmBrowseProjects();
                    break;
            }

            // To only have one child form at a time

            if (childForm != null)
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == childForm.GetType())
                    {
                        f.Activate();
                        return;
                    }
                }
            }

            childForm.MdiParent = this;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frmMDIParent_Load(object sender, EventArgs e)
        {
            frmLogin f = new();

            f.StartPosition = FormStartPosition.CenterScreen;

            DialogResult result = f.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("You are now authenticated");
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("You clicked cancel at login");
                this.Close();

            }
            else if (result == DialogResult.Abort)
            {
                MessageBox.Show("Failed login!");
                this.Close();
            }
        }
    }
}

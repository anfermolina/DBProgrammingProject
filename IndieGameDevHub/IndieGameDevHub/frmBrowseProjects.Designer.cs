namespace IndieGameDevHub
{
    partial class frmBrowseProjects
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            cmbProjectId = new ComboBox();
            grpBrowseProjects = new GroupBox();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            grpBrowseProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 48);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // cmbProjectId
            // 
            cmbProjectId.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProjectId.FormattingEnabled = true;
            cmbProjectId.Location = new Point(259, 45);
            cmbProjectId.Name = "cmbProjectId";
            cmbProjectId.Size = new Size(218, 23);
            cmbProjectId.TabIndex = 8;
            // 
            // grpBrowseProjects
            // 
            grpBrowseProjects.BackgroundImage = Properties.Resources.backgroundImage_bn;
            grpBrowseProjects.Controls.Add(btnUpdate);
            grpBrowseProjects.Controls.Add(dataGridView1);
            grpBrowseProjects.Controls.Add(cmbProjectId);
            grpBrowseProjects.Controls.Add(label2);
            grpBrowseProjects.Location = new Point(49, 52);
            grpBrowseProjects.Name = "grpBrowseProjects";
            grpBrowseProjects.Size = new Size(704, 356);
            grpBrowseProjects.TabIndex = 9;
            grpBrowseProjects.TabStop = false;
            grpBrowseProjects.Text = "Browse Projects";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(286, 303);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 27);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(145, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(400, 173);
            dataGridView1.TabIndex = 9;
            // 
            // frmBrowseProjects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundImage;
            ClientSize = new Size(800, 450);
            Controls.Add(grpBrowseProjects);
            Name = "frmBrowseProjects";
            Tag = "";
            Text = "Browse Projects";
            Load += frmBrowseProjects_Load;
            grpBrowseProjects.ResumeLayout(false);
            grpBrowseProjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbProjectId;
        private GroupBox grpBrowseProjects;
        private Button btnUpdate;
        private DataGridView dataGridView1;
    }
}
namespace IndieGameDevHub
{
    partial class frmBrowseDevelopers
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
            cmbDeveloperId = new ComboBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            grpBrowseDevelopers = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpBrowseDevelopers.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 96);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 1;
            label2.Text = "Choose Developer";
            // 
            // cmbDeveloperId
            // 
            cmbDeveloperId.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDeveloperId.FormattingEnabled = true;
            cmbDeveloperId.Location = new Point(190, 93);
            cmbDeveloperId.Name = "cmbDeveloperId";
            cmbDeveloperId.Size = new Size(270, 23);
            cmbDeveloperId.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(249, 349);
            button1.Name = "button1";
            button1.Size = new Size(103, 37);
            button1.TabIndex = 8;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(95, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(441, 187);
            dataGridView1.TabIndex = 9;
            // 
            // grpBrowseDevelopers
            // 
            grpBrowseDevelopers.BackgroundImage = Properties.Resources.backgroundImage_bn;
            grpBrowseDevelopers.Controls.Add(dataGridView1);
            grpBrowseDevelopers.Controls.Add(label2);
            grpBrowseDevelopers.Controls.Add(button1);
            grpBrowseDevelopers.Controls.Add(cmbDeveloperId);
            grpBrowseDevelopers.Location = new Point(105, 50);
            grpBrowseDevelopers.Name = "grpBrowseDevelopers";
            grpBrowseDevelopers.Size = new Size(622, 465);
            grpBrowseDevelopers.TabIndex = 10;
            grpBrowseDevelopers.TabStop = false;
            grpBrowseDevelopers.Text = "Browse Developers";
            // 
            // frmBrowseDevelopers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundImage;
            ClientSize = new Size(843, 599);
            Controls.Add(grpBrowseDevelopers);
            Name = "frmBrowseDevelopers";
            Tag = "";
            Text = "Browse Developers";
            Load += frmBrowseDevelopers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpBrowseDevelopers.ResumeLayout(false);
            grpBrowseDevelopers.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private ComboBox cmbDeveloperId;
        private Button button1;
        private DataGridView dataGridView1;
        private GroupBox grpBrowseDevelopers;
    }
}
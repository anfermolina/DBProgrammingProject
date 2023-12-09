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
            label1 = new Label();
            label2 = new Label();
            cmbDeveloperId = new ComboBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(299, 60);
            label1.Name = "label1";
            label1.Size = new Size(177, 28);
            label1.TabIndex = 0;
            label1.Text = "Browse Developers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 126);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 1;
            label2.Text = "Choose Developer";
            // 
            // cmbDeveloperId
            // 
            cmbDeveloperId.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDeveloperId.FormattingEnabled = true;
            cmbDeveloperId.Location = new Point(285, 123);
            cmbDeveloperId.Name = "cmbDeveloperId";
            cmbDeveloperId.Size = new Size(270, 23);
            cmbDeveloperId.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(344, 379);
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
            dataGridView1.Location = new Point(171, 175);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(459, 187);
            dataGridView1.TabIndex = 9;
            // 
            // frmBrowseDevelopers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(cmbDeveloperId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBrowseDevelopers";
            Tag = "";
            Text = "frmBrowseDevelopers";
            Load += frmBrowseDevelopers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbDeveloperId;
        private Button button1;
        private DataGridView dataGridView1;
    }
}
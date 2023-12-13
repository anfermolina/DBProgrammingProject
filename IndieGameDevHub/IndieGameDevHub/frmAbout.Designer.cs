namespace IndieGameDevHub
{
    partial class frmAbout
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
            lblProduct = new Label();
            lblVersion = new Label();
            lblCompany = new Label();
            grpAbout = new GroupBox();
            grpAbout.SuspendLayout();
            SuspendLayout();
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(97, 61);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(64, 20);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Product";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(191, 145);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(61, 20);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "Version";
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Location = new Point(162, 253);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(121, 20);
            lblCompany.TabIndex = 2;
            lblCompany.Text = "Company Name";
            // 
            // grpAbout
            // 
            grpAbout.BackColor = SystemColors.Control;
            grpAbout.BackgroundImage = Properties.Resources.backgroundImage_bn;
            grpAbout.Controls.Add(lblCompany);
            grpAbout.Controls.Add(lblProduct);
            grpAbout.Controls.Add(lblVersion);
            grpAbout.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            grpAbout.Location = new Point(44, 28);
            grpAbout.Name = "grpAbout";
            grpAbout.Size = new Size(459, 367);
            grpAbout.TabIndex = 3;
            grpAbout.TabStop = false;
            grpAbout.Text = "About";
            // 
            // frmAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.IndieGameDev3;
            ClientSize = new Size(551, 449);
            Controls.Add(grpAbout);
            Name = "frmAbout";
            Text = "About";
            Load += frmAbout_Load;
            grpAbout.ResumeLayout(false);
            grpAbout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblProduct;
        private Label lblVersion;
        private Label lblCompany;
        private GroupBox grpAbout;
    }
}
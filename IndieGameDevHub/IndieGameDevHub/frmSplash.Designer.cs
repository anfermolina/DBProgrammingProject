namespace IndieGameDevHub
{
    partial class frmSplash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            lblProduct = new Label();
            lblVersion = new Label();
            lblCompany = new Label();
            prgLoading = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.BackColor = Color.Transparent;
            lblProduct.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblProduct.ForeColor = Color.White;
            lblProduct.Location = new Point(52, 18);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(100, 28);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "[Product]";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.BackColor = Color.Transparent;
            lblVersion.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblVersion.ForeColor = Color.White;
            lblVersion.Location = new Point(52, 52);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(96, 28);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "[Version]";
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.BackColor = Color.Transparent;
            lblCompany.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompany.ForeColor = Color.White;
            lblCompany.Location = new Point(52, 496);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(114, 28);
            lblCompany.TabIndex = 2;
            lblCompany.Text = "[Company]";
            // 
            // prgLoading
            // 
            prgLoading.Location = new Point(0, 560);
            prgLoading.Name = "prgLoading";
            prgLoading.Size = new Size(1156, 15);
            prgLoading.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // frmSplash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.IndieGameDev3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1154, 571);
            Controls.Add(prgLoading);
            Controls.Add(lblCompany);
            Controls.Add(lblVersion);
            Controls.Add(lblProduct);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmSplash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSplash";
            Load += frmSplash_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduct;
        private Label lblVersion;
        private Label lblCompany;
        private ProgressBar prgLoading;
        private System.Windows.Forms.Timer timer1;
    }
}
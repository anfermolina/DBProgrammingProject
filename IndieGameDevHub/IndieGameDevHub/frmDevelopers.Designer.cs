namespace IndieGameDevHub
{
    partial class frmDevelopers
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
            lblFirstName = new Label();
            lblLastName = new Label();
            lblStudioName = new Label();
            lblLocation = new Label();
            lblWebsite = new Label();
            lblEmail = new Label();
            btnLast = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            btnFirst = new Button();
            btnExit = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtStudioName = new TextBox();
            txtLocation = new TextBox();
            txtWebsite = new TextBox();
            txtEmail = new TextBox();
            lblDeveloperId = new Label();
            txtDeveloperId = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(340, 31);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 0;
            label1.Text = "DEVELOPER";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(109, 119);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(432, 119);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // lblStudioName
            // 
            lblStudioName.AutoSize = true;
            lblStudioName.Location = new Point(109, 159);
            lblStudioName.Name = "lblStudioName";
            lblStudioName.Size = new Size(76, 15);
            lblStudioName.TabIndex = 3;
            lblStudioName.Text = "Studio Name";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(432, 164);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(53, 15);
            lblLocation.TabIndex = 4;
            lblLocation.Text = "Location";
            // 
            // lblWebsite
            // 
            lblWebsite.AutoSize = true;
            lblWebsite.Location = new Point(108, 198);
            lblWebsite.Name = "lblWebsite";
            lblWebsite.Size = new Size(49, 15);
            lblWebsite.TabIndex = 5;
            lblWebsite.Text = "Website";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(108, 238);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // btnLast
            // 
            btnLast.Location = new Point(536, 345);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(103, 32);
            btnLast.TabIndex = 29;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += Navigation_Handler;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(409, 345);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(103, 32);
            btnNext.TabIndex = 28;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += Navigation_Handler;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(300, 345);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(103, 32);
            btnPrevious.TabIndex = 27;
            btnPrevious.Text = "Prev";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += Navigation_Handler;
            // 
            // btnFirst
            // 
            btnFirst.Location = new Point(176, 345);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(103, 32);
            btnFirst.TabIndex = 26;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += Navigation_Handler;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(609, 397);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(103, 32);
            btnExit.TabIndex = 25;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(484, 397);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(103, 32);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(355, 397);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 32);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(225, 397);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(103, 32);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(99, 397);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(103, 32);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(191, 116);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(173, 23);
            txtFirstName.TabIndex = 30;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(521, 116);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(173, 23);
            txtLastName.TabIndex = 31;
            // 
            // txtStudioName
            // 
            txtStudioName.Location = new Point(191, 156);
            txtStudioName.Name = "txtStudioName";
            txtStudioName.Size = new Size(173, 23);
            txtStudioName.TabIndex = 32;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(521, 161);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(173, 23);
            txtLocation.TabIndex = 33;
            // 
            // txtWebsite
            // 
            txtWebsite.Location = new Point(192, 198);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(176, 23);
            txtWebsite.TabIndex = 34;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(191, 238);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(176, 23);
            txtEmail.TabIndex = 35;
            // 
            // lblDeveloperId
            // 
            lblDeveloperId.AutoSize = true;
            lblDeveloperId.Location = new Point(109, 77);
            lblDeveloperId.Name = "lblDeveloperId";
            lblDeveloperId.Size = new Size(73, 15);
            lblDeveloperId.TabIndex = 36;
            lblDeveloperId.Text = "Developer Id";
            // 
            // txtDeveloperId
            // 
            txtDeveloperId.Location = new Point(188, 74);
            txtDeveloperId.Name = "txtDeveloperId";
            txtDeveloperId.Size = new Size(76, 23);
            txtDeveloperId.TabIndex = 37;
            // 
            // frmDevelopers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 466);
            Controls.Add(txtDeveloperId);
            Controls.Add(lblDeveloperId);
            Controls.Add(txtEmail);
            Controls.Add(txtWebsite);
            Controls.Add(txtLocation);
            Controls.Add(txtStudioName);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(btnLast);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnFirst);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblEmail);
            Controls.Add(lblWebsite);
            Controls.Add(lblLocation);
            Controls.Add(lblStudioName);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(label1);
            Name = "frmDevelopers";
            Text = "frmDevelopers";
            Load += frmDevelopers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblStudioName;
        private Label lblLocation;
        private Label lblWebsite;
        private Label lblEmail;
        private Button btnLast;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnFirst;
        private Button btnExit;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtStudioName;
        private TextBox txtLocation;
        private TextBox txtWebsite;
        private TextBox txtEmail;
        private Label lblDeveloperId;
        private TextBox txtDeveloperId;
    }
}
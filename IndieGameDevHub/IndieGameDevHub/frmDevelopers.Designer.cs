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
            components = new System.ComponentModel.Container();
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
            btnCancel = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtStudioName = new TextBox();
            txtLocation = new TextBox();
            txtWebsite = new TextBox();
            txtEmail = new TextBox();
            lblDeveloperId = new Label();
            txtDeveloperId = new TextBox();
            grpDevelopers = new GroupBox();
            errProvider = new ErrorProvider(components);
            grpDevelopers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(89, 88);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 15);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(400, 88);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(65, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // lblStudioName
            // 
            lblStudioName.AutoSize = true;
            lblStudioName.Location = new Point(89, 128);
            lblStudioName.Name = "lblStudioName";
            lblStudioName.Size = new Size(79, 15);
            lblStudioName.TabIndex = 3;
            lblStudioName.Text = "Studio Name";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(400, 133);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(54, 15);
            lblLocation.TabIndex = 4;
            lblLocation.Text = "Location";
            // 
            // lblWebsite
            // 
            lblWebsite.AutoSize = true;
            lblWebsite.Location = new Point(88, 167);
            lblWebsite.Name = "lblWebsite";
            lblWebsite.Size = new Size(53, 15);
            lblWebsite.TabIndex = 5;
            lblWebsite.Text = "Website";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(88, 207);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // btnLast
            // 
            btnLast.Location = new Point(503, 270);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(103, 32);
            btnLast.TabIndex = 29;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += Navigation_Handler;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(376, 270);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(103, 32);
            btnNext.TabIndex = 28;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += Navigation_Handler;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(267, 270);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(103, 32);
            btnPrevious.TabIndex = 27;
            btnPrevious.Text = "Prev";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += Navigation_Handler;
            // 
            // btnFirst
            // 
            btnFirst.Location = new Point(143, 270);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(103, 32);
            btnFirst.TabIndex = 26;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += Navigation_Handler;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(521, 322);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(103, 32);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(392, 322);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 32);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(262, 322);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 32);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(136, 322);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(103, 32);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(171, 85);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(173, 23);
            txtFirstName.TabIndex = 30;
            txtFirstName.Tag = "first name";
            txtFirstName.Validating += txt_Validating;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(489, 85);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(173, 23);
            txtLastName.TabIndex = 31;
            txtLastName.Tag = "last name";
            txtLastName.Validating += txt_Validating;
            // 
            // txtStudioName
            // 
            txtStudioName.Location = new Point(171, 125);
            txtStudioName.Name = "txtStudioName";
            txtStudioName.Size = new Size(173, 23);
            txtStudioName.TabIndex = 32;
            txtStudioName.Tag = "studio name";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(489, 130);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(173, 23);
            txtLocation.TabIndex = 33;
            txtLocation.Tag = "location";
            txtLocation.Validating += txt_Validating;
            // 
            // txtWebsite
            // 
            txtWebsite.Location = new Point(172, 167);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(176, 23);
            txtWebsite.TabIndex = 34;
            txtWebsite.Tag = "website";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(171, 207);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(176, 23);
            txtEmail.TabIndex = 35;
            txtEmail.Tag = "email";
            txtEmail.Validating += txt_Validating;
            // 
            // lblDeveloperId
            // 
            lblDeveloperId.AutoSize = true;
            lblDeveloperId.Location = new Point(89, 46);
            lblDeveloperId.Name = "lblDeveloperId";
            lblDeveloperId.Size = new Size(80, 15);
            lblDeveloperId.TabIndex = 36;
            lblDeveloperId.Text = "Developer Id";
            // 
            // txtDeveloperId
            // 
            txtDeveloperId.Location = new Point(168, 43);
            txtDeveloperId.Name = "txtDeveloperId";
            txtDeveloperId.Size = new Size(76, 23);
            txtDeveloperId.TabIndex = 37;
            // 
            // grpDevelopers
            // 
            grpDevelopers.BackgroundImage = Properties.Resources.backgroundImage_bn;
            grpDevelopers.Controls.Add(btnFirst);
            grpDevelopers.Controls.Add(txtWebsite);
            grpDevelopers.Controls.Add(lblFirstName);
            grpDevelopers.Controls.Add(btnLast);
            grpDevelopers.Controls.Add(txtLocation);
            grpDevelopers.Controls.Add(btnNext);
            grpDevelopers.Controls.Add(btnPrevious);
            grpDevelopers.Controls.Add(txtDeveloperId);
            grpDevelopers.Controls.Add(txtLastName);
            grpDevelopers.Controls.Add(btnCancel);
            grpDevelopers.Controls.Add(lblStudioName);
            grpDevelopers.Controls.Add(btnDelete);
            grpDevelopers.Controls.Add(lblDeveloperId);
            grpDevelopers.Controls.Add(btnSave);
            grpDevelopers.Controls.Add(lblWebsite);
            grpDevelopers.Controls.Add(btnAdd);
            grpDevelopers.Controls.Add(txtEmail);
            grpDevelopers.Controls.Add(lblEmail);
            grpDevelopers.Controls.Add(txtFirstName);
            grpDevelopers.Controls.Add(txtStudioName);
            grpDevelopers.Controls.Add(lblLastName);
            grpDevelopers.Controls.Add(lblLocation);
            grpDevelopers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grpDevelopers.Location = new Point(87, 44);
            grpDevelopers.Name = "grpDevelopers";
            grpDevelopers.Size = new Size(771, 399);
            grpDevelopers.TabIndex = 38;
            grpDevelopers.TabStop = false;
            grpDevelopers.Text = "DEVELOPERS";
            // 
            // errProvider
            // 
            errProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errProvider.ContainerControl = this;
            // 
            // frmDevelopers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackgroundImage = Properties.Resources.backgroundImage;
            ClientSize = new Size(956, 520);
            Controls.Add(grpDevelopers);
            Name = "frmDevelopers";
            Text = "DEVELOPERS";
            Load += frmDevelopers_Load;
            grpDevelopers.ResumeLayout(false);
            grpDevelopers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion
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
        private Button btnCancel;
        private Button btnDelete;
        private Button btnSave;
        private Button btnAdd;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtStudioName;
        private TextBox txtLocation;
        private TextBox txtWebsite;
        private TextBox txtEmail;
        private Label lblDeveloperId;
        private TextBox txtDeveloperId;
        private GroupBox grpDevelopers;
        private ErrorProvider errProvider;
    }
}
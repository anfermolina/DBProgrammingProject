namespace IndieGameDevHub
{
    partial class frmLogin
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
            label1 = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            chkShowPassword = new CheckBox();
            errProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 34);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "User: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 108);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Password: ";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(43, 67);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(293, 27);
            txtUser.TabIndex = 2;
            txtUser.Tag = "user";
            txtUser.Validating += txt_Validating;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(43, 143);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(293, 27);
            txtPassword.TabIndex = 3;
            txtPassword.Tag = "password";
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Validating += txt_Validating;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(43, 192);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(104, 47);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(163, 192);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(104, 47);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(45, 259);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(196, 24);
            chkShowPassword.TabIndex = 6;
            chkShowPassword.Text = "Show Plain Text Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // errProvider
            // 
            errProvider.ContainerControl = this;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackgroundImage = Properties.Resources.backgroundImage;
            ClientSize = new Size(383, 321);
            Controls.Add(chkShowPassword);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmLogin";
            Text = "Login";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnCancel;
        private CheckBox chkShowPassword;
        private ErrorProvider errProvider;
    }
}
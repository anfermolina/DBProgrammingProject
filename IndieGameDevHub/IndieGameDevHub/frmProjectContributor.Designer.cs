namespace IndieGameDevHub
{
    partial class frmProjectContributor
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
            txtContributionId = new TextBox();
            lblContributionId = new Label();
            lblProjectId = new Label();
            lblDeveloperId = new Label();
            lblRole = new Label();
            lblStartDate = new Label();
            lblEndDate = new Label();
            txtRole = new TextBox();
            btnLast = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            btnFirst = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            grpProjectContributor = new GroupBox();
            cmbDeveloperId = new ComboBox();
            cmbProjectId = new ComboBox();
            errProvider = new ErrorProvider(components);
            txtStartDate = new DateTimePicker();
            txtEndDate = new DateTimePicker();
            grpProjectContributor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // txtContributionId
            // 
            txtContributionId.Location = new Point(175, 65);
            txtContributionId.Name = "txtContributionId";
            txtContributionId.Size = new Size(100, 23);
            txtContributionId.TabIndex = 0;
            // 
            // lblContributionId
            // 
            lblContributionId.AutoSize = true;
            lblContributionId.Location = new Point(52, 65);
            lblContributionId.Name = "lblContributionId";
            lblContributionId.Size = new Size(91, 15);
            lblContributionId.TabIndex = 2;
            lblContributionId.Text = "Contribution Id";
            // 
            // lblProjectId
            // 
            lblProjectId.AutoSize = true;
            lblProjectId.Location = new Point(449, 132);
            lblProjectId.Name = "lblProjectId";
            lblProjectId.Size = new Size(47, 15);
            lblProjectId.TabIndex = 3;
            lblProjectId.Text = "Project";
            // 
            // lblDeveloperId
            // 
            lblDeveloperId.AutoSize = true;
            lblDeveloperId.Location = new Point(77, 132);
            lblDeveloperId.Name = "lblDeveloperId";
            lblDeveloperId.Size = new Size(66, 15);
            lblDeveloperId.TabIndex = 4;
            lblDeveloperId.Text = "Developer";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(108, 187);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(32, 15);
            lblRole.TabIndex = 7;
            lblRole.Text = "Role";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(234, 258);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(65, 15);
            lblStartDate.TabIndex = 8;
            lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(437, 255);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(57, 15);
            lblEndDate.TabIndex = 9;
            lblEndDate.Text = "End Date";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(175, 179);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(211, 23);
            txtRole.TabIndex = 14;
            // 
            // btnLast
            // 
            btnLast.Location = new Point(547, 377);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(103, 32);
            btnLast.TabIndex = 29;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += Navigation_Handler;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(426, 377);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(103, 32);
            btnNext.TabIndex = 28;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += Navigation_Handler;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(317, 377);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(103, 32);
            btnPrevious.TabIndex = 27;
            btnPrevious.Text = "Prev";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += Navigation_Handler;
            // 
            // btnFirst
            // 
            btnFirst.Location = new Point(187, 377);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(103, 32);
            btnFirst.TabIndex = 26;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += Navigation_Handler;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(560, 432);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(103, 32);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(431, 432);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 32);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(301, 432);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 32);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(175, 432);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(103, 32);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // grpProjectContributor
            // 
            grpProjectContributor.Controls.Add(txtEndDate);
            grpProjectContributor.Controls.Add(txtStartDate);
            grpProjectContributor.Controls.Add(cmbDeveloperId);
            grpProjectContributor.Controls.Add(cmbProjectId);
            grpProjectContributor.Controls.Add(txtContributionId);
            grpProjectContributor.Controls.Add(btnLast);
            grpProjectContributor.Controls.Add(btnNext);
            grpProjectContributor.Controls.Add(lblContributionId);
            grpProjectContributor.Controls.Add(btnPrevious);
            grpProjectContributor.Controls.Add(lblProjectId);
            grpProjectContributor.Controls.Add(btnFirst);
            grpProjectContributor.Controls.Add(lblDeveloperId);
            grpProjectContributor.Controls.Add(btnCancel);
            grpProjectContributor.Controls.Add(btnDelete);
            grpProjectContributor.Controls.Add(btnSave);
            grpProjectContributor.Controls.Add(btnAdd);
            grpProjectContributor.Controls.Add(lblRole);
            grpProjectContributor.Controls.Add(lblStartDate);
            grpProjectContributor.Controls.Add(txtRole);
            grpProjectContributor.Controls.Add(lblEndDate);
            grpProjectContributor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grpProjectContributor.Location = new Point(35, 62);
            grpProjectContributor.Name = "grpProjectContributor";
            grpProjectContributor.Size = new Size(866, 550);
            grpProjectContributor.TabIndex = 30;
            grpProjectContributor.TabStop = false;
            grpProjectContributor.Text = "Project Contributors";
            // 
            // cmbDeveloperId
            // 
            cmbDeveloperId.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDeveloperId.FormattingEnabled = true;
            cmbDeveloperId.Location = new Point(175, 129);
            cmbDeveloperId.Name = "cmbDeveloperId";
            cmbDeveloperId.Size = new Size(159, 23);
            cmbDeveloperId.TabIndex = 31;
            // 
            // cmbProjectId
            // 
            cmbProjectId.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProjectId.FormattingEnabled = true;
            cmbProjectId.Location = new Point(516, 129);
            cmbProjectId.Name = "cmbProjectId";
            cmbProjectId.Size = new Size(160, 23);
            cmbProjectId.TabIndex = 30;
            // 
            // errProvider
            // 
            errProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errProvider.ContainerControl = this;
            // 
            // txtStartDate
            // 
            txtStartDate.Location = new Point(301, 252);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new Size(100, 23);
            txtStartDate.TabIndex = 32;
            // 
            // txtEndDate
            // 
            txtEndDate.Location = new Point(500, 250);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new Size(100, 23);
            txtEndDate.TabIndex = 33;
            // 
            // frmProjectContributor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 671);
            Controls.Add(grpProjectContributor);
            Name = "frmProjectContributor";
            Text = "ProjectContributor";
            Load += frmProjectContributor_Load;
            grpProjectContributor.ResumeLayout(false);
            grpProjectContributor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtContributionId;
        private Label label1;
        private Label lblContributionId;
        private Label lblProjectId;
        private Label lblDeveloperId;
        private Label lblRole;
        private Label lblStartDate;
        private Label lblEndDate;
        private TextBox txtRole;
        private Button btnLast;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnFirst;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnSave;
        private Button btnAdd;
        private GroupBox grpProjectContributor;
        private ComboBox cmbDeveloperId;
        private ComboBox cmbProjectId;
        private ErrorProvider errProvider;
        private DateTimePicker txtEndDate;
        private DateTimePicker txtStartDate;
    }
}
namespace IndieGameDevHub
{
    partial class frmProjects
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
            lblTitle = new Label();
            label3 = new Label();
            lblGenre = new Label();
            label5 = new Label();
            lblDimensionType = new Label();
            lblDescription = new Label();
            lblStartDate = new Label();
            lblEstimatedDate = new Label();
            lblStatusProject = new Label();
            btnAdd = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            btnFirst = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            btnLast = new Button();
            txtTitle = new TextBox();
            txtGenre = new TextBox();
            txtDescription = new TextBox();
            txtStatusProject = new TextBox();
            grpProjects = new GroupBox();
            txtStartDate = new DateTimePicker();
            txtEngine = new TextBox();
            cmbType = new ComboBox();
            cmbRating = new ComboBox();
            txtProjectId = new TextBox();
            lblProjectId = new Label();
            errProvider = new ErrorProvider(components);
            txtEstimatedDate = new DateTimePicker();
            grpProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(94, 105);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(32, 15);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(446, 105);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Engine";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(94, 132);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(42, 15);
            lblGenre.TabIndex = 3;
            lblGenre.Text = "Genre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(446, 140);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 4;
            label5.Text = "ESRB Rating";
            // 
            // lblDimensionType
            // 
            lblDimensionType.AutoSize = true;
            lblDimensionType.Location = new Point(446, 175);
            lblDimensionType.Name = "lblDimensionType";
            lblDimensionType.Size = new Size(92, 15);
            lblDimensionType.TabIndex = 5;
            lblDimensionType.Text = "DimensionType";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(91, 310);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(71, 15);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(89, 166);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(62, 15);
            lblStartDate.TabIndex = 7;
            lblStartDate.Text = "StartDate";
            // 
            // lblEstimatedDate
            // 
            lblEstimatedDate.AutoSize = true;
            lblEstimatedDate.Location = new Point(91, 238);
            lblEstimatedDate.Name = "lblEstimatedDate";
            lblEstimatedDate.Size = new Size(159, 15);
            lblEstimatedDate.TabIndex = 8;
            lblEstimatedDate.Text = "Estimated Completion Date";
            // 
            // lblStatusProject
            // 
            lblStatusProject.AutoSize = true;
            lblStatusProject.Location = new Point(94, 272);
            lblStatusProject.Name = "lblStatusProject";
            lblStatusProject.Size = new Size(126, 15);
            lblStatusProject.TabIndex = 9;
            lblStatusProject.Text = "Status Of The Project";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(128, 430);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(103, 32);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(254, 430);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 32);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(384, 430);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 32);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(513, 430);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(103, 32);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnFirst
            // 
            btnFirst.Location = new Point(140, 381);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(103, 32);
            btnFirst.TabIndex = 17;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += Navigation_Handler;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(270, 381);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(103, 32);
            btnPrevious.TabIndex = 18;
            btnPrevious.Text = "Prev";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += Navigation_Handler;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(379, 381);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(103, 32);
            btnNext.TabIndex = 19;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += Navigation_Handler;
            // 
            // btnLast
            // 
            btnLast.Location = new Point(500, 381);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(103, 32);
            btnLast.TabIndex = 20;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += Navigation_Handler;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(188, 102);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(200, 23);
            txtTitle.TabIndex = 21;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(188, 132);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(124, 23);
            txtGenre.TabIndex = 22;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(185, 310);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(462, 23);
            txtDescription.TabIndex = 26;
            // 
            // txtStatusProject
            // 
            txtStatusProject.Location = new Point(270, 269);
            txtStatusProject.Name = "txtStatusProject";
            txtStatusProject.Size = new Size(124, 23);
            txtStatusProject.TabIndex = 29;
            // 
            // grpProjects
            // 
            grpProjects.Controls.Add(txtEstimatedDate);
            grpProjects.Controls.Add(txtStartDate);
            grpProjects.Controls.Add(txtEngine);
            grpProjects.Controls.Add(cmbType);
            grpProjects.Controls.Add(cmbRating);
            grpProjects.Controls.Add(txtProjectId);
            grpProjects.Controls.Add(lblProjectId);
            grpProjects.Controls.Add(txtTitle);
            grpProjects.Controls.Add(btnLast);
            grpProjects.Controls.Add(btnNext);
            grpProjects.Controls.Add(txtStatusProject);
            grpProjects.Controls.Add(btnPrevious);
            grpProjects.Controls.Add(btnFirst);
            grpProjects.Controls.Add(btnCancel);
            grpProjects.Controls.Add(lblTitle);
            grpProjects.Controls.Add(btnDelete);
            grpProjects.Controls.Add(btnSave);
            grpProjects.Controls.Add(lblGenre);
            grpProjects.Controls.Add(btnAdd);
            grpProjects.Controls.Add(lblDimensionType);
            grpProjects.Controls.Add(txtDescription);
            grpProjects.Controls.Add(lblDescription);
            grpProjects.Controls.Add(lblStartDate);
            grpProjects.Controls.Add(label5);
            grpProjects.Controls.Add(label3);
            grpProjects.Controls.Add(lblEstimatedDate);
            grpProjects.Controls.Add(lblStatusProject);
            grpProjects.Controls.Add(txtGenre);
            grpProjects.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grpProjects.Location = new Point(50, 53);
            grpProjects.Name = "grpProjects";
            grpProjects.Size = new Size(743, 520);
            grpProjects.TabIndex = 30;
            grpProjects.TabStop = false;
            grpProjects.Text = "Projects";
            // 
            // txtStartDate
            // 
            txtStartDate.Location = new Point(185, 166);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new Size(139, 23);
            txtStartDate.TabIndex = 35;
            // 
            // txtEngine
            // 
            txtEngine.Location = new Point(575, 97);
            txtEngine.Name = "txtEngine";
            txtEngine.Size = new Size(124, 23);
            txtEngine.TabIndex = 34;
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(575, 175);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(135, 23);
            cmbType.TabIndex = 33;
            // 
            // cmbRating
            // 
            cmbRating.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRating.FormattingEnabled = true;
            cmbRating.Location = new Point(575, 137);
            cmbRating.Name = "cmbRating";
            cmbRating.Size = new Size(135, 23);
            cmbRating.TabIndex = 32;
            // 
            // txtProjectId
            // 
            txtProjectId.Location = new Point(331, 41);
            txtProjectId.Name = "txtProjectId";
            txtProjectId.Size = new Size(57, 23);
            txtProjectId.TabIndex = 31;
            // 
            // lblProjectId
            // 
            lblProjectId.AutoSize = true;
            lblProjectId.Location = new Point(240, 44);
            lblProjectId.Name = "lblProjectId";
            lblProjectId.Size = new Size(63, 15);
            lblProjectId.TabIndex = 30;
            lblProjectId.Text = "Project ID";
            // 
            // errProvider
            // 
            errProvider.ContainerControl = this;
            // 
            // txtEstimatedDate
            // 
            txtEstimatedDate.Location = new Point(264, 237);
            txtEstimatedDate.Name = "txtEstimatedDate";
            txtEstimatedDate.Size = new Size(168, 23);
            txtEstimatedDate.TabIndex = 36;
            // 
            // frmProjects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 619);
            Controls.Add(grpProjects);
            Name = "frmProjects";
            Text = "frmProjects";
            Load += frmProjects_Load;
            grpProjects.ResumeLayout(false);
            grpProjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblTitle;
        private Label label3;
        private Label lblGenre;
        private Label label5;
        private Label lblDimensionType;
        private Label lblDescription;
        private Label lblStartDate;
        private Label lblEstimatedDate;
        private Label lblStatusProject;
        private Button btnAdd;
        private Button btnSave;
        private Button btnDelete;
        private Button btnCancel;
        private Button btnFirst;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnLast;
        private TextBox txtTitle;
        private TextBox txtGenre;
        private TextBox txtDescription;
        private TextBox txtStatusProject;
        private GroupBox grpProjects;
        private TextBox txtProjectId;
        private Label lblProjectId;
        private ComboBox cmbType;
        private ComboBox cmbRating;
        private TextBox txtEngine;
        private ErrorProvider errProvider;
        private DateTimePicker txtStartDate;
        private DateTimePicker txtEstimatedDate;
    }
}
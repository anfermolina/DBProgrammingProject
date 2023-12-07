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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			listBox1 = new ListBox();
			label7 = new Label();
			comboBox1 = new ComboBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(316, 50);
			label1.Name = "label1";
			label1.Size = new Size(148, 28);
			label1.TabIndex = 0;
			label1.Text = "Browse Projects";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(113, 119);
			label2.Name = "label2";
			label2.Size = new Size(29, 15);
			label2.TabIndex = 1;
			label2.Text = "Title";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(113, 150);
			label3.Name = "label3";
			label3.Size = new Size(38, 15);
			label3.TabIndex = 2;
			label3.Text = "Genre";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(449, 119);
			label4.Name = "label4";
			label4.Size = new Size(58, 15);
			label4.TabIndex = 3;
			label4.Text = "Start Date";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(449, 150);
			label5.Name = "label5";
			label5.Size = new Size(152, 15);
			label5.TabIndex = 4;
			label5.Text = "Estimated Completion Date";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(113, 219);
			label6.Name = "label6";
			label6.Size = new Size(60, 15);
			label6.TabIndex = 5;
			label6.Text = "Developer";
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Location = new Point(113, 251);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(513, 154);
			listBox1.TabIndex = 6;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(502, 219);
			label7.Name = "label7";
			label7.Size = new Size(30, 15);
			label7.TabIndex = 7;
			label7.Text = "Role";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(157, 116);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(218, 23);
			comboBox1.TabIndex = 8;
			// 
			// frmBrowseProjects
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(comboBox1);
			Controls.Add(label7);
			Controls.Add(listBox1);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "frmBrowseProjects";
			Tag = "";
			Text = "frmBrowseProjects";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private ListBox listBox1;
		private Label label7;
		private ComboBox comboBox1;
	}
}
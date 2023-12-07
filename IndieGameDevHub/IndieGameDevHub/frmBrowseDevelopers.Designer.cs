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
			comboBox1 = new ComboBox();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			listBox1 = new ListBox();
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
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(285, 123);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(270, 23);
			comboBox1.TabIndex = 2;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(266, 240);
			label3.Name = "label3";
			label3.Size = new Size(29, 15);
			label3.TabIndex = 3;
			label3.Text = "Title";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(366, 240);
			label4.Name = "label4";
			label4.Size = new Size(38, 15);
			label4.TabIndex = 4;
			label4.Text = "Genre";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(475, 240);
			label5.Name = "label5";
			label5.Size = new Size(30, 15);
			label5.TabIndex = 5;
			label5.Text = "Role";
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Location = new Point(254, 276);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(301, 94);
			listBox1.TabIndex = 6;
			// 
			// frmBrowseDevelopers
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(listBox1);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(comboBox1);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "frmBrowseDevelopers";
			Tag = "";
			Text = "frmBrowseDevelopers";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private ComboBox comboBox1;
		private Label label3;
		private Label label4;
		private Label label5;
		private ListBox listBox1;
	}
}
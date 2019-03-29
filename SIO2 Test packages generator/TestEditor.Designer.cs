namespace SIO2_Test_packages_generator
{
	partial class TestEditor
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
			this.idLabel = new MetroFramework.Controls.MetroLabel();
			this.pointsLabel = new MetroFramework.Controls.MetroLabel();
			this.typeComboBox = new MetroFramework.Controls.MetroComboBox();
			this.idTextBox = new MetroFramework.Controls.MetroTextBox();
			this.pointsTextBox = new MetroFramework.Controls.MetroTextBox();
			this.typeLabel = new MetroFramework.Controls.MetroLabel();
			this.inputLabel = new MetroFramework.Controls.MetroLabel();
			this.inputTextBox = new MetroFramework.Controls.MetroTextBox();
			this.outputTextBox = new MetroFramework.Controls.MetroTextBox();
			this.outputLabel = new MetroFramework.Controls.MetroLabel();
			this.okButton = new MetroFramework.Controls.MetroButton();
			this.generateOutputButton = new MetroFramework.Controls.MetroButton();
			this.deleteButton = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// idLabel
			// 
			this.idLabel.AutoSize = true;
			this.idLabel.Location = new System.Drawing.Point(23, 74);
			this.idLabel.Name = "idLabel";
			this.idLabel.Size = new System.Drawing.Size(49, 19);
			this.idLabel.TabIndex = 0;
			this.idLabel.Text = "Test ID:";
			// 
			// pointsLabel
			// 
			this.pointsLabel.AutoSize = true;
			this.pointsLabel.Location = new System.Drawing.Point(26, 103);
			this.pointsLabel.Name = "pointsLabel";
			this.pointsLabel.Size = new System.Drawing.Size(46, 19);
			this.pointsLabel.TabIndex = 1;
			this.pointsLabel.Text = "Points:";
			// 
			// typeComboBox
			// 
			this.typeComboBox.FormattingEnabled = true;
			this.typeComboBox.ItemHeight = 23;
			this.typeComboBox.Items.AddRange(new object[] {
            "Normal",
            "Slow",
            "Incorrect"});
			this.typeComboBox.Location = new System.Drawing.Point(78, 128);
			this.typeComboBox.Name = "typeComboBox";
			this.typeComboBox.Size = new System.Drawing.Size(121, 29);
			this.typeComboBox.TabIndex = 2;
			this.typeComboBox.UseSelectable = true;
			this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
			// 
			// idTextBox
			// 
			// 
			// 
			// 
			this.idTextBox.CustomButton.Image = null;
			this.idTextBox.CustomButton.Location = new System.Drawing.Point(68, 1);
			this.idTextBox.CustomButton.Name = "";
			this.idTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.idTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.idTextBox.CustomButton.TabIndex = 1;
			this.idTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.idTextBox.CustomButton.UseSelectable = true;
			this.idTextBox.CustomButton.Visible = false;
			this.idTextBox.Lines = new string[0];
			this.idTextBox.Location = new System.Drawing.Point(78, 70);
			this.idTextBox.MaxLength = 32767;
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.PasswordChar = '\0';
			this.idTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.idTextBox.SelectedText = "";
			this.idTextBox.SelectionLength = 0;
			this.idTextBox.SelectionStart = 0;
			this.idTextBox.ShortcutsEnabled = true;
			this.idTextBox.Size = new System.Drawing.Size(90, 23);
			this.idTextBox.TabIndex = 3;
			this.idTextBox.UseSelectable = true;
			this.idTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.idTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// pointsTextBox
			// 
			// 
			// 
			// 
			this.pointsTextBox.CustomButton.Image = null;
			this.pointsTextBox.CustomButton.Location = new System.Drawing.Point(68, 1);
			this.pointsTextBox.CustomButton.Name = "";
			this.pointsTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.pointsTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.pointsTextBox.CustomButton.TabIndex = 1;
			this.pointsTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.pointsTextBox.CustomButton.UseSelectable = true;
			this.pointsTextBox.CustomButton.Visible = false;
			this.pointsTextBox.Lines = new string[] {
        "20"};
			this.pointsTextBox.Location = new System.Drawing.Point(78, 99);
			this.pointsTextBox.MaxLength = 32767;
			this.pointsTextBox.Name = "pointsTextBox";
			this.pointsTextBox.PasswordChar = '\0';
			this.pointsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.pointsTextBox.SelectedText = "";
			this.pointsTextBox.SelectionLength = 0;
			this.pointsTextBox.SelectionStart = 0;
			this.pointsTextBox.ShortcutsEnabled = true;
			this.pointsTextBox.Size = new System.Drawing.Size(90, 23);
			this.pointsTextBox.TabIndex = 5;
			this.pointsTextBox.Text = "20";
			this.pointsTextBox.UseSelectable = true;
			this.pointsTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.pointsTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.pointsTextBox.TextChanged += new System.EventHandler(this.pointsTextBox_TextChanged);
			// 
			// typeLabel
			// 
			this.typeLabel.AutoSize = true;
			this.typeLabel.Location = new System.Drawing.Point(33, 138);
			this.typeLabel.Name = "typeLabel";
			this.typeLabel.Size = new System.Drawing.Size(39, 19);
			this.typeLabel.TabIndex = 6;
			this.typeLabel.Text = "Type:";
			// 
			// inputLabel
			// 
			this.inputLabel.AutoSize = true;
			this.inputLabel.Location = new System.Drawing.Point(31, 167);
			this.inputLabel.Name = "inputLabel";
			this.inputLabel.Size = new System.Drawing.Size(41, 19);
			this.inputLabel.TabIndex = 7;
			this.inputLabel.Text = "Input:";
			// 
			// inputTextBox
			// 
			// 
			// 
			// 
			this.inputTextBox.CustomButton.Image = null;
			this.inputTextBox.CustomButton.Location = new System.Drawing.Point(471, 2);
			this.inputTextBox.CustomButton.Name = "";
			this.inputTextBox.CustomButton.Size = new System.Drawing.Size(157, 157);
			this.inputTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.inputTextBox.CustomButton.TabIndex = 1;
			this.inputTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.inputTextBox.CustomButton.UseSelectable = true;
			this.inputTextBox.CustomButton.Visible = false;
			this.inputTextBox.Lines = new string[0];
			this.inputTextBox.Location = new System.Drawing.Point(78, 163);
			this.inputTextBox.MaxLength = 32767;
			this.inputTextBox.Multiline = true;
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.PasswordChar = '\0';
			this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.inputTextBox.SelectedText = "";
			this.inputTextBox.SelectionLength = 0;
			this.inputTextBox.SelectionStart = 0;
			this.inputTextBox.ShortcutsEnabled = true;
			this.inputTextBox.Size = new System.Drawing.Size(631, 162);
			this.inputTextBox.TabIndex = 8;
			this.inputTextBox.UseSelectable = true;
			this.inputTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.inputTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// outputTextBox
			// 
			// 
			// 
			// 
			this.outputTextBox.CustomButton.Image = null;
			this.outputTextBox.CustomButton.Location = new System.Drawing.Point(471, 2);
			this.outputTextBox.CustomButton.Name = "";
			this.outputTextBox.CustomButton.Size = new System.Drawing.Size(157, 157);
			this.outputTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.outputTextBox.CustomButton.TabIndex = 1;
			this.outputTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.outputTextBox.CustomButton.UseSelectable = true;
			this.outputTextBox.CustomButton.Visible = false;
			this.outputTextBox.Lines = new string[0];
			this.outputTextBox.Location = new System.Drawing.Point(78, 331);
			this.outputTextBox.MaxLength = 32767;
			this.outputTextBox.Multiline = true;
			this.outputTextBox.Name = "outputTextBox";
			this.outputTextBox.PasswordChar = '\0';
			this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.outputTextBox.SelectedText = "";
			this.outputTextBox.SelectionLength = 0;
			this.outputTextBox.SelectionStart = 0;
			this.outputTextBox.ShortcutsEnabled = true;
			this.outputTextBox.Size = new System.Drawing.Size(631, 162);
			this.outputTextBox.TabIndex = 10;
			this.outputTextBox.UseSelectable = true;
			this.outputTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.outputTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// outputLabel
			// 
			this.outputLabel.AutoSize = true;
			this.outputLabel.Location = new System.Drawing.Point(19, 335);
			this.outputLabel.Name = "outputLabel";
			this.outputLabel.Size = new System.Drawing.Size(53, 19);
			this.outputLabel.TabIndex = 9;
			this.outputLabel.Text = "Output:";
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(78, 516);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 11;
			this.okButton.Text = "Ok";
			this.okButton.UseSelectable = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// generateOutputButton
			// 
			this.generateOutputButton.Location = new System.Drawing.Point(168, 516);
			this.generateOutputButton.Name = "generateOutputButton";
			this.generateOutputButton.Size = new System.Drawing.Size(115, 23);
			this.generateOutputButton.TabIndex = 12;
			this.generateOutputButton.Text = "Generate output";
			this.generateOutputButton.UseSelectable = true;
			this.generateOutputButton.Click += new System.EventHandler(this.generateOutputButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(634, 516);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 13;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseSelectable = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// TestEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(823, 551);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.generateOutputButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.outputTextBox);
			this.Controls.Add(this.outputLabel);
			this.Controls.Add(this.inputTextBox);
			this.Controls.Add(this.inputLabel);
			this.Controls.Add(this.typeLabel);
			this.Controls.Add(this.pointsTextBox);
			this.Controls.Add(this.idTextBox);
			this.Controls.Add(this.typeComboBox);
			this.Controls.Add(this.pointsLabel);
			this.Controls.Add(this.idLabel);
			this.MaximizeBox = false;
			this.Name = "TestEditor";
			this.Resizable = false;
			this.Text = "Test Editor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestEditor_FormClosing);
			this.Load += new System.EventHandler(this.TestEditor_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel idLabel;
		private MetroFramework.Controls.MetroLabel pointsLabel;
		private MetroFramework.Controls.MetroComboBox typeComboBox;
		private MetroFramework.Controls.MetroTextBox idTextBox;
		private MetroFramework.Controls.MetroTextBox pointsTextBox;
		private MetroFramework.Controls.MetroLabel typeLabel;
		private MetroFramework.Controls.MetroLabel inputLabel;
		private MetroFramework.Controls.MetroTextBox inputTextBox;
		private MetroFramework.Controls.MetroTextBox outputTextBox;
		private MetroFramework.Controls.MetroLabel outputLabel;
		private MetroFramework.Controls.MetroButton okButton;
		private MetroFramework.Controls.MetroButton generateOutputButton;
		private MetroFramework.Controls.MetroButton deleteButton;
	}
}
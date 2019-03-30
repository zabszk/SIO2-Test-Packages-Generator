namespace SIO2_Test_packages_generator
{
	partial class BulkAdding
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BulkAdding));
			this.folderModeRadio = new MetroFramework.Controls.MetroRadioButton();
			this.sourcesLabel = new MetroFramework.Controls.MetroLabel();
			this.folderModeDesc = new MetroFramework.Controls.MetroLabel();
			this.inputDirLabel = new MetroFramework.Controls.MetroLabel();
			this.inputDirTextBox = new MetroFramework.Controls.MetroTextBox();
			this.folderModePanel = new MetroFramework.Controls.MetroPanel();
			this.outputDirBrowse = new MetroFramework.Controls.MetroButton();
			this.inputDirBrowse = new MetroFramework.Controls.MetroButton();
			this.folderModeAutoGenCheckBox = new MetroFramework.Controls.MetroCheckBox();
			this.outputDirLabel = new MetroFramework.Controls.MetroLabel();
			this.outputDirTextBox = new MetroFramework.Controls.MetroTextBox();
			this.fileModeRadio = new MetroFramework.Controls.MetroRadioButton();
			this.fileModePanel = new MetroFramework.Controls.MetroPanel();
			this.filePathBrowse = new MetroFramework.Controls.MetroButton();
			this.filePathLabel = new MetroFramework.Controls.MetroLabel();
			this.filePathTextBox = new MetroFramework.Controls.MetroTextBox();
			this.fileModeDesc = new MetroFramework.Controls.MetroLabel();
			this.addTestsButton = new MetroFramework.Controls.MetroButton();
			this.browseFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.browseFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.addLabel = new MetroFramework.Controls.MetroLabel();
			this.addSpinner = new MetroFramework.Controls.MetroProgressSpinner();
			this.folderModePanel.SuspendLayout();
			this.fileModePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// folderModeRadio
			// 
			this.folderModeRadio.AutoSize = true;
			this.folderModeRadio.Checked = true;
			this.folderModeRadio.Location = new System.Drawing.Point(23, 103);
			this.folderModeRadio.Name = "folderModeRadio";
			this.folderModeRadio.Size = new System.Drawing.Size(90, 15);
			this.folderModeRadio.TabIndex = 0;
			this.folderModeRadio.TabStop = true;
			this.folderModeRadio.Text = "Folder Mode";
			this.folderModeRadio.UseSelectable = true;
			this.folderModeRadio.CheckedChanged += new System.EventHandler(this.ModeChanged);
			// 
			// sourcesLabel
			// 
			this.sourcesLabel.AutoSize = true;
			this.sourcesLabel.Location = new System.Drawing.Point(23, 71);
			this.sourcesLabel.Name = "sourcesLabel";
			this.sourcesLabel.Size = new System.Drawing.Size(172, 19);
			this.sourcesLabel.TabIndex = 1;
			this.sourcesLabel.Text = "Please select import source:";
			// 
			// folderModeDesc
			// 
			this.folderModeDesc.AutoSize = true;
			this.folderModeDesc.Location = new System.Drawing.Point(3, 13);
			this.folderModeDesc.Name = "folderModeDesc";
			this.folderModeDesc.Size = new System.Drawing.Size(816, 95);
			this.folderModeDesc.TabIndex = 2;
			this.folderModeDesc.Text = resources.GetString("folderModeDesc.Text");
			// 
			// inputDirLabel
			// 
			this.inputDirLabel.AutoSize = true;
			this.inputDirLabel.Location = new System.Drawing.Point(15, 138);
			this.inputDirLabel.Name = "inputDirLabel";
			this.inputDirLabel.Size = new System.Drawing.Size(86, 19);
			this.inputDirLabel.TabIndex = 3;
			this.inputDirLabel.Text = "Inputs folder:";
			// 
			// inputDirTextBox
			// 
			// 
			// 
			// 
			this.inputDirTextBox.CustomButton.Image = null;
			this.inputDirTextBox.CustomButton.Location = new System.Drawing.Point(378, 1);
			this.inputDirTextBox.CustomButton.Name = "";
			this.inputDirTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.inputDirTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.inputDirTextBox.CustomButton.TabIndex = 1;
			this.inputDirTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.inputDirTextBox.CustomButton.UseSelectable = true;
			this.inputDirTextBox.CustomButton.Visible = false;
			this.inputDirTextBox.Lines = new string[0];
			this.inputDirTextBox.Location = new System.Drawing.Point(107, 134);
			this.inputDirTextBox.MaxLength = 32767;
			this.inputDirTextBox.Name = "inputDirTextBox";
			this.inputDirTextBox.PasswordChar = '\0';
			this.inputDirTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.inputDirTextBox.SelectedText = "";
			this.inputDirTextBox.SelectionLength = 0;
			this.inputDirTextBox.SelectionStart = 0;
			this.inputDirTextBox.ShortcutsEnabled = true;
			this.inputDirTextBox.Size = new System.Drawing.Size(400, 23);
			this.inputDirTextBox.TabIndex = 4;
			this.inputDirTextBox.UseSelectable = true;
			this.inputDirTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.inputDirTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// folderModePanel
			// 
			this.folderModePanel.Controls.Add(this.outputDirBrowse);
			this.folderModePanel.Controls.Add(this.inputDirBrowse);
			this.folderModePanel.Controls.Add(this.folderModeAutoGenCheckBox);
			this.folderModePanel.Controls.Add(this.outputDirLabel);
			this.folderModePanel.Controls.Add(this.outputDirTextBox);
			this.folderModePanel.Controls.Add(this.inputDirLabel);
			this.folderModePanel.Controls.Add(this.inputDirTextBox);
			this.folderModePanel.Controls.Add(this.folderModeDesc);
			this.folderModePanel.HorizontalScrollbarBarColor = true;
			this.folderModePanel.HorizontalScrollbarHighlightOnWheel = false;
			this.folderModePanel.HorizontalScrollbarSize = 10;
			this.folderModePanel.Location = new System.Drawing.Point(23, 124);
			this.folderModePanel.Name = "folderModePanel";
			this.folderModePanel.Size = new System.Drawing.Size(854, 225);
			this.folderModePanel.TabIndex = 5;
			this.folderModePanel.VerticalScrollbarBarColor = true;
			this.folderModePanel.VerticalScrollbarHighlightOnWheel = false;
			this.folderModePanel.VerticalScrollbarSize = 10;
			// 
			// outputDirBrowse
			// 
			this.outputDirBrowse.Location = new System.Drawing.Point(513, 163);
			this.outputDirBrowse.Name = "outputDirBrowse";
			this.outputDirBrowse.Size = new System.Drawing.Size(75, 23);
			this.outputDirBrowse.TabIndex = 9;
			this.outputDirBrowse.Text = "Browse";
			this.outputDirBrowse.UseSelectable = true;
			this.outputDirBrowse.Click += new System.EventHandler(this.FolderBrowse);
			// 
			// inputDirBrowse
			// 
			this.inputDirBrowse.Location = new System.Drawing.Point(513, 134);
			this.inputDirBrowse.Name = "inputDirBrowse";
			this.inputDirBrowse.Size = new System.Drawing.Size(75, 23);
			this.inputDirBrowse.TabIndex = 8;
			this.inputDirBrowse.Text = "Browse";
			this.inputDirBrowse.UseSelectable = true;
			this.inputDirBrowse.Click += new System.EventHandler(this.FolderBrowse);
			// 
			// folderModeAutoGenCheckBox
			// 
			this.folderModeAutoGenCheckBox.AutoSize = true;
			this.folderModeAutoGenCheckBox.Location = new System.Drawing.Point(107, 192);
			this.folderModeAutoGenCheckBox.Name = "folderModeAutoGenCheckBox";
			this.folderModeAutoGenCheckBox.Size = new System.Drawing.Size(114, 15);
			this.folderModeAutoGenCheckBox.TabIndex = 7;
			this.folderModeAutoGenCheckBox.Text = "Generate outputs";
			this.folderModeAutoGenCheckBox.UseSelectable = true;
			this.folderModeAutoGenCheckBox.CheckedChanged += new System.EventHandler(this.folderModeAutoGenCheckBox_CheckedChanged);
			// 
			// outputDirLabel
			// 
			this.outputDirLabel.AutoSize = true;
			this.outputDirLabel.Location = new System.Drawing.Point(3, 167);
			this.outputDirLabel.Name = "outputDirLabel";
			this.outputDirLabel.Size = new System.Drawing.Size(98, 19);
			this.outputDirLabel.TabIndex = 5;
			this.outputDirLabel.Text = "Outputs folder:";
			// 
			// outputDirTextBox
			// 
			// 
			// 
			// 
			this.outputDirTextBox.CustomButton.Image = null;
			this.outputDirTextBox.CustomButton.Location = new System.Drawing.Point(378, 1);
			this.outputDirTextBox.CustomButton.Name = "";
			this.outputDirTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.outputDirTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.outputDirTextBox.CustomButton.TabIndex = 1;
			this.outputDirTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.outputDirTextBox.CustomButton.UseSelectable = true;
			this.outputDirTextBox.CustomButton.Visible = false;
			this.outputDirTextBox.Lines = new string[0];
			this.outputDirTextBox.Location = new System.Drawing.Point(107, 163);
			this.outputDirTextBox.MaxLength = 32767;
			this.outputDirTextBox.Name = "outputDirTextBox";
			this.outputDirTextBox.PasswordChar = '\0';
			this.outputDirTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.outputDirTextBox.SelectedText = "";
			this.outputDirTextBox.SelectionLength = 0;
			this.outputDirTextBox.SelectionStart = 0;
			this.outputDirTextBox.ShortcutsEnabled = true;
			this.outputDirTextBox.Size = new System.Drawing.Size(400, 23);
			this.outputDirTextBox.TabIndex = 6;
			this.outputDirTextBox.UseSelectable = true;
			this.outputDirTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.outputDirTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// fileModeRadio
			// 
			this.fileModeRadio.AutoSize = true;
			this.fileModeRadio.Location = new System.Drawing.Point(23, 379);
			this.fileModeRadio.Name = "fileModeRadio";
			this.fileModeRadio.Size = new System.Drawing.Size(75, 15);
			this.fileModeRadio.TabIndex = 6;
			this.fileModeRadio.Text = "File Mode";
			this.fileModeRadio.UseSelectable = true;
			this.fileModeRadio.CheckedChanged += new System.EventHandler(this.ModeChanged);
			// 
			// fileModePanel
			// 
			this.fileModePanel.Controls.Add(this.filePathBrowse);
			this.fileModePanel.Controls.Add(this.filePathLabel);
			this.fileModePanel.Controls.Add(this.filePathTextBox);
			this.fileModePanel.Controls.Add(this.fileModeDesc);
			this.fileModePanel.Enabled = false;
			this.fileModePanel.HorizontalScrollbarBarColor = true;
			this.fileModePanel.HorizontalScrollbarHighlightOnWheel = false;
			this.fileModePanel.HorizontalScrollbarSize = 10;
			this.fileModePanel.Location = new System.Drawing.Point(23, 399);
			this.fileModePanel.Name = "fileModePanel";
			this.fileModePanel.Size = new System.Drawing.Size(854, 177);
			this.fileModePanel.TabIndex = 7;
			this.fileModePanel.VerticalScrollbarBarColor = true;
			this.fileModePanel.VerticalScrollbarHighlightOnWheel = false;
			this.fileModePanel.VerticalScrollbarSize = 10;
			// 
			// filePathBrowse
			// 
			this.filePathBrowse.Location = new System.Drawing.Point(513, 134);
			this.filePathBrowse.Name = "filePathBrowse";
			this.filePathBrowse.Size = new System.Drawing.Size(75, 23);
			this.filePathBrowse.TabIndex = 10;
			this.filePathBrowse.Text = "Browse";
			this.filePathBrowse.UseSelectable = true;
			this.filePathBrowse.Click += new System.EventHandler(this.filePathBrowse_Click);
			// 
			// filePathLabel
			// 
			this.filePathLabel.AutoSize = true;
			this.filePathLabel.Location = new System.Drawing.Point(34, 138);
			this.filePathLabel.Name = "filePathLabel";
			this.filePathLabel.Size = new System.Drawing.Size(67, 19);
			this.filePathLabel.TabIndex = 3;
			this.filePathLabel.Text = "Inputs file:";
			// 
			// filePathTextBox
			// 
			// 
			// 
			// 
			this.filePathTextBox.CustomButton.Image = null;
			this.filePathTextBox.CustomButton.Location = new System.Drawing.Point(378, 1);
			this.filePathTextBox.CustomButton.Name = "";
			this.filePathTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.filePathTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.filePathTextBox.CustomButton.TabIndex = 1;
			this.filePathTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.filePathTextBox.CustomButton.UseSelectable = true;
			this.filePathTextBox.CustomButton.Visible = false;
			this.filePathTextBox.Lines = new string[0];
			this.filePathTextBox.Location = new System.Drawing.Point(107, 134);
			this.filePathTextBox.MaxLength = 32767;
			this.filePathTextBox.Name = "filePathTextBox";
			this.filePathTextBox.PasswordChar = '\0';
			this.filePathTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.filePathTextBox.SelectedText = "";
			this.filePathTextBox.SelectionLength = 0;
			this.filePathTextBox.SelectionStart = 0;
			this.filePathTextBox.ShortcutsEnabled = true;
			this.filePathTextBox.Size = new System.Drawing.Size(400, 23);
			this.filePathTextBox.TabIndex = 4;
			this.filePathTextBox.UseSelectable = true;
			this.filePathTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.filePathTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// fileModeDesc
			// 
			this.fileModeDesc.AutoSize = true;
			this.fileModeDesc.Location = new System.Drawing.Point(3, 13);
			this.fileModeDesc.Name = "fileModeDesc";
			this.fileModeDesc.Size = new System.Drawing.Size(527, 76);
			this.fileModeDesc.TabIndex = 2;
			this.fileModeDesc.Text = resources.GetString("fileModeDesc.Text");
			// 
			// addTestsButton
			// 
			this.addTestsButton.Location = new System.Drawing.Point(23, 591);
			this.addTestsButton.Name = "addTestsButton";
			this.addTestsButton.Size = new System.Drawing.Size(75, 23);
			this.addTestsButton.TabIndex = 8;
			this.addTestsButton.Text = "Add tests";
			this.addTestsButton.UseSelectable = true;
			this.addTestsButton.Click += new System.EventHandler(this.addTestsButton_Click);
			// 
			// browseFileDialog
			// 
			this.browseFileDialog.FileName = "SIO2 Test Packages Generator Browse";
			this.browseFileDialog.RestoreDirectory = true;
			// 
			// addLabel
			// 
			this.addLabel.AutoSize = true;
			this.addLabel.Location = new System.Drawing.Point(177, 595);
			this.addLabel.Name = "addLabel";
			this.addLabel.Size = new System.Drawing.Size(127, 19);
			this.addLabel.TabIndex = 9;
			this.addLabel.Text = "Processing test X/Y...";
			this.addLabel.Visible = false;
			// 
			// addSpinner
			// 
			this.addSpinner.Location = new System.Drawing.Point(149, 591);
			this.addSpinner.Maximum = 100;
			this.addSpinner.Name = "addSpinner";
			this.addSpinner.Size = new System.Drawing.Size(22, 23);
			this.addSpinner.TabIndex = 11;
			this.addSpinner.UseSelectable = true;
			this.addSpinner.Visible = false;
			// 
			// BulkAdding
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 631);
			this.Controls.Add(this.addSpinner);
			this.Controls.Add(this.addLabel);
			this.Controls.Add(this.addTestsButton);
			this.Controls.Add(this.fileModePanel);
			this.Controls.Add(this.fileModeRadio);
			this.Controls.Add(this.folderModePanel);
			this.Controls.Add(this.sourcesLabel);
			this.Controls.Add(this.folderModeRadio);
			this.MaximizeBox = false;
			this.Name = "BulkAdding";
			this.Resizable = false;
			this.Text = "Bulk Tests Adding";
			this.Load += new System.EventHandler(this.BulkAdding_Load);
			this.folderModePanel.ResumeLayout(false);
			this.folderModePanel.PerformLayout();
			this.fileModePanel.ResumeLayout(false);
			this.fileModePanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroRadioButton folderModeRadio;
		private MetroFramework.Controls.MetroLabel sourcesLabel;
		private MetroFramework.Controls.MetroLabel folderModeDesc;
		private MetroFramework.Controls.MetroLabel inputDirLabel;
		private MetroFramework.Controls.MetroTextBox inputDirTextBox;
		private MetroFramework.Controls.MetroPanel folderModePanel;
		private MetroFramework.Controls.MetroLabel outputDirLabel;
		private MetroFramework.Controls.MetroTextBox outputDirTextBox;
		private MetroFramework.Controls.MetroCheckBox folderModeAutoGenCheckBox;
		private MetroFramework.Controls.MetroRadioButton fileModeRadio;
		private MetroFramework.Controls.MetroPanel fileModePanel;
		private MetroFramework.Controls.MetroLabel filePathLabel;
		private MetroFramework.Controls.MetroTextBox filePathTextBox;
		private MetroFramework.Controls.MetroLabel fileModeDesc;
		private MetroFramework.Controls.MetroButton addTestsButton;
		private MetroFramework.Controls.MetroButton outputDirBrowse;
		private MetroFramework.Controls.MetroButton inputDirBrowse;
		private MetroFramework.Controls.MetroButton filePathBrowse;
		private System.Windows.Forms.OpenFileDialog browseFileDialog;
		private System.Windows.Forms.FolderBrowserDialog browseFolderDialog;
		private MetroFramework.Controls.MetroLabel addLabel;
		private MetroFramework.Controls.MetroProgressSpinner addSpinner;
	}
}
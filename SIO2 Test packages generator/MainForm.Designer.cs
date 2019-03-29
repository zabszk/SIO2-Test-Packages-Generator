namespace SIO2_Test_packages_generator
{
	partial class MainForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			this.titleLabel = new MetroFramework.Controls.MetroLabel();
			this.titleTextBox = new MetroFramework.Controls.MetroTextBox();
			this.codeTextBox = new MetroFramework.Controls.MetroTextBox();
			this.codeLabel = new MetroFramework.Controls.MetroLabel();
			this.tabControl = new MetroFramework.Controls.MetroTabControl();
			this.configurationTab = new MetroFramework.Controls.MetroTabPage();
			this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
			this.launchCommandTextBox = new MetroFramework.Controls.MetroTextBox();
			this.binaryCustom = new MetroFramework.Controls.MetroRadioButton();
			this.binBrowse = new MetroFramework.Controls.MetroButton();
			this.binTextBox = new MetroFramework.Controls.MetroTextBox();
			this.binarySpecified = new MetroFramework.Controls.MetroRadioButton();
			this.binaryManual = new MetroFramework.Controls.MetroRadioButton();
			this.generatorBrowse = new MetroFramework.Controls.MetroButton();
			this.checkerBrowse = new MetroFramework.Controls.MetroButton();
			this.srcBrowse = new MetroFramework.Controls.MetroButton();
			this.docsBrowse = new MetroFramework.Controls.MetroButton();
			this.generatorTextBox = new MetroFramework.Controls.MetroTextBox();
			this.checkerTextBox = new MetroFramework.Controls.MetroTextBox();
			this.srcTextBox = new MetroFramework.Controls.MetroTextBox();
			this.docsTextBox = new MetroFramework.Controls.MetroTextBox();
			this.generatorCheckBox = new MetroFramework.Controls.MetroCheckBox();
			this.checkerCheckBox = new MetroFramework.Controls.MetroCheckBox();
			this.srcLabel = new MetroFramework.Controls.MetroLabel();
			this.docsLabel = new MetroFramework.Controls.MetroLabel();
			this.testsTab = new MetroFramework.Controls.MetroTabPage();
			this.addTestButton = new MetroFramework.Controls.MetroButton();
			this.testsGrid = new MetroFramework.Controls.MetroGrid();
			this.buildingTab = new MetroFramework.Controls.MetroTabPage();
			this.browseFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroLink1 = new MetroFramework.Controls.MetroLink();
			this.tabControl.SuspendLayout();
			this.configurationTab.SuspendLayout();
			this.metroPanel1.SuspendLayout();
			this.testsTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.testsGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Location = new System.Drawing.Point(23, 111);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(36, 19);
			this.titleLabel.TabIndex = 0;
			this.titleLabel.Text = "Title:";
			// 
			// titleTextBox
			// 
			// 
			// 
			// 
			this.titleTextBox.CustomButton.Image = null;
			this.titleTextBox.CustomButton.Location = new System.Drawing.Point(233, 1);
			this.titleTextBox.CustomButton.Name = "";
			this.titleTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.titleTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.titleTextBox.CustomButton.TabIndex = 1;
			this.titleTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.titleTextBox.CustomButton.UseSelectable = true;
			this.titleTextBox.CustomButton.Visible = false;
			this.titleTextBox.Lines = new string[0];
			this.titleTextBox.Location = new System.Drawing.Point(65, 107);
			this.titleTextBox.MaxLength = 512;
			this.titleTextBox.Name = "titleTextBox";
			this.titleTextBox.PasswordChar = '\0';
			this.titleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.titleTextBox.SelectedText = "";
			this.titleTextBox.SelectionLength = 0;
			this.titleTextBox.SelectionStart = 0;
			this.titleTextBox.ShortcutsEnabled = true;
			this.titleTextBox.Size = new System.Drawing.Size(255, 23);
			this.titleTextBox.TabIndex = 1;
			this.titleTextBox.UseSelectable = true;
			this.titleTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.titleTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// codeTextBox
			// 
			// 
			// 
			// 
			this.codeTextBox.CustomButton.Image = null;
			this.codeTextBox.CustomButton.Location = new System.Drawing.Point(36, 1);
			this.codeTextBox.CustomButton.Name = "";
			this.codeTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.codeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.codeTextBox.CustomButton.TabIndex = 1;
			this.codeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.codeTextBox.CustomButton.UseSelectable = true;
			this.codeTextBox.CustomButton.Visible = false;
			this.codeTextBox.Lines = new string[0];
			this.codeTextBox.Location = new System.Drawing.Point(65, 78);
			this.codeTextBox.MaxLength = 3;
			this.codeTextBox.Name = "codeTextBox";
			this.codeTextBox.PasswordChar = '\0';
			this.codeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.codeTextBox.SelectedText = "";
			this.codeTextBox.SelectionLength = 0;
			this.codeTextBox.SelectionStart = 0;
			this.codeTextBox.ShortcutsEnabled = true;
			this.codeTextBox.Size = new System.Drawing.Size(58, 23);
			this.codeTextBox.TabIndex = 0;
			this.codeTextBox.UseSelectable = true;
			this.codeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.codeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// codeLabel
			// 
			this.codeLabel.AutoSize = true;
			this.codeLabel.Location = new System.Drawing.Point(15, 82);
			this.codeLabel.Name = "codeLabel";
			this.codeLabel.Size = new System.Drawing.Size(44, 19);
			this.codeLabel.TabIndex = 2;
			this.codeLabel.Text = "Code:";
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.configurationTab);
			this.tabControl.Controls.Add(this.testsTab);
			this.tabControl.Controls.Add(this.buildingTab);
			this.tabControl.Location = new System.Drawing.Point(23, 156);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 1;
			this.tabControl.Size = new System.Drawing.Size(1070, 392);
			this.tabControl.TabIndex = 4;
			this.tabControl.UseSelectable = true;
			// 
			// configurationTab
			// 
			this.configurationTab.Controls.Add(this.metroPanel1);
			this.configurationTab.Controls.Add(this.generatorBrowse);
			this.configurationTab.Controls.Add(this.checkerBrowse);
			this.configurationTab.Controls.Add(this.srcBrowse);
			this.configurationTab.Controls.Add(this.docsBrowse);
			this.configurationTab.Controls.Add(this.generatorTextBox);
			this.configurationTab.Controls.Add(this.checkerTextBox);
			this.configurationTab.Controls.Add(this.srcTextBox);
			this.configurationTab.Controls.Add(this.docsTextBox);
			this.configurationTab.Controls.Add(this.generatorCheckBox);
			this.configurationTab.Controls.Add(this.checkerCheckBox);
			this.configurationTab.Controls.Add(this.srcLabel);
			this.configurationTab.Controls.Add(this.docsLabel);
			this.configurationTab.HorizontalScrollbarBarColor = true;
			this.configurationTab.HorizontalScrollbarHighlightOnWheel = false;
			this.configurationTab.HorizontalScrollbarSize = 10;
			this.configurationTab.Location = new System.Drawing.Point(4, 38);
			this.configurationTab.Name = "configurationTab";
			this.configurationTab.Size = new System.Drawing.Size(1062, 350);
			this.configurationTab.TabIndex = 0;
			this.configurationTab.Text = "Configuration";
			this.configurationTab.VerticalScrollbarBarColor = true;
			this.configurationTab.VerticalScrollbarHighlightOnWheel = false;
			this.configurationTab.VerticalScrollbarSize = 10;
			// 
			// metroPanel1
			// 
			this.metroPanel1.Controls.Add(this.launchCommandTextBox);
			this.metroPanel1.Controls.Add(this.binaryCustom);
			this.metroPanel1.Controls.Add(this.binBrowse);
			this.metroPanel1.Controls.Add(this.binTextBox);
			this.metroPanel1.Controls.Add(this.binarySpecified);
			this.metroPanel1.Controls.Add(this.binaryManual);
			this.metroPanel1.HorizontalScrollbarBarColor = true;
			this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel1.HorizontalScrollbarSize = 10;
			this.metroPanel1.Location = new System.Drawing.Point(12, 150);
			this.metroPanel1.Name = "metroPanel1";
			this.metroPanel1.Size = new System.Drawing.Size(652, 107);
			this.metroPanel1.TabIndex = 14;
			this.metroPanel1.VerticalScrollbarBarColor = true;
			this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel1.VerticalScrollbarSize = 10;
			// 
			// launchCommandTextBox
			// 
			// 
			// 
			// 
			this.launchCommandTextBox.CustomButton.Image = null;
			this.launchCommandTextBox.CustomButton.Location = new System.Drawing.Point(478, 1);
			this.launchCommandTextBox.CustomButton.Name = "";
			this.launchCommandTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.launchCommandTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.launchCommandTextBox.CustomButton.TabIndex = 1;
			this.launchCommandTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.launchCommandTextBox.CustomButton.UseSelectable = true;
			this.launchCommandTextBox.CustomButton.Visible = false;
			this.launchCommandTextBox.Enabled = false;
			this.launchCommandTextBox.Lines = new string[0];
			this.launchCommandTextBox.Location = new System.Drawing.Point(138, 69);
			this.launchCommandTextBox.MaxLength = 32767;
			this.launchCommandTextBox.Name = "launchCommandTextBox";
			this.launchCommandTextBox.PasswordChar = '\0';
			this.launchCommandTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.launchCommandTextBox.SelectedText = "";
			this.launchCommandTextBox.SelectionLength = 0;
			this.launchCommandTextBox.SelectionStart = 0;
			this.launchCommandTextBox.ShortcutsEnabled = true;
			this.launchCommandTextBox.Size = new System.Drawing.Size(500, 23);
			this.launchCommandTextBox.TabIndex = 17;
			this.launchCommandTextBox.UseSelectable = true;
			this.launchCommandTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.launchCommandTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// binaryCustom
			// 
			this.binaryCustom.AutoSize = true;
			this.binaryCustom.Location = new System.Drawing.Point(10, 48);
			this.binaryCustom.Name = "binaryCustom";
			this.binaryCustom.Size = new System.Drawing.Size(251, 15);
			this.binaryCustom.TabIndex = 16;
			this.binaryCustom.Text = "Custom launch command (eg. for python):";
			this.binaryCustom.UseSelectable = true;
			this.binaryCustom.CheckedChanged += new System.EventHandler(this.RefreshBinaryLocks);
			// 
			// binBrowse
			// 
			this.binBrowse.Enabled = false;
			this.binBrowse.Location = new System.Drawing.Point(563, 19);
			this.binBrowse.Name = "binBrowse";
			this.binBrowse.Size = new System.Drawing.Size(75, 23);
			this.binBrowse.TabIndex = 15;
			this.binBrowse.Text = "Browse";
			this.binBrowse.UseSelectable = true;
			this.binBrowse.Click += new System.EventHandler(this.ConfigBrowse);
			// 
			// binTextBox
			// 
			// 
			// 
			// 
			this.binTextBox.CustomButton.Image = null;
			this.binTextBox.CustomButton.Location = new System.Drawing.Point(397, 1);
			this.binTextBox.CustomButton.Name = "";
			this.binTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.binTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.binTextBox.CustomButton.TabIndex = 1;
			this.binTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.binTextBox.CustomButton.UseSelectable = true;
			this.binTextBox.CustomButton.Visible = false;
			this.binTextBox.Enabled = false;
			this.binTextBox.Lines = new string[0];
			this.binTextBox.Location = new System.Drawing.Point(138, 19);
			this.binTextBox.MaxLength = 32767;
			this.binTextBox.Name = "binTextBox";
			this.binTextBox.PasswordChar = '\0';
			this.binTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.binTextBox.SelectedText = "";
			this.binTextBox.SelectionLength = 0;
			this.binTextBox.SelectionStart = 0;
			this.binTextBox.ShortcutsEnabled = true;
			this.binTextBox.Size = new System.Drawing.Size(419, 23);
			this.binTextBox.TabIndex = 14;
			this.binTextBox.UseSelectable = true;
			this.binTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.binTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// binarySpecified
			// 
			this.binarySpecified.AutoSize = true;
			this.binarySpecified.Location = new System.Drawing.Point(10, 27);
			this.binarySpecified.Name = "binarySpecified";
			this.binarySpecified.Size = new System.Drawing.Size(78, 15);
			this.binarySpecified.TabIndex = 3;
			this.binarySpecified.Text = "Binary file:";
			this.binarySpecified.UseSelectable = true;
			this.binarySpecified.CheckedChanged += new System.EventHandler(this.RefreshBinaryLocks);
			// 
			// binaryManual
			// 
			this.binaryManual.AutoSize = true;
			this.binaryManual.Checked = true;
			this.binaryManual.Location = new System.Drawing.Point(10, 3);
			this.binaryManual.Name = "binaryManual";
			this.binaryManual.Size = new System.Drawing.Size(441, 15);
			this.binaryManual.TabIndex = 2;
			this.binaryManual.TabStop = true;
			this.binaryManual.Text = "Binary file not specified (test outputs and limits needs to be provided manually)" +
    "";
			this.binaryManual.UseSelectable = true;
			this.binaryManual.CheckedChanged += new System.EventHandler(this.RefreshBinaryLocks);
			// 
			// generatorBrowse
			// 
			this.generatorBrowse.Enabled = false;
			this.generatorBrowse.Location = new System.Drawing.Point(575, 108);
			this.generatorBrowse.Name = "generatorBrowse";
			this.generatorBrowse.Size = new System.Drawing.Size(75, 23);
			this.generatorBrowse.TabIndex = 13;
			this.generatorBrowse.Text = "Browse";
			this.generatorBrowse.UseSelectable = true;
			this.generatorBrowse.Click += new System.EventHandler(this.ConfigBrowse);
			// 
			// checkerBrowse
			// 
			this.checkerBrowse.Enabled = false;
			this.checkerBrowse.Location = new System.Drawing.Point(575, 79);
			this.checkerBrowse.Name = "checkerBrowse";
			this.checkerBrowse.Size = new System.Drawing.Size(75, 23);
			this.checkerBrowse.TabIndex = 12;
			this.checkerBrowse.Text = "Browse";
			this.checkerBrowse.UseSelectable = true;
			this.checkerBrowse.Click += new System.EventHandler(this.ConfigBrowse);
			// 
			// srcBrowse
			// 
			this.srcBrowse.Location = new System.Drawing.Point(575, 50);
			this.srcBrowse.Name = "srcBrowse";
			this.srcBrowse.Size = new System.Drawing.Size(75, 23);
			this.srcBrowse.TabIndex = 11;
			this.srcBrowse.Text = "Browse";
			this.srcBrowse.UseSelectable = true;
			this.srcBrowse.Click += new System.EventHandler(this.ConfigBrowse);
			// 
			// docsBrowse
			// 
			this.docsBrowse.Location = new System.Drawing.Point(575, 21);
			this.docsBrowse.Name = "docsBrowse";
			this.docsBrowse.Size = new System.Drawing.Size(75, 23);
			this.docsBrowse.TabIndex = 10;
			this.docsBrowse.Text = "Browse";
			this.docsBrowse.UseSelectable = true;
			this.docsBrowse.Click += new System.EventHandler(this.ConfigBrowse);
			// 
			// generatorTextBox
			// 
			// 
			// 
			// 
			this.generatorTextBox.CustomButton.Image = null;
			this.generatorTextBox.CustomButton.Location = new System.Drawing.Point(397, 1);
			this.generatorTextBox.CustomButton.Name = "";
			this.generatorTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.generatorTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.generatorTextBox.CustomButton.TabIndex = 1;
			this.generatorTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.generatorTextBox.CustomButton.UseSelectable = true;
			this.generatorTextBox.CustomButton.Visible = false;
			this.generatorTextBox.Enabled = false;
			this.generatorTextBox.Lines = new string[0];
			this.generatorTextBox.Location = new System.Drawing.Point(150, 108);
			this.generatorTextBox.MaxLength = 32767;
			this.generatorTextBox.Name = "generatorTextBox";
			this.generatorTextBox.PasswordChar = '\0';
			this.generatorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.generatorTextBox.SelectedText = "";
			this.generatorTextBox.SelectionLength = 0;
			this.generatorTextBox.SelectionStart = 0;
			this.generatorTextBox.ShortcutsEnabled = true;
			this.generatorTextBox.Size = new System.Drawing.Size(419, 23);
			this.generatorTextBox.TabIndex = 5;
			this.generatorTextBox.UseSelectable = true;
			this.generatorTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.generatorTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// checkerTextBox
			// 
			// 
			// 
			// 
			this.checkerTextBox.CustomButton.Image = null;
			this.checkerTextBox.CustomButton.Location = new System.Drawing.Point(397, 1);
			this.checkerTextBox.CustomButton.Name = "";
			this.checkerTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.checkerTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.checkerTextBox.CustomButton.TabIndex = 1;
			this.checkerTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.checkerTextBox.CustomButton.UseSelectable = true;
			this.checkerTextBox.CustomButton.Visible = false;
			this.checkerTextBox.Enabled = false;
			this.checkerTextBox.Lines = new string[0];
			this.checkerTextBox.Location = new System.Drawing.Point(150, 79);
			this.checkerTextBox.MaxLength = 32767;
			this.checkerTextBox.Name = "checkerTextBox";
			this.checkerTextBox.PasswordChar = '\0';
			this.checkerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.checkerTextBox.SelectedText = "";
			this.checkerTextBox.SelectionLength = 0;
			this.checkerTextBox.SelectionStart = 0;
			this.checkerTextBox.ShortcutsEnabled = true;
			this.checkerTextBox.Size = new System.Drawing.Size(419, 23);
			this.checkerTextBox.TabIndex = 4;
			this.checkerTextBox.UseSelectable = true;
			this.checkerTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.checkerTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// srcTextBox
			// 
			// 
			// 
			// 
			this.srcTextBox.CustomButton.Image = null;
			this.srcTextBox.CustomButton.Location = new System.Drawing.Point(397, 1);
			this.srcTextBox.CustomButton.Name = "";
			this.srcTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.srcTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.srcTextBox.CustomButton.TabIndex = 1;
			this.srcTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.srcTextBox.CustomButton.UseSelectable = true;
			this.srcTextBox.CustomButton.Visible = false;
			this.srcTextBox.Lines = new string[0];
			this.srcTextBox.Location = new System.Drawing.Point(150, 50);
			this.srcTextBox.MaxLength = 32767;
			this.srcTextBox.Name = "srcTextBox";
			this.srcTextBox.PasswordChar = '\0';
			this.srcTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.srcTextBox.SelectedText = "";
			this.srcTextBox.SelectionLength = 0;
			this.srcTextBox.SelectionStart = 0;
			this.srcTextBox.ShortcutsEnabled = true;
			this.srcTextBox.Size = new System.Drawing.Size(419, 23);
			this.srcTextBox.TabIndex = 3;
			this.srcTextBox.UseSelectable = true;
			this.srcTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.srcTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// docsTextBox
			// 
			// 
			// 
			// 
			this.docsTextBox.CustomButton.Image = null;
			this.docsTextBox.CustomButton.Location = new System.Drawing.Point(397, 1);
			this.docsTextBox.CustomButton.Name = "";
			this.docsTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.docsTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.docsTextBox.CustomButton.TabIndex = 1;
			this.docsTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.docsTextBox.CustomButton.UseSelectable = true;
			this.docsTextBox.CustomButton.Visible = false;
			this.docsTextBox.Lines = new string[0];
			this.docsTextBox.Location = new System.Drawing.Point(150, 21);
			this.docsTextBox.MaxLength = 32767;
			this.docsTextBox.Name = "docsTextBox";
			this.docsTextBox.PasswordChar = '\0';
			this.docsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.docsTextBox.SelectedText = "";
			this.docsTextBox.SelectionLength = 0;
			this.docsTextBox.SelectionStart = 0;
			this.docsTextBox.ShortcutsEnabled = true;
			this.docsTextBox.Size = new System.Drawing.Size(419, 23);
			this.docsTextBox.TabIndex = 2;
			this.docsTextBox.UseSelectable = true;
			this.docsTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.docsTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// generatorCheckBox
			// 
			this.generatorCheckBox.AutoSize = true;
			this.generatorCheckBox.Location = new System.Drawing.Point(47, 116);
			this.generatorCheckBox.Name = "generatorCheckBox";
			this.generatorCheckBox.Size = new System.Drawing.Size(97, 15);
			this.generatorCheckBox.TabIndex = 5;
			this.generatorCheckBox.Text = "Generator file:";
			this.generatorCheckBox.UseSelectable = true;
			this.generatorCheckBox.CheckedChanged += new System.EventHandler(this.generatorCheckBox_CheckedChanged);
			// 
			// checkerCheckBox
			// 
			this.checkerCheckBox.AutoSize = true;
			this.checkerCheckBox.Location = new System.Drawing.Point(47, 87);
			this.checkerCheckBox.Name = "checkerCheckBox";
			this.checkerCheckBox.Size = new System.Drawing.Size(88, 15);
			this.checkerCheckBox.TabIndex = 4;
			this.checkerCheckBox.Text = "Checker file:";
			this.checkerCheckBox.UseSelectable = true;
			this.checkerCheckBox.CheckedChanged += new System.EventHandler(this.checkerCheckBox_CheckedChanged);
			// 
			// srcLabel
			// 
			this.srcLabel.AutoSize = true;
			this.srcLabel.Location = new System.Drawing.Point(38, 54);
			this.srcLabel.Name = "srcLabel";
			this.srcLabel.Size = new System.Drawing.Size(106, 19);
			this.srcLabel.TabIndex = 3;
			this.srcLabel.Text = "Source code file:";
			// 
			// docsLabel
			// 
			this.docsLabel.AutoSize = true;
			this.docsLabel.Location = new System.Drawing.Point(22, 25);
			this.docsLabel.Name = "docsLabel";
			this.docsLabel.Size = new System.Drawing.Size(122, 19);
			this.docsLabel.TabIndex = 2;
			this.docsLabel.Text = "Documentation file:";
			// 
			// testsTab
			// 
			this.testsTab.Controls.Add(this.addTestButton);
			this.testsTab.Controls.Add(this.testsGrid);
			this.testsTab.HorizontalScrollbarBarColor = true;
			this.testsTab.HorizontalScrollbarHighlightOnWheel = false;
			this.testsTab.HorizontalScrollbarSize = 10;
			this.testsTab.Location = new System.Drawing.Point(4, 38);
			this.testsTab.Name = "testsTab";
			this.testsTab.Size = new System.Drawing.Size(1062, 350);
			this.testsTab.TabIndex = 1;
			this.testsTab.Text = "Tests";
			this.testsTab.VerticalScrollbarBarColor = true;
			this.testsTab.VerticalScrollbarHighlightOnWheel = false;
			this.testsTab.VerticalScrollbarSize = 10;
			// 
			// addTestButton
			// 
			this.addTestButton.Location = new System.Drawing.Point(3, 324);
			this.addTestButton.Name = "addTestButton";
			this.addTestButton.Size = new System.Drawing.Size(75, 23);
			this.addTestButton.TabIndex = 3;
			this.addTestButton.Text = "Add test";
			this.addTestButton.UseSelectable = true;
			this.addTestButton.Click += new System.EventHandler(this.addTestButton_Click);
			// 
			// testsGrid
			// 
			this.testsGrid.AllowUserToResizeRows = false;
			this.testsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.testsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.testsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.testsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.testsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.testsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.testsGrid.DefaultCellStyle = dataGridViewCellStyle11;
			this.testsGrid.EnableHeadersVisualStyles = false;
			this.testsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.testsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.testsGrid.Location = new System.Drawing.Point(3, 15);
			this.testsGrid.Name = "testsGrid";
			this.testsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.testsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.testsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.testsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.testsGrid.Size = new System.Drawing.Size(1059, 303);
			this.testsGrid.TabIndex = 2;
			// 
			// buildingTab
			// 
			this.buildingTab.HorizontalScrollbarBarColor = true;
			this.buildingTab.HorizontalScrollbarHighlightOnWheel = false;
			this.buildingTab.HorizontalScrollbarSize = 10;
			this.buildingTab.Location = new System.Drawing.Point(4, 38);
			this.buildingTab.Name = "buildingTab";
			this.buildingTab.Size = new System.Drawing.Size(1062, 350);
			this.buildingTab.TabIndex = 2;
			this.buildingTab.Text = "Building";
			this.buildingTab.VerticalScrollbarBarColor = true;
			this.buildingTab.VerticalScrollbarHighlightOnWheel = false;
			this.buildingTab.VerticalScrollbarSize = 10;
			// 
			// browseFileDialog
			// 
			this.browseFileDialog.FileName = "SIO2 Test Packages Generator Browse";
			this.browseFileDialog.RestoreDirectory = true;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(933, 557);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(160, 19);
			this.metroLabel1.TabIndex = 5;
			this.metroLabel1.Text = "Created by Łukasz Jurczyk";
			// 
			// metroLink1
			// 
			this.metroLink1.Location = new System.Drawing.Point(15, 557);
			this.metroLink1.Name = "metroLink1";
			this.metroLink1.Size = new System.Drawing.Size(97, 23);
			this.metroLink1.TabIndex = 6;
			this.metroLink1.Text = "View License";
			this.metroLink1.UseSelectable = true;
			this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1116, 596);
			this.Controls.Add(this.metroLink1);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.codeTextBox);
			this.Controls.Add(this.codeLabel);
			this.Controls.Add(this.titleTextBox);
			this.Controls.Add(this.titleLabel);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Resizable = false;
			this.Text = "SIO2 Test Packages Generator";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tabControl.ResumeLayout(false);
			this.configurationTab.ResumeLayout(false);
			this.configurationTab.PerformLayout();
			this.metroPanel1.ResumeLayout(false);
			this.metroPanel1.PerformLayout();
			this.testsTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.testsGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel titleLabel;
		private MetroFramework.Controls.MetroTextBox titleTextBox;
		private MetroFramework.Controls.MetroTextBox codeTextBox;
		private MetroFramework.Controls.MetroLabel codeLabel;
		private MetroFramework.Controls.MetroTabControl tabControl;
		private MetroFramework.Controls.MetroTabPage configurationTab;
		private MetroFramework.Controls.MetroTabPage testsTab;
		private MetroFramework.Controls.MetroTabPage buildingTab;
		private MetroFramework.Controls.MetroLabel srcLabel;
		private MetroFramework.Controls.MetroLabel docsLabel;
		private MetroFramework.Controls.MetroCheckBox generatorCheckBox;
		private MetroFramework.Controls.MetroCheckBox checkerCheckBox;
		private MetroFramework.Controls.MetroTextBox docsTextBox;
		private MetroFramework.Controls.MetroTextBox srcTextBox;
		private MetroFramework.Controls.MetroTextBox generatorTextBox;
		private MetroFramework.Controls.MetroTextBox checkerTextBox;
		private MetroFramework.Controls.MetroButton docsBrowse;
		private MetroFramework.Controls.MetroButton srcBrowse;
		private MetroFramework.Controls.MetroButton generatorBrowse;
		private MetroFramework.Controls.MetroButton checkerBrowse;
		private System.Windows.Forms.OpenFileDialog browseFileDialog;
		private MetroFramework.Controls.MetroPanel metroPanel1;
		private MetroFramework.Controls.MetroRadioButton binaryManual;
		private MetroFramework.Controls.MetroTextBox launchCommandTextBox;
		private MetroFramework.Controls.MetroRadioButton binaryCustom;
		private MetroFramework.Controls.MetroButton binBrowse;
		private MetroFramework.Controls.MetroTextBox binTextBox;
		private MetroFramework.Controls.MetroRadioButton binarySpecified;
		private MetroFramework.Controls.MetroButton addTestButton;
		private MetroFramework.Controls.MetroGrid testsGrid;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLink metroLink1;
	}
}


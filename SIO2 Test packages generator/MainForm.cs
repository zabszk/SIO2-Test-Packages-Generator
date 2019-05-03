using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using SIO2_Test_packages_generator.Data;

namespace SIO2_Test_packages_generator
{
	public partial class MainForm : MetroFramework.Forms.MetroForm
	{
		internal static Package Package;
		internal static MainForm Instance;

		private static bool _passed;

		public static bool TestsPassed
		{
			get => _passed;
			set
			{
				_passed = value;
				Instance.buildButton.Enabled = value;
				Instance.ignoreButton.Enabled = false;
				if (!value) Instance.preparingStatusLabel.Visible = false;
			}
		}

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			CheckForIllegalCrossThreadCalls = false;

			Instance = this;
			tabControl.SelectedIndex = 0;

			Package = new Package();
			testsGrid.DataSource = Package.TestsSource;
		}

		private void ConfigBrowse(object sender, EventArgs e)
		{
			if (browseFileDialog.ShowDialog() != DialogResult.OK) return;

			switch (((Button) sender).Name)
			{
				case "docsBrowse":
					docsTextBox.Text = browseFileDialog.FileName;
					break;

				case "srcBrowse":
					srcTextBox.Text = browseFileDialog.FileName;
					break;

				case "checkerBrowse":
					checkerTextBox.Text = browseFileDialog.FileName;
					break;

				case "generatorBrowse":
					generatorTextBox.Text = browseFileDialog.FileName;
					break;

				case "binBrowse":
					binTextBox.Text = browseFileDialog.FileName;
					break;
			}
		}

		private void UpdateData(object sender, EventArgs e)
		{
			var tb = (MetroTextBox) sender;

			switch (((MetroTextBox) sender).Name)
			{
				case "codeTextBox":
					Package.Code = tb.Text;
					TestsPassed = false;
					break;

				case "titleTextBox":
					Package.Name = tb.Text;
					break;

				case "docsTextBox":
					Package.Docs = tb.Text;
					break;

				case "srcTextBox":
					Package.SourceCodeFile = tb.Text;
					break;

				case "checkerTextBox":
					Package.CheckerFile = tb.Enabled ? tb.Text : string.Empty;
					break;

				case "generatorTextBox":
					Package.GeneratorFile = tb.Enabled ? tb.Text : string.Empty;
					break;

				case "binTextBox":
					Package.BinaryFile = tb.Enabled ? tb.Text : string.Empty;
					break;

				case "launchCommandTextBox":
					Package.ExecCommand = tb.Enabled ? tb.Text : string.Empty;
					break;
			}
		}

		private void RefreshBinaryLocks(object sender, EventArgs e)
		{
			if (binaryManual.Checked)
				binTextBox.Enabled = binBrowse.Enabled = launchCommandTextBox.Enabled = false;
			else if (binarySpecified.Checked)
			{
				binTextBox.Enabled = binBrowse.Enabled = true;
				launchCommandTextBox.Enabled = false;
			}
			else
			{
				binTextBox.Enabled = binBrowse.Enabled = false;
				launchCommandTextBox.Enabled = true;
			}
		}

		private void checkerCheckBox_CheckedChanged(object sender, EventArgs e) =>
			checkerTextBox.Enabled = checkerBrowse.Enabled = checkerCheckBox.Checked;

		private void generatorCheckBox_CheckedChanged(object sender, EventArgs e) =>
			generatorTextBox.Enabled = generatorBrowse.Enabled = generatorCheckBox.Checked;

		private void metroLink1_Click(object sender, EventArgs e) => new LicenseForm().ShowDialog();

		internal void RefreshGridView()
		{
            MainForm.Instance.testsGrid.Update();
            MainForm.Instance.testsGrid.Refresh();
        }

		private void addTestButton_Click(object sender, EventArgs e)
		{
			var test = new Test();
			Package.Tests.Add(test);
			test.OpenEditor();
		}

		private void bulkAddingButton_Click(object sender, EventArgs e) => new BulkAdding().Show();

		private void testsGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex != 0 && e.ColumnIndex != 2) return;
			Package.Tests.ElementAt(e.RowIndex).OpenEditor();
		}

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e) => TestsPassed = false;

		private void prepareButton_Click(object sender, EventArgs e)
		{
			new Thread(PrepareForBuild)
			{
				Name = "Package preparing",
				Priority = ThreadPriority.AboveNormal,
				IsBackground = true
			}.Start();
		}

		private void PrepareForBuild()
		{
			tabControl.Enabled = false;

			preparingStatusLabel.ForeColor = SystemColors.ControlText;
			preparingStatusLabel.Text = "Running tests...";
			preparingStatusLabel.Visible = true;

			var errors = Package.TestPackage().ToArray();

			if (errors.Length == 0)
			{
				TestsPassed = true;
				preparingStatusLabel.ForeColor = Color.LimeGreen;
				preparingStatusLabel.Text = "Package ready to build";
			}
			else
			{
				TestsPassed = false;

				var critical = errors.Any(error => error.StartsWith("**CRITICAL** "));

				preparingStatusLabel.ForeColor = Color.Crimson;
				preparingStatusLabel.Text =
					critical ? "Package cannot be build - critical errors found" : "Package cannot be build - errors found";
				preparingStatusLabel.Visible = true;

				ignoreButton.Enabled = !critical;

				Instance.Invoke((MethodInvoker) delegate
				{
					new ErrorsList(errors).Show();
				});
			}

			tabControl.Enabled = true;
		}

		private void ignoreButton_Click(object sender, EventArgs e)
		{
			ignoreButton.Enabled = false;
			buildButton.Enabled = true;
		}

		private void buildButton_Click(object sender, EventArgs e)
		{
			tabControl.Enabled = false;

			try
			{
				if (!Directory.Exists("packages"))
					Directory.CreateDirectory("packages");

				new Thread(Build)
				{
					Name = "Package building",
					Priority = ThreadPriority.AboveNormal,
					IsBackground = false
				}.Start();
			}
			catch (Exception ex)
			{
				MetroMessageBox.Show(this,"Exception: " + ex.Message, "Error during package building",
					MessageBoxButtons.OK, MessageBoxIcon.Error);

				preparingStatusLabel.ForeColor = Color.Crimson;
				preparingStatusLabel.Text = "Building package failed";
				preparingStatusLabel.Visible = true;

				tabControl.Enabled = true;
			}
		}

		private void Build()
		{
			var errors = new List<string>();

			preparingStatusLabel.ForeColor = SystemColors.ControlText;
			preparingStatusLabel.Text = "Preparing working directory...";
			preparingStatusLabel.Visible = true;

			try
			{
				var workingDir = "packages/" + Package.Code + "/" + Package.Code;

				if (Directory.Exists(workingDir) || File.Exists("packages/" + Package.Code + ".zip"))
				{
					if (MetroMessageBox.Show(this,
						    "Package with this code already exists in the \"packages\" folder.\n\nDo you want to overwrite the existing text package?", 
						    "Overwrite confirmation",
							MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
					{
						if (Directory.Exists(workingDir))
							Directory.Delete(workingDir, true);

						if (File.Exists("packages/" + Package.Code + ".zip"))
							File.Delete("packages/" + Package.Code + ".zip");
					}
					else return;
				}

				Directory.CreateDirectory(workingDir);
				Directory.CreateDirectory(workingDir + "/doc");
				Directory.CreateDirectory(workingDir + "/in");
				Directory.CreateDirectory(workingDir + "/out");
				Directory.CreateDirectory(workingDir + "/prog");

				preparingStatusLabel.Text = "Copying files...";

				if (!string.IsNullOrWhiteSpace(Package.Docs) && File.Exists(Package.Docs))
					File.Copy(Package.Docs, $"{workingDir}/doc/{Package.Code}zad.{FileExtension(Package.Docs)}", true);
				else errors.Add("Cannot copy docs file!");

				if (!string.IsNullOrWhiteSpace(Package.SourceCodeFile) && File.Exists(Package.SourceCodeFile))
					File.Copy(Package.SourceCodeFile, $"{workingDir}/prog/{Package.Code}.{FileExtension(Package.SourceCodeFile)}", true);
				else errors.Add("Cannot copy source code file!");

				if (Instance.checkerCheckBox.Checked)
				{
					if (!string.IsNullOrWhiteSpace(Package.CheckerFile) && File.Exists(Package.CheckerFile))
						File.Copy(Package.CheckerFile,
							$"{workingDir}/prog/{Package.Code}chk.{FileExtension(Package.CheckerFile)}", true);
					else errors.Add("Cannot copy checker file!");
				}

				if (Instance.generatorCheckBox.Checked)
				{
					if (!string.IsNullOrWhiteSpace(Package.GeneratorFile) && File.Exists(Package.GeneratorFile))
						File.Copy(Package.GeneratorFile,
							$"{workingDir}/prog/{Package.Code}ingen.{FileExtension(Package.GeneratorFile)}", true);
					else errors.Add("Cannot copy generator file!");
				}

				preparingStatusLabel.Text = "Generating I/O files...";
				var time = "time_limits:";
				var memory = "memory_limits:";
				var scores = "scores:";

				var added = new HashSet<string>();
				added.Add("0");

				foreach (var test in Package.Tests)
				{
					File.WriteAllLines($"{workingDir}/in/{Package.Code}{test.TestCodeName}.in", test.Input);
					File.WriteAllLines($"{workingDir}/out/{Package.Code}{test.TestCodeName}.out", test.Output);
					time += $"{Environment.NewLine}    {test.TestCodeName}: {test.TimeLimit}";
					memory += $"{Environment.NewLine}    {test.TestCodeName}: {test.MemoryLimit}";
					
					if (added.Contains(test.SubGroupName())) continue;
					added.Add(test.SubGroupName());
					scores += $"{Environment.NewLine}    {test.SubGroupName()}: {test.Points}";
				}

				preparingStatusLabel.Text = "Generating config file...";

				
				using (var writer = new StreamWriter(workingDir + "/config.yml"))
				{
					if (!string.IsNullOrWhiteSpace(Package.Name))
						writer.WriteLine("title: " + Package.Name);

					writer.WriteLine(time);
					writer.WriteLine(memory);
					writer.WriteLine(scores);
				}

				preparingStatusLabel.Text = "Generating ZIP file...";

                var fastZip = new ICSharpCode.SharpZipLib.Zip.FastZip();
                fastZip.CreateZip($"packages/{Package.Code}.zip", $"packages/{Package.Code}", true, "");
                Directory.Delete("packages/" + Package.Code, true);

                preparingStatusLabel.ForeColor = Color.LimeGreen;
				preparingStatusLabel.Text = "Package building completed";
				tabControl.Enabled = true;
			}
			catch (Exception e)
			{
				MetroMessageBox.Show(this, "Exception: " + e.Message, "Error during package building",
					MessageBoxButtons.OK, MessageBoxIcon.Error);

				preparingStatusLabel.ForeColor = Color.Crimson;
				preparingStatusLabel.Text = "Building package failed";
				preparingStatusLabel.Visible = true;

				tabControl.Enabled = true;
			}
		}

		private string FileExtension(string path) => (new FileInfo(path)).Extension.TrimStart('.');

		private void TextBox_DragEnter(object sender, DragEventArgs e) => e.Effect =
			e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;

		private void TextBox_DragDrop(object sender, DragEventArgs e)
		{
			var tb = (MetroTextBox)sender;
			var files = (string[]) e.Data.GetData(DataFormats.FileDrop);
			if (files == null || files.Length == 0) return;
			tb.Text = files[0];
		}

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (tabControl.SelectedIndex != 1 || testsGrid.SelectedRows.Count == 0) return;

            switch (e.KeyCode)
            {
                case Keys.F2:
                    e.Handled = true;

                    var list = new List<Test>();

                    foreach (var row in testsGrid.SelectedRows)
                    {
                        var rr = Package.Tests.ElementAtOrDefault(((DataGridViewRow) row).Index);
                        if (rr != null)
                            list.Add(rr);
                    }

                    new BulkEdit(list).ShowDialog(this);
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Windows.Forms;
using SIO2_Test_packages_generator.Data;

namespace SIO2_Test_packages_generator
{
	public partial class BulkAdding : MetroFramework.Forms.MetroForm, IOutput
	{
		private string[] _output;
		private int _status, _time, _memory;
		private string _error;

		public BulkAdding()
		{
			InitializeComponent();
		}

		private bool MasterLock
		{
			set
			{
				folderModeRadio.Enabled = fileModeRadio.Enabled = addTestsButton.Enabled = !value;
				folderModePanel.Enabled = folderModeRadio.Checked && !value;
				fileModePanel.Enabled = fileModeRadio.Checked && !value && (!string.IsNullOrWhiteSpace(MainForm.Package.BinaryFile) ||
				                                                            !string.IsNullOrWhiteSpace(MainForm.Package.ExecCommand));
			}
		}

		private void BulkAdding_Load(object sender, EventArgs e)
		{
			folderModeAutoGenCheckBox.Enabled = folderModeAutoGenCheckBox.Checked = fileModeRadio.Enabled = 
				!string.IsNullOrWhiteSpace(MainForm.Package.BinaryFile) ||
				!string.IsNullOrWhiteSpace(MainForm.Package.ExecCommand);
		}

		private void ModeChanged(object sender, EventArgs e)
		{
			folderModePanel.Enabled = folderModeRadio.Checked;
			fileModePanel.Enabled = fileModeRadio.Checked;
		}

		private void filePathBrowse_Click(object sender, EventArgs e)
		{
			if (browseFileDialog.ShowDialog() != DialogResult.OK) return;
			filePathTextBox.Text = browseFileDialog.FileName;
		}

		private void FolderBrowse(object sender, EventArgs e)
		{
			if (browseFolderDialog.ShowDialog() != DialogResult.OK) return;

			switch (((Button)sender).Name)
			{
				case "inputDirBrowse":
					inputDirTextBox.Text = browseFolderDialog.SelectedPath;
					break;

				case "outputDirBrowse":
					outputDirTextBox.Text = browseFolderDialog.SelectedPath;
					break;
			}
		}

		private void folderModeAutoGenCheckBox_CheckedChanged(object sender, EventArgs e) => outputDirTextBox.Enabled =
			outputDirBrowse.Enabled = !folderModeAutoGenCheckBox.Checked;

		private void addTestsButton_Click(object sender, EventArgs e)
		{
			new Thread(Import)
			{
				Name = "Bulk tests adding",
				Priority = ThreadPriority.AboveNormal,
				IsBackground = false
			}.Start();
		}

		private void Import()
		{
			MasterLock = true;
			var tests = new List<Test>();
			var errors = new List<string>();

			if (folderModeRadio.Checked)
			{
				try
				{
					var inputFiles = Directory.GetFiles(inputDirTextBox.Text);

					var max = inputFiles.Length;
					var i = 0;
					addLabel.Text = $"Processing test {i}/{max}...";
					addLabel.Visible = true;

					foreach (var input in inputFiles)
					{
						try
						{
							i++;
							var name = Path.GetFileName(input);
							addLabel.Text = $"Processing test {i}/{max} ({name})...";

							string[] testInput, testOutput = null;
							if (!folderModeAutoGenCheckBox.Checked)
							{
								var outputPath = outputDirTextBox.Text + "/" + name;
								if (!File.Exists(outputPath))
								{
									errors.Add($"File {outputPath} does not exist.");
									continue;
								}

								try
								{
									testOutput = File.ReadAllLines(outputPath);
								}
								catch (Exception e)
								{
									errors.Add($"Error reading {outputPath} file: {e.Message}");
									continue;
								}
							}

							try
							{
								testInput = File.ReadAllLines(input);
							}
							catch (Exception e)
							{
								errors.Add($"Error reading {input} file: {e.Message}");
								continue;
							}

							var noext = name;
							if (noext.Contains("."))
							{
								var index = noext.LastIndexOf(".", StringComparison.Ordinal);
								if (index > 0)
									noext = noext.Substring(0, index);
							}

							var test = new Test()
							{
								TestName = noext,
								Input = testInput,
								Output = testOutput
							};
							tests.Add(test);

							if (!folderModeAutoGenCheckBox.Checked) continue;
							_status = 0;

							MainForm.Package.GenerateOutput(testInput, this);

							while (_status == 0)
								Thread.Sleep(5);

							if (_status == 1)
							{
								test.Output = _output;
								test.SetExecutionStats(_time, _memory);
								test.TimeLimit = test.RecommendedTimeLimit;
								test.MemoryLimit = test.RecommendedMemoryLimit;

								_output = null;
							}
							else
							{
								errors.Add($"Error during generating output of test {input}: {_error}");
								_error = null;
							}
						}
						catch (Exception e)
						{
							errors.Add($"Error during processing test {input}: {e.Message}");
						}
					}
				}
				catch (Exception e)
				{
					errors.Add($"Error during tests: {e.Message}");
				}
			}
			else
			{
				try
				{
					var lines = File.ReadAllLines(filePathTextBox.Text);
					var max = lines.Length;
					var i = -1;
					addLabel.Visible = true;

					foreach (var line in lines)
					{
						i++;
						addLabel.Text = $"Processing test {i + 1}/{max}...";
						
						try
						{
							if (string.IsNullOrWhiteSpace(line)) continue;
							if (!line.Contains(": "))
							{
								errors.Add($"Error during processing line {i}: invalid format (missing \": \").");
								continue;
							}

							var name = line.Substring(0, line.IndexOf(": ", StringComparison.Ordinal));
							var input = line.Substring(name.Length + 2).Split(new[] {"\\n"}, StringSplitOptions.None);

							var test = new Test()
							{
								TestName = name,
								Input = input
							};
							tests.Add(test);

							_status = 0;

							MainForm.Package.GenerateOutput(input, this);

							while (_status == 0)
								Thread.Sleep(5);

							if (_status == 1)
							{
								test.Output = _output;
								test.SetExecutionStats(_time, _memory);
								test.TimeLimit = test.RecommendedTimeLimit;
								test.MemoryLimit = test.RecommendedMemoryLimit;

								_output = null;
							}
							else
							{
								errors.Add($"Error during generating output of test in line {i}: {_error}");
								_error = null;
							}
						}
						catch (Exception e)
						{
							errors.Add($"Error during processing test in line {i}: {e.Message}, {e.StackTrace}");
						}
					}
				}
				catch (Exception e)
				{
					errors.Add($"Error during processing tests: {e.Message}");
				}
			}

			if (errors.Count > 0)
				MainForm.Instance.Invoke((MethodInvoker) delegate
				{
					new ErrorsList(errors.ToArray()).Show();
				});

			if (tests.Count > 0)
				MainForm.Instance.Invoke((MethodInvoker) delegate
				{
					new BulkAddingConfirmationForm(tests).Show();
				});

			addLabel.Visible = false;
			MasterLock = false;

			Close();
		}

		public void OutputGenerated(IEnumerable<string> output, int time, int memory)
		{
			_output = output.ToArray();
			_time = time;
			_memory = memory;
			_status = 1;
		}

		public void OutputGenerationFailed(string error)
		{
			_error = error;
			_status = 2;
		}
	}
}

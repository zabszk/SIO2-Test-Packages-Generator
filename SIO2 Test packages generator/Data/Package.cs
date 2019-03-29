using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace SIO2_Test_packages_generator.Data
{
	internal class Package
	{
		internal Package()
		{
			Tests = new BindingList<Test>();
			TestsSource = new BindingSource(Tests, null);
		}

		internal string Code, Name;
		internal BindingList<Test> Tests;
		internal BindingSource TestsSource;

		internal string Docs;
		internal string SourceCodeFile, CheckerFile, GeneratorFile;
		internal string BinaryFile, ExecCommand;

		#region Output Generation

		internal void GenerateOutput(IEnumerable<string> input, IOutput output)
		{
			new Thread(() =>
			{
				try
				{
					output.OutputGenerated(GetOutput(input));
				}
				catch (Exception e)
				{
					output.OutputGenerationFailed("Exception: " + e.Message);
				}
			})
			{
				Priority = ThreadPriority.Highest,
				Name = "Output generation",
				IsBackground = false
			}.Start();
		}

		internal IEnumerable<string> GetOutput(IEnumerable<string> input)
		{
			if (string.IsNullOrWhiteSpace(BinaryFile) && string.IsNullOrWhiteSpace(ExecCommand)) throw new Exception("BinaryFile and ExecCommand are both empty.");

			using (var process = new Process())
			{
				var info = new ProcessStartInfo(!string.IsNullOrWhiteSpace(BinaryFile) ? BinaryFile : ExecCommand)
				{
					UseShellExecute = false,
					RedirectStandardInput = true,
					RedirectStandardOutput = true,
					RedirectStandardError = true,
					CreateNoWindow = true
				};

				process.StartInfo = info;
				process.Start();

				var writer = process.StandardInput;
				var reader = process.StandardOutput;
				var errorReader = process.StandardError;

				foreach (var writeLine in input)
					writer.WriteLine(writeLine.Trim('\n', '\r'));

				writer.Flush();
				writer.Close();

				process.WaitForExit();
				string line;

				if (!errorReader.EndOfStream)
					while ((line = errorReader.ReadLine()) != null)
						yield return line;

				while ((line = reader.ReadLine()) != null)
					yield return line;

				errorReader.Close();
				reader.Close();
			}
		}
#endregion
	}
}

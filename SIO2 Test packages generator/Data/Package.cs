using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
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

		internal IEnumerable<string> TestPackage()
		{
			var processed = new HashSet<string>();
			ushort counter = 0;
			
			foreach (var test in Tests)
			{
				if (!test.ValidateTest()) yield return $"Test {(test.TestName.Length == 0 ? "(unnamed)" : test.TestCodeName)} failed tests.";
				else
				{
					if (test.IsInSubGroup())
					{
						if (processed.Contains(test.SubGroupName())) continue;
						processed.Add(test.SubGroupName());
						counter++;
					}
					else if (processed.Contains(test.TestCodeName))
						yield return $"Test name {test.TestCodeName} duplicate found.";
					else if (test.Type == "Normal")
						counter++;
				}
			}

			for (var i = 0; i < counter; i++)
				if (Tests.All(test => test.SubGroupName() != i.ToString()))
					yield return $"Test group {i} is missing.";
		}

		#region Output Generation

		internal void GenerateOutput(IEnumerable<string> input, IOutput output)
		{
			new Thread(() =>
			{
				try
				{
					var stopwatch = new Stopwatch();
					stopwatch.Start();
					var result = GetOutput(input).ToArray();
					stopwatch.Stop();
					int.TryParse(result.ElementAt(0), out var ram);

					output.OutputGenerated(result.Skip(1), (int)stopwatch.ElapsedMilliseconds, ram);
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

				long peak = 0;

				while (!process.HasExited)
				{
					var last = process.PrivateMemorySize64;
					if (last > peak) peak = last;
					Thread.Sleep(1);
				}

				yield return (peak / 1024).ToString();
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

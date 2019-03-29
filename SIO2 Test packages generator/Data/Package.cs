using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
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
	}
}

using System.ComponentModel;

namespace SIO2_Test_packages_generator.Data
{
	public class TestConfirmation
	{
		internal readonly Test Test;

		public TestConfirmation(Test test)
		{
			Test = test;
			Process = true;
		}

		public bool Process { get; set; }

		public string Name => Test.TestCodeName;

		[DisplayName("Time [ms]")] public int Time => Test.Time;

		[DisplayName("Memory [KiB]")] public int Memory => Test.Memory;

		public string Status => Test.Status;
	}
}

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

		public string Status => Test.Status;
	}
}

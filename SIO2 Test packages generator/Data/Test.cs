using System.Collections.Generic;
using System.ComponentModel;

namespace SIO2_Test_packages_generator.Data
{
	public class Test
	{
		public Test(bool init)
		{
			SetExecutionStats(-1, -1);
			if (!init) return;
			Input = new List<string>();
			Output = new List<string>();
		}

		public Test(int time, int memory, bool init)
		{
			SetExecutionStats(time, memory);
			if (!init) return;
			Input = new List<string>();
			Output = new List<string>();
		}

		[DisplayName("Name")]
		public string TestName { get; set; }

		public uint Points { get; set; }

		public string Type
		{
			get
			{
				if (TestName.StartsWith("0")) return "Init";

				switch (Flags)
				{
					case (ushort)TestFlags.Slow:
						return "Slow";

					case (ushort)TestFlags.Incorrect:
						return "Incorrect";

					default:
						return "Normal";
				}
			}
		}

		public int Time { get; private set; }

		public int Memory { get; private set; }

		[DisplayName("Time Limit")]
		public uint TimeLimit { get; set; }

		[DisplayName("Memory Limit")]
		public uint MemoryLimit { get; set; }

		[DisplayName("Suggested Time Limit")]
		public uint SuggestedTimeLimit => (uint) (Time > 0 ? Time * 2 + 100 : 10000);

		[DisplayName("Suggested Memory Limit")]
		public uint SuggestedMemoryLimit => (uint) (Memory > 0 ? Memory + 512 : 32768);

		public List<string> Input, Output;
		public ushort Flags;

		public void SetExecutionStats(int time, int memory)
		{
			Time = time;
			Memory = memory;
		}
	}
}

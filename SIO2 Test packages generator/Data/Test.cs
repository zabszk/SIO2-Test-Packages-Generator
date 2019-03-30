using System.ComponentModel;
using System.Windows.Forms;
using MetroFramework;

namespace SIO2_Test_packages_generator.Data
{
	public class Test
	{
		public Test()
		{
			Points = 20;
			SetExecutionStats(-1, -1);
		}

		public Test(int time, int memory)
		{
			Points = 20;
			SetExecutionStats(time, memory);
		}

		public string TestName;

		[DisplayName("Name")]
		public string TestCodeName
		{
			get
			{
				switch (Flags)
				{
					case (ushort) TestFlags.Slow:
						return $"s{TestName}";

					case (ushort) TestFlags.Incorrect:
						return $"b{TestName}";

					default:
						return TestName;
				}
			}
		}

		public uint Points;

		[DisplayName("Points")]
		public string PointsDisplay
		{
			get => Type == "Init" ? "0" : Points.ToString();
			set
			{
				if (!uint.TryParse(value, out var conv))
				{
					MetroMessageBox.Show(MainForm.Instance, "Points must be a valid unsigned integer.",
						"Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				Points = conv;
			}
		}


		public string Type
		{
			get
			{
				if (!string.IsNullOrEmpty(TestName) && TestName.StartsWith("0")) return "Init";

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

		[DisplayName("Time [ms]")]
		public int Time { get; private set; }

		[DisplayName("Memory [KiB]")]
		public int Memory { get; private set; }

		public uint TimeLimit;

		[DisplayName("Time Limit")]
		public string TimeLimitDisplay
		{
			get => TimeLimit.ToString();
			set
			{
				if (!uint.TryParse(value, out var conv))
				{
					MetroMessageBox.Show(MainForm.Instance, "Time Limit must be a valid unsigned integer.",
						"Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				TimeLimit = conv;
			}
		}
		
		public uint MemoryLimit;

		[DisplayName("Memory Limit")]
		public string MemoryLimitDisplay
		{
			get => MemoryLimit.ToString();
			set
			{
				if (!uint.TryParse(value, out var conv))
				{
					MetroMessageBox.Show(MainForm.Instance, "Memory Limit must be a valid unsigned integer.",
						"Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				MemoryLimit = conv;
			}
		}

		[DisplayName("Recommended Time Limit")]
		public uint RecommendedTimeLimit => (uint) (Time > 0 ? Time * 2 + 100 : 10000);

		[DisplayName("Recommended Memory Limit")]
		public uint RecommendedMemoryLimit => (uint) (Memory > 0 ? Memory + 512 : 32768);

		public string[] Input, Output;
		public ushort Flags;
		internal TestEditor Editor;

		public void SetExecutionStats(int time, int memory)
		{
			Time = time;
			Memory = memory;
		}

		internal void OpenEditor()
		{
			if (Editor != null) Editor.FocusMe();
			else
			{
				Editor = new TestEditor(this);
				Editor.Show();
			}
		}

		internal void EditorClosed()
		{
			Editor = null;
			MainForm.Instance.RefreshGridView();
		}

		public string Status => ValidateTest() ? "OK" : "-";

		internal bool ValidateTest()
		{
			if (TimeLimit == 0 || MemoryLimit == 0) return false;
			if (TestName.Length == 0) return false;
			if (Output == null || Output.Length == 0) return false;
			ushort parse = 0;
			if (ushort.TryParse(TestName, out parse)) return true;
			return TestName.Length != 1 && ushort.TryParse(TestName.Substring(0, TestName.Length - 1), out parse);
		}

		internal bool IsInSubGroup() => TestName.Length > 1 && ushort.TryParse(TestName, out var parse);

		internal string SubGroupName() => IsInSubGroup() ? TestCodeName.Substring(0, TestName.Length - 1) : TestCodeName;
	}
}

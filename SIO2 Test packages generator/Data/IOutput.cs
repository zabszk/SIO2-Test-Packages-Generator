using System.Collections.Generic;

namespace SIO2_Test_packages_generator.Data
{
	internal interface IOutput
	{
		void OutputGenerated(IEnumerable<string> output);

		void OutputGenerationFailed(string error);
	}
}

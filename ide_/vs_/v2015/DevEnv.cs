using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.ide_.vs_.v2015
{
	public class DevEnv
	{
		public const string containerInVs = @"Common7\IDE";

		public static string containerInProgram = System.IO.Path.Combine(V2015.pathInProgramFolder, containerInVs);

		public const string doc = "devenv.exe";

		public static string documentInVs= System.IO.Path.Combine(containerInVs,doc);



		public static string Address = System.IO.Path.Combine(
			V2015.address
			,
			documentInVs
		);
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.ide_.vs_
{
	public class V2015
	{



		public const string pathInProgramFolder = @"Microsoft Visual Studio 14.0";

		public static string address = System.IO.Path.Combine(
					nilnul.win.Programs.Container86_1.ToString()
					,
					pathInProgramFolder
		);

	}
}

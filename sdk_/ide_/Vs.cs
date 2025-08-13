using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.ide_
{
	public class Vs
	{
		/// <summary>
		/// C:\Program Files (x86)\
		/// </summary>
		public const string DIVISION_IN_PROGRAMS = @"Microsoft Visual Studio";//\2017\Community\Common7\IDE";

		public static string Address = System.IO.Path.Combine(
					nilnul.win.Programs.Container86_1.ToString()
					,
					DIVISION_IN_PROGRAMS
		);



	}
}

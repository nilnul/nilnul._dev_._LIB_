using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.ide_.vs_.v2017.community
{
	public class DevEnv
	{
		public const string DOC= "devenv.exe";
		public const string DIVISION = @"Common7\IDE" +DOC;

		



		public static string Address = System.IO.Path.Combine(
			Community.Address
			,
			DIVISION
		);
	}
}

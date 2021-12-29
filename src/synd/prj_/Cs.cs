using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.synd.prj_
{
	static public class _CsX
	{
		static public string SpearAsTxt_syndOfAddress(string synd) {
			return System.IO.Directory.EnumerateFiles(synd, "*.csproj").Single();
		}

		static public string SpearNulableAsTxt_syndOfAddress(string synd) {
			return System.IO.Directory.EnumerateFiles(synd, "*.csproj").SingleOrDefault();
		}


	}
}

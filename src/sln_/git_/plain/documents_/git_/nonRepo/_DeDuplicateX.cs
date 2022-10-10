using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln_.git_.plain.documents_.git_.nonRepo
{
	static public class _DeDuplicateX
	{
		static public void DeDuplicate(
			nilnul.fs.FolderI sln

		) {
			_DeDuplicate(sln.address.en.ToString());
		}

		private static void _DeDuplicate(string sln)
		{
			foreach (var item in System.IO.Directory.EnumerateDirectories(sln))
			{

			}
			//throw new NotImplementedException();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln_.git_.plain.documents_.git_
{
	static public class _NonRepoX
	{
		static public void Enumerate(
			nilnul.fs.FolderI3 sln

		) {
			_Enumerate(sln.address.en.ToString());
		}

		private static IEnumerable<string> _Enumerate(string sln)
		{
			foreach (var item in System.IO.Directory.EnumerateDirectories(sln))
			{
				if (nilnul.fs.folder.be_.git_.Plain.Singleton.be(
						new nilnul.fs.Folder1(
							item
						)
					)
				)
				{


				}
			}
			//throw new NotImplementedException();
		}
	}
}

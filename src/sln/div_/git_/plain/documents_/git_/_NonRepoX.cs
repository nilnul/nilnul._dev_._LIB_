using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.div_.git_.plain.documents_.git_
{
	static public class _NonRepoX
	{
		static public void Enumerate(
			nilnul.fs.FolderI3 sln

		) {
			_Enumerate(sln.address.en.ToString());
		}

		public static IEnumerable<string> _Enumerate(string divPlain)
		{
			foreach (var item in System.IO.Directory.EnumerateDirectories(divPlain))
			{
				if (nilnul.fs.folder.be_.git_.Plain.Singleton.be(
						new nilnul.fs.Folder1(
							item
						)
					)
				)
				{
					foreach (var item1 in _Enumerate(item) )
					{
						yield return item1;
					}

				}
				else  //git top
				{

				}

			}
			//throw new NotImplementedException();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.div_.git_.top.documents_.git_
{
	static public class _NonRepoX
	{
		static public void Enumerate(
			nilnul.fs.FolderI3 sln

		)
		{
			_Enumerate_ofAddress(sln.address.en.ToString());
		}

		public static IEnumerable<string> _Enumerate_ofAddress(string divTop)
		{
			foreach (var item in System.IO.Directory.EnumerateDirectories(divTop))
			{
				if (nilnul.fs.folder.be_.git_.Work.Singleton.be(
						new nilnul.fs.Folder1(
							item
						)
					)
				)  //git top
				{
					if (
						nilnul.fs.folder.be_.git_.work_.Top.Singleton.be(
							item
						)
					)
					{
						foreach (var item1 in _Enumerate_ofAddress(item))
						{
							yield return item1;
						}
					}
					else
					{

					}

				}
				else
				{

				}

			}
			//throw new NotImplementedException();
		}
	}
}

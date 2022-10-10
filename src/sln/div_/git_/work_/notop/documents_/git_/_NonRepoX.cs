using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.div_.git_.work_.notop.documents_.git_
{
	static public class _NonRepoX
	{
		static public void Enumerate(
			nilnul.fs.FolderI3 sln

		)
		{
			_Enumerate(sln.address.en.ToString());
		}

		public static IEnumerable<string> _Enumerate(string divNoTopWork)
		{
			foreach (var item in System.IO.Directory.EnumerateDirectories(divNoTopWork))
			{

				if (
					nilnul.fs.folder.be_.git_.work_.Top.Singleton.be(
						item
					)
				)
				{
					foreach (
						var item1
						in
						div_.git_.top.documents_.git_._NonRepoX._Enumerate_ofAddress(item)
					)
					{
						yield return item1;
					}
				}
				else //work notop
				{
					foreach (
						var item2 
						in 
						div_.git_.work_.notop.documents_.git_._NonRepoX._Enumerate(item)
					)
					{
						yield return item2;
					}
				}
			}
			//throw new NotImplementedException();
		}
	}
}

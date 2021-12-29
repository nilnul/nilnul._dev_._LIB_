using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.dirs_
{
	/// <summary>
	/// excluding vs generated folders that will not be baked
	/// </summary>
	static public class _ExcludeVsX
	{

		static public string[] slnExclude = new[] { ".vs", "packages" };

		static public string[] prjExc = new[] {
			".vs", "packages", "bin", "obj"

			,
			"TestResults"	///only in "test projects" 


		};



		static public IEnumerable<DirectoryInfo> EnumerateAsAddresses(DirectoryInfo parent)
		{

			var dirs = parent.EnumerateDirectories();
			if (nilnul.fs.folder.be_.vs_.Sln.Singleton.be(parent))
			{
				//dirs = dirs.Except(
				//	dirs.Where(
				//		x => exclude.Contains(
				//			x.Name,
				//			nilnul.txt.eq_.CaseInsensitive.Singleton
				//		)
				//	)
				//);

				dirs = dirs.Where(
					x => !slnExclude.Contains(
							x.Name,
							nilnul.txt.eq_.CaseInsensitive.Singleton
						)
				);
			}
			if (nilnul.fs.folder.be_.vs_.Prj.Singleton.be(parent))
			{
				//dirs = dirs.Except(dirs.Where(
				//	x => prjExc.Contains(
				//		x.Name,
				//		nilnul.txt.eq_.CaseInsensitive.Singleton
				//	)
				//)
				//);
				dirs = dirs.Where(
					x => !prjExc.Contains(
						x.Name,
						nilnul.txt.eq_.CaseInsensitive.Singleton
					)
				
				);
			}

			return dirs;
		}

		static public IEnumerable<string> EnumerateAsAddresses(string parent)
		{
			return EnumerateAsAddresses(new DirectoryInfo(parent)).Select(x => x.FullName);
		}
	}
}

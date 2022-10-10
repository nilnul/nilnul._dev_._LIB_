using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.deV_.prj.dirs_.notDotLed_
{
	/// <summary>
	/// excluding vs generated folders that will not be baked
	/// </summary>
	static public class _ExcludeAutogenX
	{

		static public string[] prjGenerated = new[] {
			 "packages", "bin", "obj"
			,
			"TestResults"	///only in "test projects" 
		};	

		static public IEnumerable<DirI> _Dirs_assumePrj(nilnul.fs.FolderI parent)
		{
			return nilnul.fs.folder.dirs_._NotDotLedX.Dirs(parent).Where(
				d=>!prjGenerated.Contains(
					d.denote.en,
					nilnul.txt.eq_.CaseInsensitive.Singleton
				)
			);
		}

		static public IEnumerable<DirI> _Dirs_assumePrj(nilnul.fs.Folder parent)
		{
			return _Dirs_assumePrj(
				(nilnul.fs.FolderI)(parent)
			);
		}

		static public IEnumerable<DirI> _Dirs_assumePrj(DirectoryInfo parent)
		{
			return _Dirs_assumePrj(
				new nilnul.fs.Folder(parent)
			);
		}

		static public IEnumerable<DirI> _Dirs_addressAssumePrj(string parent)
		{
			return _Dirs_assumePrj(
				nilnul.fs.Folder.FroAddress(parent)
			);
		}
	}
}

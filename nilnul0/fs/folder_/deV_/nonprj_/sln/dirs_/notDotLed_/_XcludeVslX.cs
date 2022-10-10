using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.deV_.nonprj_.sln.dirs_.notDotLed_
{
	/// <summary>
	/// excluding vs generated folders that will not be baked
	/// </summary>
	static public class _ExcludeAutogenX
	{

		

		static public IEnumerable<DirI> _Dirs_assumeNonprjSln(nilnul.fs.FolderI parent)
		{
			return nilnul.fs.folder.dirs_._NotDotLedX.Dirs(parent).Where(
				d=>d.denote.en.ToLower()!="packages"
			);
		}

		static public IEnumerable<DirI> _Dirs_assumeNonprjSln(nilnul.fs.Folder parent)
		{
			return _Dirs_assumeNonprjSln(
				(nilnul.fs.FolderI)(parent)
			);
		}

		static public IEnumerable<DirI> _Dirs_assumeNonprjSln(DirectoryInfo parent)
		{
			return _Dirs_assumeNonprjSln(
				new nilnul.fs.Folder(parent)
			);
		}

		static public IEnumerable<DirI> _Dirs_addressAssumeNonprjSln(string parent)
		{
			return _Dirs_assumeNonprjSln(
				nilnul.fs.Folder.FroAddress(parent)
			);
		}
	}
}

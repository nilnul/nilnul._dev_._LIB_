using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.deV_.nonprj.dirs_.notDotLed_
{
	/// <summary>
	/// excluding vs generated folders that will not be baked
	/// </summary>
	static public class _ExcludeAutogenX
	{

		

		static public IEnumerable<DirI> _Dirs_assumeNonprj(nilnul.fs.FolderI parent)
		{
			if (nilnul.fs.folder.be_.vs_.Sln.Singleton.be(parent))
			{
				return nonprj_.sln.dirs_.notDotLed_._ExcludeAutogenX._Dirs_assumeNonprjSln(parent);
			}

			return nilnul.fs.folder.dirs_._NotDotLedX.Dirs(parent);
		}

		static public IEnumerable<DirI> _Dirs_assumeNonprj(nilnul.fs.Folder parent)
		{
			return _Dirs_assumeNonprj(
				(nilnul.fs.FolderI)(parent)
			);
		}

		static public IEnumerable<DirI> _Dirs_assumeNonprj(DirectoryInfo parent)
		{
			return _Dirs_assumeNonprj(
				new nilnul.fs.Folder(parent)
			);
		}

		static public IEnumerable<DirI> _Dirs_addressAssumeNonprj(string parent)
		{
			return _Dirs_assumeNonprj(
				nilnul.fs.Folder.FroAddress(parent)
			);
		}
	}
}

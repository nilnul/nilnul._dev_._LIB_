using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.dirs_.notDotLed_.deV_
{
	/// <summary>
	/// excluding vs generated folders that will not be baked
	/// </summary>
	static public class _ExcludeVsX
	{

		

		static public IEnumerable<DirI> Dirs(nilnul.fs.FolderI parent)
		{
			var be = new nilnul.fs.folder.dir.be_.deV_.vsGen.Anto(parent);

			return dirs_._NotDotLedX.Dirs(parent).Where(
				d => be.be(d)
			);
			
		}

		static public IEnumerable<DirI> Dirs(nilnul.fs.Folder parent)
		{
			return Dirs(
				(nilnul.fs.FolderI)(parent)
			);
		}

		static public IEnumerable<DirI> Dirs(DirectoryInfo parent)
		{
			return Dirs(
				new nilnul.fs.Folder(parent)
			);
		}

		static public IEnumerable<DirI> Dirs_ofAddress(string parent)
		{
			return Dirs(
				nilnul.fs.Folder.FroAddress(parent)
			);
		}
	}
}

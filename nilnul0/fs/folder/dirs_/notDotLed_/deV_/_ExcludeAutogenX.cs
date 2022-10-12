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
	static public class _ExcludeAutogenX
	{



		static public IEnumerable<DirI> Dirs(nilnul.fs.FolderI parent)
		{
			if (nilnul.fs.folder.be_.vs_.Prj.Singleton.be(parent))
			{
				return nilnul.fs.folder_.deV_.prj.dirs_.notDotLed_._ExcludeAutogenX._Dirs_assumePrj(parent);
			}


			return nilnul.fs.folder_.deV_.nonprj.dirs_.notDotLed_._ExcludeAutogenX._Dirs_assumeNonprj(parent);



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

		static public IEnumerable<string> Addresses(DirectoryInfo parent)
		{

			return Dirs(parent).Select(
				d=>
				System.IO.Path.Combine(
					parent.FullName
					,
					d.denote.en
				)
			);
		}

		static public IEnumerable<string> Addresses_ofAddress(string parent)
		{
			return Addresses(new DirectoryInfo(parent));
		}
	}
}

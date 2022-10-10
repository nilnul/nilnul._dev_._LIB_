using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src
{
	static public class _SlnsX
	{
		static public IEnumerable<fs._address.DirI> _Dirs_assumeSrc(nilnul.fs.FolderI folder) {
			return nilnul.fs.folder._DirsX.Dirs(folder).Where(
				nilnul.dev.src.dir.be_._sln._OfDirX.Be
			);
		}

		static public IEnumerable<fs.address_.shield_.BaseDir> _Shields_assumeSrc(nilnul.fs.FolderI folder) {
			return _Dirs_assumeSrc(folder).Select(
				d=>
				new nilnul.fs.address_.shield_.BaseDir(folder.address.en, d)
			);
		}

	}
}

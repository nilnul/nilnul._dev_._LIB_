using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.directories_.notDotLed_.deV_
{
	public class NoVsGenerated
	{
		static public IEnumerable<nilnul.fs._address.DirectoryI> Directories(
			nilnul.fs.FolderI folder
		) {
			return nilnul.fs.folder.dirs_.notDotLed_.deV_._ExcludeVsX.Dirs(folder).SelectMany(
				dir => fs.folder.divs_.notDotLed_.deV_._ExcludeVsX.Divs(
new nilnul.fs.folder_.ParentDir(
						folder.address.en,
						dir
					)
				).Select(
					div => _address.directory_._DirDivX.Directory(dir, div)
				)
			);
		}
	}
}

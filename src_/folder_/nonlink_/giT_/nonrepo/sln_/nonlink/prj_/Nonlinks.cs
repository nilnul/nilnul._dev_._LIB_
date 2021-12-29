using nilnul.fs.folder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src_.folder_.nonlink_.giT_.nonrepo.sln_.nonlink.prj_
{
	static public class _NonlinksX
	{
		static public IEnumerable<nilnul.fs._address.Directory> Nonlinks(
			nilnul.fs.FolderI _slnNonlink

		) {
			foreach (var dir in nilnul.fs.folder.dirs_.nonlink_._NotDotLedX.Dirs(_slnNonlink)
			)
			{
				var dirShield = new nilnul.fs.address_.shield_.BaseDir(
					_slnNonlink.address.en, dir
				);
				if (
					nilnul.fs.folder.be_.vs_.Prj.Singleton.Be(dirShield)
				)
				{
					yield return new fs._address.Directory( dir );
				}
				else
				{
					foreach (var item in
nilnul.dev.src_.folder_.nonlink_.giT_.nonrepo.sln_.nonlink.directory_.nonlink_.nonprj.directory_.nonlink_._PrjsX._Prjs_assumeSlnDirectoryNonlinkNonprj(dirShield)
						)
					{
						yield return fs._address.directory_._DirDivX.Directory(dir,  item );
					}


				}




			}
		}
	}
}

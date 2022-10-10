using nilnul.fs._address;
using nilnul.fs.address_.shield_;
using nilnul.fs.folder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src_.folder_.nonlink_.giT_.nonrepo.sln_.nonlink.directory_.nonlink_.nonprj.directory_.nonlink_
{
	static public class _PrjsX
	{
		static public IEnumerable<nilnul.fs._address.Directory> _Prjs_assumeSlnDirectoryNonlinkNonprj(
			nilnul.fs.FolderI _slnDirectoryNonlinkNonprj

		) {
			foreach (var dir in nilnul.fs.folder.dirs_.nonlink_._NotDotLedX.Dirs(_slnDirectoryNonlinkNonprj)
			)
			{
				var dirShield = new nilnul.fs.address_.shield_.BaseDir(
					_slnDirectoryNonlinkNonprj.address.en, dir
				);
				if (
					nilnul.fs.folder.be_.vs_.Prj.Singleton.Be(dirShield)
				)
				{
					yield return new fs._address.Directory( dir );
				}
				else
				{
					foreach (var item in _Prjs_assumeSlnDirectoryNonlinkNonprj( dirShield))
					{
						yield return nilnul.fs._address.directory_._DirDivX.Directory(dir, item );
					}

				}




			}
		}

		public static IEnumerable<fs._address.Directory> _Prjs_assumeSlnDirectoryNonlinkNonprj(nilnul.fs.address_.ShieldI dirShield)
		{
			return _Prjs_assumeSlnDirectoryNonlinkNonprj(new nilnul.fs.Folder( dirShield) );
		}
	}
}

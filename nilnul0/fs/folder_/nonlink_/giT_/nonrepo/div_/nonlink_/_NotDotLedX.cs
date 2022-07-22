using nilnul.fs._address;
using nilnul.fs.address_.shield_;
using nilnul.fs.folder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.nonlink_.giT_.nonrepo.div_.nonlink_
{
	static public class _NotDotLedX
	{
		static public IEnumerable<nilnul.fs._address.DivI> _Divs_assumeNonlinkNonrepo(
			nilnul.fs.FolderI _nonlinkNonrepo

		)
		{
			
			yield return new fs._address.Div();
			foreach (var dir in nilnul.fs.folder.dirs_.nonlink_._NotDotLedX.Dirs(_nonlinkNonrepo)
			)
			{
				var dirShield = new nilnul.fs.address_.shield_.BaseDir(
					_nonlinkNonrepo.address.en, dir
				);

				foreach (
					var item
					in
					_Divs_assumeNonlinkNonrepo(dirShield)
					)
				{
					yield return fs._address.directory_._DirDivX.Directory(dir, item);
				}
			}
		}

		public static IEnumerable<nilnul.fs._address.DivI> _Divs_folderAddressAssumeNonlinkNonrepo(string folder)
		{
			return _Divs_assumeNonlinkNonrepo(
				nilnul.fs.Folder.FroAddress(folder)
			);

		}

		static public IEnumerable<nilnul.fs.address_.ShieldI> _Shields_assumeNonlinkNonrepo(
			nilnul.fs.FolderI _nonlinkNonrepo

		)
		{
			return _Divs_assumeNonlinkNonrepo(_nonlinkNonrepo).Select(
				d => new nilnul.fs.address_.shield_.BaseDiv(_nonlinkNonrepo.address.en, d)
			);

		}
		static public IEnumerable<nilnul.fs.address_.ShieldI> _Shields_assumeNonlinkNonrepo(
			nilnul.fs.address_.ShieldI _nonlinkNonrepo

		)
		{
			return _Shields_assumeNonlinkNonrepo(new nilnul.fs.Folder(_nonlinkNonrepo));

		}
		static public IEnumerable<nilnul.fs.address_.ShieldI> _Shields_ofAddressAssumeNonlinkNonrepo(
			string _nonlinkNonrepo

		)
		{
			return _Shields_assumeNonlinkNonrepo(nilnul.fs.address_.Shield.FroAddress(_nonlinkNonrepo));

		}

		public static IEnumerable<DivI> _Divs_assumeNonlinkNonrepo(nilnul.fs.address_.ShieldI dirShield)
		{
			return _Divs_assumeNonlinkNonrepo(new nilnul.fs.Folder(dirShield));
		}
		public static IEnumerable<DivI> Divs(nilnul.fs.folder_.nonlink_.giT_.Nonrepo dirShield)
		{
			return _Divs_assumeNonlinkNonrepo(dirShield.en);
		}


	}
}

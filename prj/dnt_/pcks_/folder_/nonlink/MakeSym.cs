using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.synd_.cs.dir_.packaged
{
	/// <summary>
	/// assume it is nonlink folder.
	/// copy the dirs into a designated shared installed folder if the dir is not there.
	/// remove this dir.
	/// make symlink to the shared installaltion folder.
	/// </summary>
	/// <remarks>
	/// assumes package dir exists as nonlink folder.
	/// </remarks>
	static public class _MakeSymX
	{
		static public void Vod_prjOfAddressAssumeCsPackagedNonlink_tgtOfAddressAssumeFolder(
			string prj
			,
			string sharedInsallation
		)
		{

			var folder4installedInPrj = nilnul.fs.address_.shield_.BaseDir.Create__parentAddress_dirName(
				prj, dir_._PackagedX.NAME
			);

			var pacsInstalled = nilnul.fs.folder._DirsX.Dirs(folder4installedInPrj);

			var installedInShared = nilnul.fs.folder._DirsX.Dirs_ofAddress(sharedInsallation);

			var toBeMoved = pacsInstalled.Except(installedInShared, fs._address.dir.Eq.Singleton);

			toBeMoved.Each(
				d => nilnul.fs.folder.dirs._MoveX._Vod_tgtOfAddressAssumeDirsUnoccupied(
					folder4installedInPrj
					,
					toBeMoved
					,
					sharedInsallation
				)
			);

			//drop the installedS;

			nilnul.fs.folder.drop_._RecyclableX.Drop(folder4installedInPrj);
			//make link

			nilnul.fs.folder_.link._CreateX.Vod_ofAddress(
				folder4installedInPrj
				,
				sharedInsallation
			); ;

		}
		static public void Vod_prjAssumeCs_tgtOfAddressAssumeFolder(
			nilnul.fs.address_.ShieldI synd
			,
			string sharedInsallation
		)
		{
			var folder4installedInPrj = nilnul.fs.address_.shield_.BaseDir.Create_dirDenote(
				synd, dir_._PackagedX.NAME
			);
			if (nilnul.fs.address_.shield.be_.folder.Anto.Singleton.be(folder4installedInPrj) )
			{
				return;
			}
			if (nilnul.fs.folder.be_.link_._SymX.Be(folder4installedInPrj))
			{
				return;
			}

			Vod_prjOfAddressAssumeCsPackagedNonlink_tgtOfAddressAssumeFolder(
				synd.ToString(),
				sharedInsallation
			);

		}

		static public void Vod_prjOfAddressAssumeCs_tgtOfAddressAssumeFolder(
			string prj
			,
			string sharedInsallation
		)
		{
			Vod_prjAssumeCs_tgtOfAddressAssumeFolder(
				nilnul.fs.address_.Shield.FroAddress(prj)
				,
				sharedInsallation
			);

		}

	}
}

using nilnul.fs.address_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj.dir_.deps_.unoccupied01empty.mksym.attempt
{
	/// <summary>
	/// the norm is in src.
	/// </summary>

	static public class _TgtSrcDirX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="prjAddress"></param>
		/// <param name="dir"></param>
		static public void Vod_assumePrjContainer(nilnul.fs.folder_.Normal prjAddress, nilnul.fs._address.DirI dir) {
			var depsFolder = nilnul.dev.src.prj.dir_._DepsX.Shield_ofPrjContainer(
				prjAddress.en.address.en
			);

			if (nilnul.fs.address_.shield.be_.Newable0EmptyFolder.Singleton.be(depsFolder) )
			{
				var src = nilnul.dev.srcs.which_._SupOfX.SrcNulable(depsFolder);
				if (!(src is null))
				{
					deps_.unoccupied01empty.mksym._AttemptX.Vod_prjAssumeVs_tgtOfFolderAssumeAddress(
						prjAddress.en.address.en
						,
						new nilnul.fs.address_.shield_.BaseDir(src,dir).ToString()
					);
				}
			}
		}


		static public void Vod_addressAssumePrjContainer(string prjAddress, nilnul.fs._address.DirI dir) {
			Vod_assumePrjContainer(
				 fs.folder_.Normal.FroAddress(prjAddress),dir
			);
		}

		[Obsolete()]
		static public void Vod_ofAddressAssumePrjContainer_ofDst(string prjAddress, string dst) {
			Vod_assumePrjContainer(
				 fs.folder_.Normal.FroAddress(prjAddress),nilnul.fs._address.Dir.OvDst(dst)
			);
		}

		static public void Vod_prjContainerOfAddress_ofDst(string prjAddress, string dst) {
			Vod_assumePrjContainer(
				 fs.folder_.Normal.FroAddress(prjAddress),nilnul.fs._address.Dir.OvDst(dst)
			);
		}

		public static void Vod_assumePrjContainer(ShieldI parent, string tgt)
		{
			Vod_assumePrjContainer(
				new fs.folder_.Normal(parent),nilnul.fs._address.Dir.OvDst(tgt)
			);
		}

		public static void Vod_prjOfDoc(string doc)
		{
			var prjAddress = nilnul.dev.src.sln.sub.synd.prj._main._LocateNulableX.SpearNulable_ofDoc(doc);

			Vod_assumePrjContainer(
				(prjAddress.parent)
				,
nilnul.dev.prj.dir_.deps_.unoccupied01empty.mksym.attempt._tgtSrcDir.SettingsX.Dnt
				//nilnul.dev.prj.dir_.deps_.unoccupied01empty.mksym.attempt._tgtSrcDir.Settings1.Default.dnt
			);
		}


		public static void Vod_prjOfMain(string doc)
		{
			var prjAddress = nilnul.dev.src.sln.sub.dir_._synd._ChooseX.ShieldNulable_ovBase(doc);

			Vod_assumePrjContainer(
				prjAddress
				,
				nilnul.dev.prj.dir_.deps_.unoccupied01empty.mksym.attempt._tgtSrcDir.SettingsX.Dnt

//nilnul.dev.src.synd.dir_.deps_.unoccupied01empty.mksym.attempt._tgtSrcDir.Settings1.Default.dnt
			);
		}

	


	}
}

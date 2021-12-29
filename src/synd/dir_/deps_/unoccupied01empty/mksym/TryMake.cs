using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj.dir_.deps_.unoccupied01empty.mksym
{
	/// <summary>
	/// if unoccupied, create one. If it's empty, delete and create one
	/// </summary>
	static public class _AttemptX
	{
		
		static public void Vod_prjAssumeVs_tgtOfFolderAssumeAddress(
			nilnul.fs.address_.ShieldI prj
			,
			string sharedInsallation=null
		)
		{
			sharedInsallation = sharedInsallation ?? Properties.SettingsX.NugetPacsSrcAddress;

			//var folder4installedInPrj = new nilnul.fs.address_.spear_.ParentDoc(
			//	prj, dir_._PacsInstalledX.NAME
			//);
			var folder4installedInPrj =  nilnul.fs.address_.shield_.BaseDir.Create_dirDenote(
				prj, dir_._DepsX.NAME
			);


			if (nilnul.fs.address_.shield.be_.Newable0EmptyFolder.Singleton.be(folder4installedInPrj))
			{

				dir_.deps_.unoccupied01empty.MakeSymX.Vod_prjAssumeUnoccupied01empty_tgtOfAddressAssumeFolder(prj,sharedInsallation);

			}


		}

		static public void Vod_prjOfAddressAssumeVs_tgtOfAddressAssumeFolder(
			string prj
			,
			string sharedInsallation=null
		)
		{
			

			Vod_prjAssumeVs_tgtOfFolderAssumeAddress(
				nilnul.fs.address_.Shield.FroAddress(prj)
				,
				sharedInsallation
			);

		}

		static public void Vod_prjOfAddress_tgtOfAddressAssumeFolder(
			string prj
			,
			string sharedInsallation=null
		)
		{
			nilnul.bit.vow_.True1.Vow(
				nilnul.fs.folder.be_.deV_.src_.prj_.Vs.Singleton.be_ofAddress(prj)
			);

			Vod_prjAssumeVs_tgtOfFolderAssumeAddress(
				nilnul.fs.address_.Shield.FroAddress(prj)
				,
				sharedInsallation
			);

		}


	}

}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj_.vs.dir_.pacs_.link_.sym
{
	/// <summary>
	/// try best to create one:
	///		if it's nonlink folder, move the files to the linked , and remake this as a link to that.
	/// </summary>
	///
	[Obsolete(nameof(nilnul.dev.prj.dnt_.pcks._TryMakeX))]
	static public partial class TryMakeX
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
				prj, dir_._PacsInstalledX.NAME
			);


			if (nilnul.fs.address_.shield.be_.Newable.Singleton.be(folder4installedInPrj))
			{
				//create

				dir_.pacs_.link_.sym_.unoccupied.create_._ShortcutX.Vod_prjAssumeVs_tgtOfFolderAssumeAddress(prj,sharedInsallation);
				return;
			}
			if (nilnul.fs.address_.shield.be_.OccupiedByFile.Singleton.be(folder4installedInPrj))
			{
				return;
			}
			//folder
			if (nilnul.fs.folder.be_.link_._SymX.Be(folder4installedInPrj))
			{
				return;
			}
		
			;
			nilnul.dev.src.synd_.cs.dir_.packaged._MakeSymX.Vod_prjOfAddressAssumeCsPackagedNonlink_tgtOfAddressAssumeFolder
			(
				prj.ToString(),
				sharedInsallation);

		}

		/// <summary>
		/// assume this is a prj
		/// </summary>
		/// <param name="prj"></param>
		/// <param name="sharedInsallation"></param>
		static public void Vod_prjOfAddressAssumeVs_tgtOfAddressAssumeFolder(
			string prj
			,
			string sharedInsallation=null
		)
		{
			sharedInsallation = sharedInsallation ?? Properties.SettingsX.NugetPacsSrcAddress;

			Vod_prjAssumeVs_tgtOfFolderAssumeAddress(
				nilnul.fs.address_.Shield.FroAddress(prj)
				,
				sharedInsallation
			);

		}

		/// <summary>
		/// vow this is a prj
		/// </summary>
		/// <param name="prj"></param>
		/// <param name="sharedInsallation"></param>
		static public void Vod_prjOfAddress_tgtOfAddressAssumeFolder(
			string prj
			,
			string sharedInsallation=null
		)
		{
			sharedInsallation = sharedInsallation ?? Properties.SettingsX.NugetPacsSrcAddress;

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

	static public partial class TryMakeX
	{

		[Obsolete(nameof(nilnul.dev.prj.dir_.deps_.unoccupied.create_.sym_._Srced0dossieredX.Vod_prjOfAddressAssumeVs1pacsUnoccupied_tgtOfAddressAssumeFolder))]
		static public void Vod_prjOfAddressAssumeVs1pacsUnoccupied_tgtOfAddressAssumeFolder(
			string prj
			,
			string sharedInsallation=null
		)
		{
			nilnul.dev.prj.dir_.deps_.unoccupied.create_.sym_._Srced0dossieredX.Vod_prjOfAddressAssumeVs1pacsUnoccupied_tgtOfAddressAssumeFolder(prj,sharedInsallation);

		}

		


	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj.dir_.deps_.emtpy
{
	/// <summary>
	///  If it's empty, delete and create one
	/// </summary>
	static public class MakeSymX
	{
		static public void _Vod_prjOfAddressAssumeDepsEmpty_tgtOfAddressAssumeFolder(
			string prj
			,
			string sharedInsallation=null
		)
		{

			nilnul.fs.folder._DropX.Vod(
				src.prj.dir_._DepsX.Shield_prjContainerOfAddresss(prj)
			);

			src.prj.dir_.deps_.unoccupied.create_._TgtRelative_prjAssumeDepsUnoccupied_tgtAssumeFolderX._Vod_prjOfAddress_tgtOfAddress(prj,sharedInsallation);




		}
		static public void Vod_prjAssumeEmpty_tgtOfAddressAssumeFolder(
			nilnul.fs.address_.ShieldI prj
			,
			string sharedInsallation=null
		)
		{
			_Vod_prjOfAddressAssumeDepsEmpty_tgtOfAddressAssumeFolder
			(
				prj.ToString(),
				sharedInsallation);

		}

	

	}

}

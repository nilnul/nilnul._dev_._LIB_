using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj.dir_.deps_.unoccupied01empty
{
	/// <summary>
	/// if unoccupied, assume it's empty, then create one.
	/// If it's empty, delete and create one
	/// </summary>
	static public class MakeSymX
	{
		static public void _Vod_prjOfAddressAssumeUnoccupied01empty_tgtOfAddressAssumeFolder(
			string prj
			,
			string sharedInsallation = null
		)
		{
			if (
				nilnul.fs.address.be_.Occupied.Singleton.be(prj)
			)
			{
				deps_.emtpy.MakeSymX._Vod_prjOfAddressAssumeDepsEmpty_tgtOfAddressAssumeFolder(prj, sharedInsallation);
				return;
			}
			unoccupied.create_._TgtRelative_prjAssumeDepsUnoccupied_tgtAssumeFolderX._Vod_prjOfAddress_tgtOfAddress(prj, sharedInsallation);







		}
		static public void Vod_prjAssumeUnoccupied01empty_tgtOfAddressAssumeFolder(
			nilnul.fs.address_.ShieldI prj
			,
			string sharedInsallation = null
		)
		{

			_Vod_prjOfAddressAssumeUnoccupied01empty_tgtOfAddressAssumeFolder
			(
				prj.ToString(),
				sharedInsallation);

		}




	}

}

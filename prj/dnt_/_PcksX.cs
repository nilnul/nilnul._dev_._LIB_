using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj.dnt_
{
	/// the reference to dll is relative. make the installed folder path steady and it would be easy to move the src among computers.
	/// <summary>
	/// </summary>
	/// alias:
	///		pcks
	///			pack s
	///		
	///		
	static public class _PcksX
	{
		/// <summary>
		/// 
		/// </summary>
		/// 
		//public const string NAME = "packages";// "packages";

		static public nilnul.fs.address_.shield_.BaseDir Shield_prjContainerOfAddresss(string prjAddress) {
			return  fs.address_.shield_.BaseDir.Create__parentAddress_dirName(prjAddress,_pcks.SettingsX.Caption);
		}

		static public nilnul.fs.address_.shield_.BaseDir Shield_ofPrjMeta(string prjAddress) {
			return  Shield_ofPrjContainerAsShield( nilnul.fs.address_.spear._ContainerX.TxtUptoLastSep(prjAddress));
		}

		static public nilnul.fs.Folder  Folder_ofPrjMeta(string prjAddress) {
			return  new nilnul.fs.Folder(Shield_ofPrjMeta(prjAddress));
		}

		static public nilnul.fs.Folder  Folder_ofPrjMeta(nilnul.fs.file_.ext_.deV_.Sqlproj prjAddress) {
			return  new nilnul.fs.Folder(Shield_ofPrjMeta(prjAddress.ToString()));
		}

		static public nilnul.fs.Folder  Folder_ofPrjMeta(nilnul.fs.address_.SpearI prjAddress) {
			return  new nilnul.fs.Folder(Shield_ofPrjMeta(prjAddress.ToString()));
		}

		static public nilnul.fs.address_.shield_.BaseDir Shield_ofPrjContainer(nilnul.fs.AddressI prjAddress) {
			return  fs.address_.shield_.BaseDir.Create_dirOfDenote(prjAddress,_pcks.SettingsX.Caption);
		}

		static public nilnul.fs.address_.shield_.BaseDir Shield_ofPrjContainer(nilnul.fs.address_.ShieldI prjAddress) {
			return  fs.address_.shield_.BaseDir.Create_dirOfDenote(prjAddress,_pcks.SettingsX.Caption);
		}

		static public nilnul.fs.address_.shield_.BaseDir Shield_ofPrjContainerAsShield(string prjAddress) {
			return  fs.address_.shield_.BaseDir.OfContainerAddress_DirDst( prjAddress,_pcks.SettingsX.Caption);
		}



	}
}

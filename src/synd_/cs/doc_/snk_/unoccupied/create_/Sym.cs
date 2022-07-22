using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.synd_.cs.doc_.snk_.unoccupied.create_
{
	/// <summary>
	/// assume the doc is not occupied. create symlink to the given file.
	/// </summary>
	static public class _SymX
	{
		static public string Address_underPrimarySrc() {
			var primary = nilnul.dev.src_.Primary.Address_ofCfg().ToString();
			var captions= nilnul.fs.folder.docs_._ExtX.Captions_ofAddress( primary ,".snk" ).Take(2);
			if (captions.Count()!=1)
			{
				return null;
			}
			return System.IO.Path.Combine( primary, captions.First() );
		}

		static public void _Vod_prjFolderOfAddressAssumeSnkeyUnoccupied(
			string prj
			,
			string sharedInsallation
		)
		{

			/// create relative

			nilnul.fs.file_.link_.sym_.path._CreateX.CreateUsingPath(
				new fs.address_.Spear(
				System.IO.Path.Combine(prj, nilnul.dev.src.synd_.cs.doc_._SnkX.TMP_DOC)
				)
				,
				new fs.address_.Spear(
				sharedInsallation
				)
			); ;

		}
		static public void _Vod_prjAssumeCs(
			nilnul.fs.address_.ShieldI prj
			,
			string sharedInsallation
		)
		{
			

			_Vod_prjFolderOfAddressAssumeSnkeyUnoccupied(
				prj.ToString(),
				sharedInsallation);

		}

		static public void _Vod_prjAssumeCs(
			nilnul.fs.FolderI prj
			,
			string sharedInsallation
		)
		{
			

			_Vod_prjFolderOfAddressAssumeSnkeyUnoccupied(
				prj.ToString(),
				sharedInsallation);

		}

		

	}
}

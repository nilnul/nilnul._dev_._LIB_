using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.deV_.src_.bak_._neglect._cfg_
{
	/// <summary>
	/// </summary>
	///
	[Obsolete("see nilnul.dev.bak")]

	static public class _ExcludeX0
	{


		static public bool Be(nilnul.fs.FolderI s, nilnul.win.prog_.Git git = null) {
			var r = nilnul.win.prog_.git_.cfg.read_._ResultX.Result
			   (new address_.spear_.ParentDoc(s.address.en, ".nilnulCfg"),
			   "bak.exclude", git);
			return r.msg.Trim()== "1" ;
		}

		static public bool Be(nilnul.fs.address_.ShieldI s, nilnul.win.prog_.Git git = null) {
			return Be(new nilnul.fs.Folder(s),git);
		}


		static public bool Be_ofAddress(string s, nilnul.win.prog_.Git git = null) {
			return Be( nilnul.fs.address_.shield_._AddressX1.Create(s),git);
		}



	}
}

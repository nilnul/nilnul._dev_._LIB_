using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.win.program_;

namespace nilnul.fs.folder.be_.deV_.src_.bak_._neglect
{
	/// <summary>
	/// neglect this folder
	/// </summary>
	///
	[Obsolete("see nilnul.dev.bak")]

	static public class _PerNameX0
	{

		public const string SUFFIX = "(!Bak";

		public const string INFIX = SUFFIX + ")";


		static public bool Be(nilnul.fs.FolderI s, nilnul.win.prog_.Git git =null) {
			if (
				nilnul.txts_.fs_._AppendDecksX.Arr(SUFFIX).Any(x=>
					s.ToString().EndsWith(  x  )
				)

				||
				s.ToString().Contains(INFIX)

			)
			{
				return true;
			}
			return false;
		}

		public static bool Be(ShieldI shield, win.prog_.Git git)
		{
			return Be(new nilnul.fs.Folder(shield),git);
		}

		static public bool Be_ofAddress(string s, nilnul.win.prog_.Git git =null) {
			return Be(nilnul.fs.Folder.FroAddress(s),git);
		}

	}
}

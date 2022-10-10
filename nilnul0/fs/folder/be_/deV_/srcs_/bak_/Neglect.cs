using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.win.program_;

namespace nilnul.fs.folder.be_.dev_.srcs_.bak_
{
	/// <summary>
	/// neglect this folder
	/// </summary>
	static public class _NeglectX
	{

		public const string SUFFIX = "(!Bak";

		public const string INFIX = SUFFIX + ")";


		static public bool Be(nilnul.fs.FolderI3 s, nilnul.win.program_.Git git =null) {
			if (
				nilnul.txts_.fs_._AppendDecksX.Arr(SUFFIX).Any(x=>
					s.ToString().EndsWith(  x  )
				)

				||
				s.ToString().Contains(INFIX)

				||
				_neglect._PerNilnulCfgX.Be(s,git))
			{
				return true;
			}
			return false;
		}

		public static bool Be(ShieldI1 shield, win.program_.Git git)
		{
			return Be(new nilnul.fs.Folder2(shield),git);
		}

		static public bool Be_ofAddress(string s, nilnul.win.program_.Git git =null) {
			return Be(nilnul.fs.folder_._AddressX1.Create(s),git);
		}

	}
}

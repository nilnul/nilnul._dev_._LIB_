using nilnul.dev.srcs._bak;
using nilnul.win.program_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.src.dir.be_._sln
{
	static public  class _OfDirX
	{
		
		static public bool _IsSlnNameBlank(string denote) {

			return nilnul.txt.be_.White.Singleton.be(
				nilnul.fs.folder._repoName.dir.name_.idioms0Comments._ParseX.Parse(
					denote
				).name
			);
		}

		static public bool Be(
			nilnul.fs._address._dst.Denote srcDir
		)
		{
			return ! (
				srcDir.en.StartsWith(".")
				||
				_IsSlnNameBlank(srcDir)
			)	;
		}

		/// <summary>
		/// </summary>
		/// <param name="srcDir"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public bool Be(
			nilnul.fs._address.DirI srcDir
		)
		{
			return Be(srcDir.denote)	;
		}
	}
}

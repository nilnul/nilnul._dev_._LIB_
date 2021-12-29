using nilnul.dev.srcs._bak;
using nilnul.win.program_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.src.dir.be_
{
	static public  class _SlnX
	{
		


		/// <summary>
		/// </summary>
		/// <param name="srcDir"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public bool _Be_assumeSrcDir(
			nilnul.fs.FolderI srcDir
		)
		{

			return ! (
				srcDir.address.en.stem.div.dirs.Last().denote.en.StartsWith(".")
				||
				IsSlnNameBlank(srcDir)
			)	;
		}



		static public bool IsSlnNameBlank(nilnul.fs.FolderI folder) {

			return nilnul.txt.be_.White.Singleton.be(
				nilnul.fs.folder._repoName.dir.name_.idioms0Comments._ParseX.Parse(
					folder.address.en.stem.div.dirs.Last().denote.ToString()
				).name
			);
		}

		 static public bool Be_ofAddressAssumeSrcDir(
			string folder
		)
		{
			return _Be_assumeSrcDir(nilnul.fs.Folder.FroAddress(folder));
		}


	}

}

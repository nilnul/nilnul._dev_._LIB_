using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remotes.has_.bak_
{
	static public class Vs
	{


		static public bool Exe(nilnul.fs.folder_.git_.Top module, nilnul.win.prog_.Git git = null)
		{
			return nilnul.dev.srcs.bak_._retVoid.Settings1.Default.moduleRemoteKeysVs.Cast<string>().Any(
				x=> nilnul.fs.git.module.repo._cfg_.remotes._HasX1.Has(
					module
					,
				
					x
					, git
				)
			);
		}

		static public bool Exe(nilnul.fs.FolderI module, win.prog_.Git git = null)
		{
			return Exe(
				new fs.folder_.git_.Top(module), git
			);
		}



	}
}

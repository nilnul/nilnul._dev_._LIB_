using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remotes_.vsAwsBbGl
{
	static public class _ClearX
	{
		static public void Exe(nilnul.fs.folder_.git_.Top gitTop , nilnul.win.prog_.Git git=null ) {
			remote_.bak_.aw._DropX.OfAllVers(gitTop, git);
			remote_.bak_.bb._DropX.OfAllVers(gitTop, git);
			remote_.bak_.gl._DropX.OfAllVers(gitTop, git);
			remote_.bak_.vs._DropX.OfAllVers(gitTop, git);

			

		}

		static public void Exe(nilnul.fs.FolderI  gitTop, nilnul.win.prog_.Git git=null) {
			 Exe( new fs.folder_.git_.Top(gitTop));

		}



	}
}

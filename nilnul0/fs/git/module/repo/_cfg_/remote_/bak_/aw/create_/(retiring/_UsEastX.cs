using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.aw.create_
{
	////extern alias git;
	[Obsolete()]
	static public class _UsEastX
	{


		public static nilnul.fs.git.module.repo._cfg_._remote.Name Key = new nilnul.fs.git.module.repo._cfg_._remote.Name(_CfgedX.KEY_TXT);

		static public void Void(nilnul.fs.folder_.git_.Top _gitTop,  nilnul.fs.git.svr.repo.Name svrRepoName,  nilnul.win.prog_.Git git = null)
		{
			nilnul.fs.git.module.repo._cfg_.remote.create_._AwsX.RetVoid(_gitTop, Key, svrRepoName, git);
		}

		static public void Void(nilnul.fs.folder_.git_.Top _gitTop,  string svrRepoName,  nilnul.win.prog_.Git git = null)
		{
			Void(
				_gitTop, 
				new svr.repo.Name( svrRepoName)
				, git);
		}

		static public void Void(nilnul.fs.FolderI _gitTop,  string svrRepoName,  nilnul.win.prog_.Git git = null)
		{


			Void(
				new
				///*git::*/
				nilnul.fs.folder_.git_.Top(_gitTop), 
				svrRepoName,
				git
			);

		}

	}
}

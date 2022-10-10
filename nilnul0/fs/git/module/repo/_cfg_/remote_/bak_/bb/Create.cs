using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_.git_;
using nilnul.fs.git.svr.repo;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.bb
{
	//extern alias git;

	static public class _CreateX
	{

		public static void Void(Top gitTop, fs.git.svr.repo.Name svrRepoName)
		{
			nilnul.fs.git.module.repo._cfg_.remote._CreateX.RetVoid(
				gitTop
				,
				nilnul.dev.srcs.bak_._retVoid.Settings1.Default.moduleRemoteKeysBitbucket.Cast<string>().Last()
				,

				nilnul.fs.git.svr_.wellknown_.bb.client_.cfged.repo._CreateX.GenUrl(svrRepoName)
			);


			//throw new NotImplementedException();
		}
		public static void Void(Top gitTop, string svrRepoName)
		{
			Void(gitTop, new svr.repo.Name(svrRepoName));
		}

		static public void Void(nilnul.fs.FolderI _gitTop,  string svrRepoName)
		{
			Void( new Top(_gitTop),svrRepoName);
		}

	}
}

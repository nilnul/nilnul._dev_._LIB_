using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.vs
{
	//extern alias git;
	static public class _CreateX
	{

		public static  string KEY = nilnul.dev.srcs.bak_._retVoid.Settings1.Default.moduleRemoteKeysVs.Cast<string>().FirstOrDefault()??"vs";

		static public nilnul.fs.git.module.repo._cfg_._remote.Name Key = new _remote.Name(KEY);


		static public void Void(nilnul.fs.folder_.git_.Top _gitTop, nilnul.fs.git.svr_.vs.repo.Name svrRepoName) {


			nilnul.fs.git.module.repo._cfg_.remote._CreateX.RetVoid(
				_gitTop
				,
				Key
				,
				
				nilnul.fs.git.svr_.wellknown_.vs.client_.cfged.repo._CreateX.GenUrl(svrRepoName)
			);

		}

		static public void Void(nilnul.fs.FolderI _gitTop, nilnul.fs.git.svr_.vs.repo.Name svrRepoName) {

			Void( new fs.folder_.git_.Top(_gitTop) , svrRepoName );

		}

		static public void Void(nilnul.fs.FolderI _gitTop, string repoName) {

			Void( _gitTop, new nilnul.fs.git.svr_.vs.repo.Name(repoName) );

		}
	}
}

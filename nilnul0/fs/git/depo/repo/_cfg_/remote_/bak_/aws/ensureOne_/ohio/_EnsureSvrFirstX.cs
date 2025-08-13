//#define SOME_AMAZON_REPO_NOT_CREATED
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.aws.ensureOne_.ohio
{

	static public class _EnsureSvrFirstX
	{
		public static bool NewlyCreated(
			nilnul.fs.git.ModuleI gitTop
			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,nilnul.win.prog_.Git git=null
		)
		{
			if (nilnul.fs.git.module.repo._cfg_.remote_.bak_.aws.vers._AnyX.Be(
				gitTop
			))
			{
#if SOME_AMAZON_REPO_NOT_CREATED
				///ensure on the server
				///todo: remove this
				///
				Trace.TraceInformation(
					$@"ensuring repo with newest remote; response:{
						nilnul.fs.git.module.repo._cfg_.remote_.svr_.amazon_.newest._EnsureOhioRepoX.Json(
							gitTop, git
						)
					}"
				);
#endif
				return false;
			}

			var r = nilnul.fs.git.svr_.aw_.ohio.client_.cfged.repo.create._EnsureX.Ret(
				svrRepoName
			);
			Trace.TraceInformation(
				$"creating repo with given repoName; response:{r}."
			);

			nilnul.fs.git.module.repo._cfg_.remote_.bak_.aw_.newest.create_._OhioX.Void(
				gitTop
					,
				svrRepoName
			);
			return true;
		}


		public static bool NewlyCreated(nilnul.fs.git.ModuleI gitTop, string svrRepoName, nilnul.win.prog_.Git git=null)
		{
			return NewlyCreated(gitTop , new svr.repo.Name( svrRepoName));
		}


		public static bool NewlyCreated(nilnul.fs.git.Module gitTop, nilnul.fs.git.svr.repo.Name svrRepoName)
		{
			return NewlyCreated(gitTop as nilnul.fs.git.ModuleI, svrRepoName);
		}


		public static bool NewlyCreated(nilnul.fs.folder_.git_.Top gitTop, nilnul.fs.git.svr.repo.Name svrRepoName)
		{
			return NewlyCreated(new nilnul.fs.git.Module(gitTop), svrRepoName);
		}

		public static bool NewlyCreated(nilnul.fs.folder_.git_.Top gitTop, string svrRepoName)
		{
			return NewlyCreated(gitTop, new nilnul.fs.git.svr.repo.Name(svrRepoName));
		}

		
		public static bool NewlyCreated(nilnul.fs.FolderI gitTop, string svrRepoName)
		{
			return NewlyCreated(
				new fs.folder_.git_.Top(gitTop), (svrRepoName)
			);
		}

	}
}

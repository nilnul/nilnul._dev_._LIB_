//#define SOME_VS_REPO_NOT_CREATED

using System.Diagnostics;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.vss.ensureOne
{

	public static class _EnsureSvrFirstX
	{
		public static bool NewlyCreated(
			nilnul.fs.git.ModuleI gitTop
			,
			nilnul.fs.git.svr_.vs.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git = null
		)
		{
			txt_.NameVer remoteKeyNewest = remote_.bak_.vs_.newest._NulableX.Vered(gitTop, git);

			if (remoteKeyNewest == null)
			{

				string r = nilnul.fs.git.svr_.vs_.prefixed_.cfged.client_.vaulted.repo.create_.prjDefault._EnsureX.Ret(
					svrRepoName, git
				);
				Trace.TraceInformation(
					$@"created on svr with given repoName; response:{r}"
				);
				nilnul.fs.git.module.repo._cfg_.remote_.bak_.vs_.next._CreateX.Exe(
					gitTop
						,
					svrRepoName
					, git
				);
				return true;
			}
			else
			{
#if false
				var givenRepoNameInCfg = nilnul.fs.git.module.repo._cfg_.remote_.svr_.vs_.newest._RepoNameX.Txt(
					gitTop
					, 
					new _remote.Name(
						remoteKeyNewest
					)
					,
					git
				);
				if (!nilnul.fs.git.svr_.vs.repo._name.txt.Be.Singleton.be(givenRepoNameInCfg))
				{
					Trace.TraceInformation(
						$@"repoName {givenRepoNameInCfg} of {remoteKeyNewest} for {gitTop} is not valid(might too long); recreating"
					);
					string r = nilnul.fs.git.svr_.vs_.prefixed_.cfged.client_.vaulted.repo.create_.prjDefault._EnsureX.Ret(
						svrRepoName, git
					);
					Trace.TraceInformation(
						$@"created on svr with given repoName; response:{r}"
					);
					nilnul.fs.git.module.repo._cfg_.remote_.bak_.vs_.next._CreateX.Exe(
						gitTop
							,
						svrRepoName
						, git
					);
					return true;

				}
#endif
#if SOME_VS_REPO_NOT_CREATED
				///to be deleted
				///
				Trace.TraceInformation(
					$@"{
				nilnul.fs.git.module.repo._cfg_.remote.url_.svr_.vs._EnsureSvrX.Json(
					gitTop,
					remoteKeyNewest.ToString()
					,

					git)
					}
					"
				);

#endif
				return false;

			}
			//if (nilnul.fs.git.module.repo._cfg_.remote_.bak_.vss.vers._AnyX.Be(
			//	gitTop
			//	, git
			//))
			//{
			//}


		}

		public static bool NewlyCreated(nilnul.fs.git.ModuleI gitTop, string svrRepoName, nilnul.win.prog_.Git git = null)
		{
			return NewlyCreated(gitTop, new svr.repo.Name(svrRepoName));
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

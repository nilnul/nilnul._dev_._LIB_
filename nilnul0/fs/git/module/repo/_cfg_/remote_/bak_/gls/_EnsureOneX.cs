using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.gls
{

	static public class _EnsureOneX
	{
		public static bool NewlyCreated(
			nilnul.fs.git.ModuleI gitTop
			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git = null
		)
		{
			if (nilnul.fs.git.module.repo._cfg_.remote_.bak_.gls.vers._AnyX.Be(

				gitTop, git
			))
			{
				return false;
			}

			nilnul.fs.git.module.repo._cfg_.remote_.bak_.gl_.newest._CreateX.Exe(
				gitTop
					,
				svrRepoName, git
			);
			return true;
		}

		public static bool NewlyCreated(
			nilnul.fs.git.Module gitTop
			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return NewlyCreated(gitTop as nilnul.fs.git.ModuleI, svrRepoName,git);
		}

		public static bool NewlyCreated(
			nilnul.fs.git.ModuleI gitTop
			,
			string svrRepoName
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return NewlyCreated(gitTop , new svr.repo.Name( svrRepoName),git);
		}


		public static bool NewlyCreated(
			nilnul.fs.folder_.git_.Top gitTop
			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git = null
		)
		{

			return NewlyCreated(new nilnul.fs.git.Module(gitTop),svrRepoName,git);

		}


		

		public static bool NewlyCreated(
			nilnul.fs.folder_.git_.Top gitTop
			,
			string svrRepoName
			,
			nilnul.win.prog_.Git git=null
			
		)
		{
			return NewlyCreated(gitTop, new nilnul.fs.git.svr.repo.Name(svrRepoName), git);
		}

		

		public static bool NewlyCreated(nilnul.fs.FolderI gitTop, string svrRepoName, nilnul.win.prog_.Git git=null)
		{
			return NewlyCreated(
				new fs.folder_.git_.Top(gitTop), (svrRepoName),git
			);
		}

		public static bool NewlyCreated_ofModuleAddress(string gitTop, string svrRepoName, nilnul.win.prog_.Git git=null)
		{
			return NewlyCreated(
				nilnul.fs.Folder.FroAddress(gitTop)
				,
				svrRepoName
				,
				git
			);
		}


	}
}

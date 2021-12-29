using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.vss
{

	static public class _EnsureOneX
	{
		public static string Msg(
			nilnul.fs.git.ModuleI gitTop
			,
			nilnul.fs.git.svr_.vs.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git = null
		)
		{
			if (nilnul.fs.git.module.repo._cfg_.remote_.bak_.bbs.vers._AnyX.Be(

				gitTop, git
			))
			{
				return ("already created");
			}

			nilnul.fs.git.module.repo._cfg_.remote_.bak_.vs_.newest._CreateX.Exe(
				gitTop
					,
				svrRepoName, git
			);
			return (_VsX.GetNewestKey());
		}

		public static string Msg(
			nilnul.fs.git.Module gitTop
			,
			nilnul.fs.git.svr_.vs.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return Msg(gitTop as nilnul.fs.git.ModuleI, svrRepoName,git);
		}


		public static string Msg(
			nilnul.fs.folder_.git_.Top gitTop
			,
			nilnul.fs.git.svr_.vs.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git = null
		)
		{

			return Msg(new nilnul.fs.git.Module(gitTop),svrRepoName,git);

		}


		

		public static string Msg(
			nilnul.fs.folder_.git_.Top gitTop
			,
			string svrRepoName
			,
			nilnul.win.prog_.Git git=null
			
		)
		{
			return Msg(gitTop,  nilnul.fs.git.svr_.vs.repo.Name.ByEncode(svrRepoName), git);
		}

		

		public static string Msg(nilnul.fs.FolderI gitTop, string svrRepoName, nilnul.win.prog_.Git git=null)
		{
			return Msg(
				new fs.folder_.git_.Top(gitTop), (svrRepoName),git
			);
		}

		public static string Msg_ofModuleAddress(string gitTop, string svrRepoName, nilnul.win.prog_.Git git=null)
		{
			return Msg(
				nilnul.fs.Folder.FroAddress(gitTop)
				,
				svrRepoName
				,
				git
			);
		}


	}
}

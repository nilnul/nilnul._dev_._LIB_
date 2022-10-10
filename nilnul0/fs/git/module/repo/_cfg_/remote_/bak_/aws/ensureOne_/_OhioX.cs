﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.aws.ensureOne_
{

	static public class _OhioX
	{
		public static string Msg(
			nilnul.fs.git.ModuleI gitTop
			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git = null
		)
		{
			if (nilnul.fs.git.module.repo._cfg_.remote_.bak_.aws.vers._AnyX.Be(

				gitTop, git
			))
			{
				return ("already created");
			}

			nilnul.fs.git.module.repo._cfg_.remote_.bak_.aw.create_._UsEastX1.Void(
				gitTop
					,
				svrRepoName, git
			);
			return (_AwX.GetNewestKey());
		}

		public static string Msg(
			nilnul.fs.git.Module gitTop
			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return Msg(gitTop as nilnul.fs.git.ModuleI, svrRepoName,git);
		}


		public static string Msg(
			nilnul.fs.folder_.git_.Top gitTop
			,
			nilnul.fs.git.svr.repo.Name svrRepoName
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
			return Msg(gitTop, new nilnul.fs.git.svr.repo.Name(svrRepoName), git);
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

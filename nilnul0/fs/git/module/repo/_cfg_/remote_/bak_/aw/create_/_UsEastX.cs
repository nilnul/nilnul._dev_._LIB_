using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.aw.create_
{
	////extern alias git;
	static public class _UsEastX1
	{

		static public void Void(nilnul.fs.git.ModuleI _gitTop,  nilnul.fs.git.svr.repo.Name svrRepoName,  nilnul.win.prog_.Git git = null)
		{

			nilnul.fs.git.module.repo._cfg_.remote._CreateX.RetVoid(
				_gitTop, 
				_AwX.GetNewestKey(), 
				nilnul.fs.git.svr_.aw_.ohio.repo._UrlX.Create(svrRepoName)
				, 
				git
			);
		}

		static public void Void(nilnul.fs.git.Module _gitTop,  nilnul.fs.git.svr.repo.Name svrRepoName,  nilnul.win.prog_.Git git = null)
		{
			Void( _gitTop as nilnul.fs.git.ModuleI,  svrRepoName, git);
		}

	

		static public void Void(nilnul.fs.folder_.git_.Top _gitTop,  nilnul.fs.git.svr.repo.Name svrRepoName,  nilnul.win.prog_.Git git = null)
		{
			Void( new nilnul.fs.git.Module( _gitTop),  svrRepoName, git);
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

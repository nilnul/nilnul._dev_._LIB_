using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.aw_.newest_.create_
{
	////extern alias git;
	static public class _UsEastX1
	{

		static public void Void(nilnul.fs.git.ModuleI _gitTop, nilnul.NumI num, nilnul.fs.git.svr.repo.Name svrRepoName,  nilnul.win.prog_.Git git = null)
		{
			nilnul.fs.git.module.repo._cfg_.remote._CreateX.RetVoid(
				_gitTop, 
				_AwX.GetNewestKey() + nilnul.txt.of_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty(num), 
				nilnul.fs.git.svr_.aw_.ohio.repo._UrlX.Create(svrRepoName)
				, 
				git
			);
		}

		static public void Void(nilnul.fs.git.Module _gitTop, nilnul.NumI num, nilnul.fs.git.svr.repo.Name svrRepoName,  nilnul.win.prog_.Git git = null)
		{
			Void( _gitTop as nilnul.fs.git.ModuleI, num, svrRepoName, git);
		}

	

		static public void Void(nilnul.fs.folder_.git_.Top _gitTop, nilnul.NumI num, nilnul.fs.git.svr.repo.Name svrRepoName,  nilnul.win.prog_.Git git = null)
		{
			Void( new nilnul.fs.git.Module( _gitTop),num,  svrRepoName, git);
		}


		static public void Void(nilnul.fs.folder_.git_.Top _gitTop, nilnul.NumI num, string svrRepoName,  nilnul.win.prog_.Git git = null)
		{
			Void(
				_gitTop, num,
				new svr.repo.Name( svrRepoName)
				, git);
		}

		static public void Void(nilnul.fs.FolderI _gitTop, nilnul.NumI num, string svrRepoName,  nilnul.win.prog_.Git git = null)
		{


			Void(
				new nilnul.fs.folder_.git_.Top(_gitTop), 
				num,
				svrRepoName,
				git
			);

		}

	}
}

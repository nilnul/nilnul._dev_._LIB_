using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.vs_.next
{
	//extern alias git;
	static public class _CreateX
	{
		static public void Exe(
			nilnul.fs.git.ModuleI _gitTop
			, 
			nilnul.fs.git.svr_.vs.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git=null
		) {
			nilnul.fs.git.module.repo._cfg_._remote.create_._WinTitledX.ExitCode(
				_gitTop
				,
				_NextX.Vered(_gitTop,git)
				,
				nilnul.fs.git.svr_.vs_.prefixed_.cfged.repo._UrlX.Gen(svrRepoName)
			);
		}

		static public void Exe(
			nilnul.fs.git.Module _gitTop
			, 
			nilnul.fs.git.svr_.vs.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git=null
		) {
			Exe(_gitTop as nilnul.fs.git.ModuleI, svrRepoName,git);
		}
		
	}
}
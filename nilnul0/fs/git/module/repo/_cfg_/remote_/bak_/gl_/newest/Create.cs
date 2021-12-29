using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.gl_.newest
{
	//extern alias git;
	static public class _CreateX
	{
		static public void Exe(
			nilnul.fs.git.ModuleI _gitTop
			, 
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git=null
		) {
			nilnul.fs.git.module.repo._cfg_.remote._CreateX.RetVoid(
				_gitTop
				,
				_GlX.GetNewestKey()
				,
				nilnul.fs.git.svr_.gl.client_.cfged.repo._UrlX.Gen(svrRepoName)
			);
		}

		static public void Exe(
			nilnul.fs.git.Module _gitTop
			, 
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git=null
		) {
			Exe(_gitTop as nilnul.fs.git.ModuleI, svrRepoName,git);
		}
		
	}
}
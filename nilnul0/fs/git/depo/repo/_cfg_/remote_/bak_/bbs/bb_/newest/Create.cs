using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg_.remote_.bak_.bb_.newest
{
	//extern alias git;
	static public class _CreateX
	{
		static public void Exe(
			nilnul.fs.git.ModuleI _gitTop
			, 
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.program_.Git git=null
		) {
			nilnul.fs.git.module._cfg_._remote._CreateX2.RetVoid(
				_gitTop
				,
				_BbX.GetNewestKey()
				,
				nilnul.fs.git.svr_.bb.client_.cfged.repo._UrlX.Gen(svrRepoName)
			);
		}

		static public void Exe(
			nilnul.fs.git.Module3 _gitTop
			, 
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.program_.Git git=null
		) {
			Exe(_gitTop as nilnul.fs.git.ModuleI, svrRepoName,git);
		}
		
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.gl
{
	//extern alias git;
	static public class _CreateX
	{


		static public void Exe(nilnul.fs.folder_.git_.Top _gitTop, nilnul.fs.git.svr_.gitlab.repo.Name svrRepoName) {


			nilnul.fs.git.module.repo._cfg_.remote._CreateX.RetVoid(
				_gitTop
				,
				_GlX.GetNewestKey()
				,
				
				nilnul.fs.git.svr_.wellknown_.gl.client_.cfged.repo.create_._PostWithTokenOnlyX1.GenUrl(svrRepoName)
			);

		}


		
	}
}

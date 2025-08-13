using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg_.remote_.svr_.wellknowns_.awGlBbVs
{
	static public class _EnsureX
	{
		
		static public IEnumerable<nilnul._op.result_.explain_.RetTxt> Results(string gitTop, string svrRepoName, nilnul.win.program_.Git git = null)
		{
			return Results(new fs.folder_.git_.Top(gitTop), svrRepoName, git);
		}




		static public IEnumerable<nilnul._op.result_.explain_.RetTxt> Results(nilnul.fs.folder_.git_.Top2 gitTop, string svrRepoName, nilnul.win.program_.Git git = null)
		{
			yield return remote_.bak_.vs.create._EnsureX.Result(gitTop, svrRepoName);
			yield return remote_.bak_.aw.create_.ohio._EnsureX.Result(gitTop, svrRepoName);
			yield return remote_.bak_.gl.create._EnsureX.Result(gitTop, svrRepoName);
			yield return remote_.bak_.bb.create._EnsureX.Result(gitTop, svrRepoName);
			yield return remote_.bak_.vsAwGlBb.create._EnsureX.Result(gitTop, git);

		}







	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_
{
	static public class _GlX
	{

		static public string GetNewestKey() {
			return nilnul.dev.srcs.bak_._retVoid.Settings1.Default.moduleRemoteKeysGitlab.Cast<string>().Last();
		}


		static public IEnumerable<string> GetKeys()
		{
			return nilnul.dev.srcs.bak_._retVoid.Settings1.Default.moduleRemoteKeysGitlab.Cast<string>();
		}
	}
}

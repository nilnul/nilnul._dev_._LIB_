using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.svr_
{
	static public class _VsX
	{
		static public string GetNewestKey()
		{
			return GetKeys().Last();
		}
		static public IEnumerable<string> GetKeys()
		{
			return nilnul.dev.srcs.bak_._retVoid.Settings1.Default.moduleRemoteKeysVs.Cast<string>();
		}
	}
}

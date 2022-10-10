using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln.prj.name
{
	static public class _SlnSub9TgtX
	{
		/// <summary>
		/// of the prj identity, the main without version or comment. no ext.
		/// </summary>
		/// <param name="prjIdentity"></param>
		/// <returns></returns>
		static public (string[], string) SlnSub9Tgt(string prjIdentity) {
			var r=nilnul.obj.str_.started._TorsoTipX.TorsoTip(
				prjIdentity.Split('.')
			);
			return (
				r.Item1.ToArray()
				,
				r.Item2
			);
		}


	}
}

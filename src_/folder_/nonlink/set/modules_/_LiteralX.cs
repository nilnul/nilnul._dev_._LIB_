using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src_.nonlink.set.modules_
{
	static public class _NonlinkX
	{
		

		static public IEnumerable<nilnul.fs.git.ModuleI> Seq_disregardRepo(
			nilnul.fs.folder_.nonlink.Set nonlinks
		)
		{
			return nonlinks.SelectMany( x=> src.div_.nonlink._ModulesX.Seq_disregardRepo(x) );
		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.div_.nonlink_.git_.work
{
	static public class _ModulesX
	{
		static public IEnumerable<nilnul.fs.git.ModuleI> Seq_disregardRepo(
			nilnul.fs.FolderI nonlinkWork
		)
		{
			if (nilnul.fs.folder_.git_.work.be_.Top.Singleton.be(nonlinkWork))
			{
				return work_.top._ModulesX.Seq_disregardRepo(nonlinkWork);
			}
			else
			{
				return work_.nontop._ModulesX.Seq_disregardRepo(nonlinkWork);
			}
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src_.nonlink.sln_.nonlink_.git_.work_.top
{
	static public class _ModulesX
	{
		static public IEnumerable<nilnul.fs.git.ModuleI> Seq_disregardRepo(
			nilnul.fs.FolderI sln
		)
		{
			foreach (
				var sub in nilnul.fs.folder.dirs_.excludeVs_.nonlink_._NonNegByNilNulX.Folders(sln)

			)
			{
				if (nilnul.fs.folder.be_.git_.Work.Singleton.be(sub))
				{
					foreach (var item1 in src.div_.nonlink_.git_.work._ModulesX.Seq_disregardRepo(sub))
					{
						yield return item1;

					}
				}
			}
			yield return new nilnul.fs.git.Module(sln);
		}
	}
}
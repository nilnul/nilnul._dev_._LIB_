using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.vs_.newest
{
	static public class _NulableX1
	{
		static public txt_.Vered Vered(nilnul.fs.git.ModuleI module, nilnul.win.prog_.Git git = null)
		{
			foreach (var item in _VsX.GetKeys().Reverse())
			{
				var remotes = nilnul.fs.git.module.repo._cfg_.remotes._VwX.Seq(module).Select(x => nilnul.txt_.Vered.Parse(x)).Where(
								y =>
									 y.name.en == item

				);
				var lastest = nilnul.txt_.vered.set.NewestOrDefaultX.Vered(remotes);
				if (lastest != null)
				{
					return lastest;
				}
			}
			return null;
		}


		static public txt_.Vered Vered(
			nilnul.fs.git.Module module,
			nilnul.win.prog_.Git git = null
		)
		{
			return Vered(module as nilnul.fs.git.ModuleI, git);
		}

		static public txt_.Vered Vered(
			nilnul.fs.folder_.git_.Top module,
			nilnul.win.prog_.Git git = null
		)
		{
			return Vered(new nilnul.fs.git.Module(module), git);
		}
	}
}

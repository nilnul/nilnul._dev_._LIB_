using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.vs_
{
	static public class _NextX
	{
		static public txt_.Vered Vered(nilnul.fs.git.ModuleI module, nilnul.win.prog_.Git git = null)
		{
			var newest1 = newest._NulableX.Vered(module, git);
			if (newest1 == null)
			{
				return txt_.Vered.Parse ( _VsX.GetNewestKey());
			}
			else
			{
				return txt_.vered.op_.unary_._NextX.Next(newest1);
			}
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

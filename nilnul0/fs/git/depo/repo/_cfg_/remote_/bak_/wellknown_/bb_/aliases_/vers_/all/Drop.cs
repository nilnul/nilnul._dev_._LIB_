using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.wellknown_.bb_.aliases_.vers_.all
{
	static public class _DropX
	{


		static public void Void(nilnul.fs.folder_.git_.Top top, nilnul.win.prog_.Git git = null)
		{
			Void(new Module(top),git);
		}

		public static void Void(string v)
		{
			Void(
				nilnul.fs.git.Module.FroAddress(v)
			);
		}

		public static void Void(Module module, G git=null)
		{


			foreach (var item in _BbX.GetKeys())
			{
				nilnul.fs.git.module.repo._cfg_.remote_.vered_.name._DelX.Exe(module, item, git);


			}

		}
	}
}

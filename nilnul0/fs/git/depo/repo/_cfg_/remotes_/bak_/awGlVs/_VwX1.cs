using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.txt_;


namespace nilnul.fs.git.module.repo._cfg_.remotes_.bak_.awGlVs
{
	
		static public class _VwX
		{

			static public IEnumerable<NameVer> LatestOrDefault(nilnul.fs.git.ModuleI gitTop, nilnul.win.prog_.Git git = null)
			{
			yield return nilnul.fs.git.module.repo._cfg_.remote_.bak_.aw.key._VwX1.LatestOrDefault(gitTop, git);
			yield return nilnul.fs.git.module.repo._cfg_.remote_.bak_.gl.key._VwX1.LatestOrDefault(gitTop, git);

			yield return  nilnul.fs.git.module.repo._cfg_.remote_.bak_.vs.key._VwX1.LatestOrDefault(gitTop, git);



		}

			static public IEnumerable<NameVer> LatestOrDefault(string module, nilnul.win.prog_.Git git = null)
			{
				return LatestOrDefault(nilnul.fs.git.Module.FroAddress(module), git);
			}

		}
	}

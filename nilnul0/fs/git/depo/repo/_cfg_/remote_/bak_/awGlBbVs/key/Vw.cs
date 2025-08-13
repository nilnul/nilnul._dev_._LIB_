using nilnul.txt_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.vsAwGlBb.key
{
	static public class _VwX
	{

		static public IEnumerable<NameVer> Latest(nilnul.fs.git.Module module, nilnul.win.prog_.Git git=null) {

			yield return vs.key._VwX.LatestOrDefault(module,git);

			yield return aw.key._VwX.LatestOrDefault(module,git);

			yield return bb.key._VwX.Latest(module,git);

			yield return gl.key._VwX.Latest(module,git);

		}

		static public IEnumerable<NameVer> Latest(string module, nilnul.win.prog_.Git git = null)
		{
			return Latest( Module.FroAddress(module), git);
		}

	}
}

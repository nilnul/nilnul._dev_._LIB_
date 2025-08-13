using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.txt_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remotes_.bak_.awGlBbVs
{

	[Obsolete()]
	static public class _VwX
	{

		static public IEnumerable<NameVer> Latest(nilnul.fs.git.Module module, nilnul.win.prog_.Git git = null)
		{

			yield return remote_.bak_.vs.key._VwX.LatestOrDefault(module, git);

			yield return remote_.bak_.aw.key._VwX.LatestOrDefault(module, git);

			yield return remote_.bak_.gl.key._VwX.Latest(module, git);

			yield return remote_.bak_.bb.key._VwX.Latest(module, git);

		}

		static public IEnumerable<NameVer> Latest(string module, nilnul.win.prog_.Git git = null)
		{
			return Latest(Module.FroAddress(module), git);
		}

	}
}

using NuGet.Versioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV_.pkg._identity.version.comparer
{
	[Obsolete(nameof(version.comp.Re))]
	public class Re:
		nilnul.obj.comp.re_.CompDefault<NuGetVersion, version.Comparer>
	{
		public NuGetVersion max(NuGetVersion x, NuGetVersion y) {
			return Singleton.ge(x, y) ? x : y;
		}

		static public Re Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Re>.Instance;
			}
		}

	}
}

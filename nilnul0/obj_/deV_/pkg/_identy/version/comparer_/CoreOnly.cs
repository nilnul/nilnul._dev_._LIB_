using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV_.pkg._identity.version.comparer_
{
	public class CoreOnly : IComparer<_version_.CoreI>
		,IComparer<nilnul.obj_.deV_.pkg._identity.IVersion>
	{
		public int Compare(_version_.CoreI x, _version_.CoreI y)
		{
			return _version.core.Comparer.Singleton.Compare(x.core, y.core);
			
		}

		public int Compare(IVersion x, IVersion y)
		{
			if (x is _version_.CoreI xx)
			{
				if (y is _version_.CoreI yy)
				{
					return Compare(xx, yy);
				}
			}

			throw new UnexpectedTypeException();
		}

		static public CoreOnly Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<CoreOnly>.Instance;
			}
		}

	}
}

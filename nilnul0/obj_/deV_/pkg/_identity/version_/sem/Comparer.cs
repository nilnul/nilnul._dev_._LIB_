using NuGet.Versioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV_.pkg._identity.version_.sem
{
	public class Comparer :
		IComparer<version_.Sem>
		,IComparer<SemanticVersion>
	{
		

		static public Comparer Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Comparer>.Instance;
			}
		}

		public int Compare(SemanticVersion x, SemanticVersion y)
		{
			return x.CompareTo(y);
			//throw new NotImplementedException();
		}

		public int Compare(Sem x, Sem y)
		{
			return Compare(x.boxed, y.boxed);
		}
	}
}

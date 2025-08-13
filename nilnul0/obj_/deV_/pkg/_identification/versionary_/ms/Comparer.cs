using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV_.pkg._identity.version_.ms
{
	public class Comparer :
		IComparer<Version>
		,IComparer<version_.Ms>
	{
		

		static public Comparer Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Comparer>.Instance;
			}
		}

		public int Compare(Version x, Version y)
		{
			return x.CompareTo(y);
			//throw new NotImplementedException();
		}

		public int Compare(Ms x, Ms y)
		{
			return Compare((Version)x, (Version)y);
		}
	}
}

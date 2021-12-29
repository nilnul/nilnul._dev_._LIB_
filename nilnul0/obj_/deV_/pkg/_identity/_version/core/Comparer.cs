using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV_.pkg._identity._version.core
{
	public class Comparer : IComparer<Core>
	{
		public int Compare(Core x, Core y)
		{

			return nilnul.num.str._Comparer_assumeStrOfNumX.Compare_assumeHeadeds(
				new[] {x.major,x.minor,x.patch }.Select( a=>(BigInteger)(a) )
				,
				new[] { y.major,y.minor,y.patch}.Select( a=>(BigInteger)(a) )
			)			;
		}


		static public Comparer Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Comparer>.Instance;
			}
		}

	}
}

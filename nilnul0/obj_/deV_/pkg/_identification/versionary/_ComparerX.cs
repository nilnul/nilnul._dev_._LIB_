using nilnul.obj_.deV_.pkg._identity.version_;
using NuGet.Versioning;
using System;

namespace nilnul.obj_.deV_.pkg._identity.version
{
	static public class _ComparerX
	{
		public static int Compare(Ms xx, Sem sem1)
		{

			var coreCompared = _version.core.Comparer.Singleton.Compare(xx.core, sem1.core);
			if (coreCompared==0)
			{
				if ( sem1.pre is null || sem1.pre=="" )
				{
					return 0;
				}
				return 1;
			}
			return coreCompared;

		}
		public static int Compare( Sem sem1, Ms xx)
		{
			return -Compare(xx, sem1);
		}

		public static int Compare(Sem sem22, IVersion y)
		{
			if (y is version_.Ms ms)
			{
				return Compare(sem22, ms);

			}
			if (y is version_.Sem sem33)
			{
				return version_.sem.Comparer.Singleton.Compare(sem22, sem33);
			}

			throw new NotImplementedException();
		}
	





		static public int Compare(Ms xx, IVersion y)
		{

			if (y is version_.Ms ms)
			{
				return version_.ms.Comparer.Singleton.Compare(xx, ms);

			}
			if (y is version_.Sem sem33)
			{
				return Compare(xx, sem33);
			}

			throw new NotImplementedException();

			;
		}
	}
}

using nilnul.obj_.deV_.pkg._identity.version_;
using NuGet.Versioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV_.pkg._identity.version
{
	/// <summary>
	/// <see cref="nameof(NuGet.Versioning.VersionComparer)"/>
	/// </summary>
	public interface IComparer {

	}
	public interface ComparerI :IComparer<nilnul.obj_.deV_.pkg._identity.IVersion>
		{

	}

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
	public class Comparer : IComparer<_version_.CoreI>
		,IComparer<nilnul.obj_.deV_.pkg._identity.IVersion>
		,
		IComparer<SemanticVersion>
		,
		IComparer<nilnul.obj_.deV_.pkg._identity.VersionA>

	{

		public int Compare(_version_.CoreI x, _version_.CoreI y)
		{
			return _version.core.Comparer.Singleton.Compare(x.core, y.core);
			
		}

		public int Compare(IVersion x, IVersion y)
		{
			if (x is version_.Ms xx)
			{
				return _ComparerX.Compare(xx, y);

			}
			if (x is version_.Sem sem22)
			{
				return _ComparerX.Compare(sem22, y);
			}

			throw new UnexpectedTypeException();
		}

		public int Compare(SemanticVersion x, SemanticVersion y)
		{
			return x.CompareTo(y);
		}

		public int Compare(VersionA x, VersionA y)
		{

			if (x is version_.Ms xx)
			{
				return _ComparerX.Compare(xx, y);

			}
			if (x is version_.Sem sem22)
			{
				return _ComparerX.Compare(sem22, y);
			}

			throw new UnexpectedTypeException();

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

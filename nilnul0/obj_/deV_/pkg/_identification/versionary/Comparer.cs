using NuGet.Versioning;
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

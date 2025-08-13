using System;

namespace nilnul.obj_.deV_.pkg._identity
{
	/// <summary>
	/// define some operators which cannot be done on subtype for super type
	/// </summary>
	public abstract class VersionA : IVersion
	{

		static public bool operator <(VersionA x, VersionA b)
		{

			return version.Comparer.Singleton.Compare(x, b) < 0;

		}
		static public bool operator <=(VersionA x, VersionA b)
		{

			return version.Comparer.Singleton.Compare(x, b) <= 0;

		}


		static public bool operator >=(VersionA x, VersionA b)
		{

			return b <= x;

		}
		static public bool operator >=(VersionA x, Version b)
		{

			return x >= (new version_.Ms(b) as VersionA);

		}

		static public bool operator <=(VersionA x, Version b)
		{

			return x <= (new version_.Ms(b) as VersionA);

		}

		static public bool operator >(VersionA x, VersionA b)
		{
			return b < x;
		}



		static public bool operator ==(VersionA x, VersionA b)
		{
			return version.Comparer.Singleton.Compare(x, b) == 0;
		}

		static public bool operator ==(VersionA x, version_.Ms b)
		{
			return x == (VersionA)(b);
		}
		static public bool operator !=(VersionA x, version_.Ms b)
		{
			return !(x == b);
		}

		static public bool operator ==(VersionA x, Version b)
		{
			return x == new version_.Ms(b);
		}

		static public bool operator !=(VersionA x, Version b)
		{
			return !(x == b);
		}
		static public bool operator ==(Version x, VersionA b)
		{
			return b == x;
		}
		static public bool operator !=(Version x, VersionA b)
		{
			return !(x == b);
		}



		static public bool operator !=(VersionA x, VersionA b)
		{
			return !(x == b);
		}


	}

}

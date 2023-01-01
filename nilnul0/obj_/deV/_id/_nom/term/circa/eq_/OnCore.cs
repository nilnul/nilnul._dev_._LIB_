using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._id.nom_.idiom.circa.eq_
{

	public class _Core :
		nilnul.obj.Box1<IEqualityComparer<string>>
		,
		IEqualityComparer<string>


	{
		public _Core(IEqualityComparer<string> val) : base(val)
		{
		}

		public bool Equals(string x, string y)
		{
			return boxed.Equals(
				_CoreX.Core(x)
				,
				_CoreX.Core(y)
			);
			throw new NotImplementedException();
		}

		public int GetHashCode(string obj)
		{
			return boxed.GetHashCode( _CoreX.Core(obj));
			throw new NotImplementedException();
		}
	}
	/// <summary>
	/// 
	/// </summary>
	public class Core : IEqualityComparer<string>
	{
		public bool Equals(string x, string y)
		{
			return circa._CoreX.Core(x) ==circa._CoreX.Core(y) ;
		}

		public int GetHashCode(string obj)
		{
			return circa._CoreX.Core(obj).GetHashCode();
		}
	}
}

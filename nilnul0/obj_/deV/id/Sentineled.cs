using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._id._nom.idiom
{
	/// <summary>
	/// idiom followed by "."
	/// </summary>
	public class Sentineled : nilnul.obj.Box1<_id._nom.IIdiom>
	{
		public Sentineled(IIdiom val) : base(val)
		{
		}

		public override string ToString()
		{
			return $"{boxed}.";
		}
	}
}

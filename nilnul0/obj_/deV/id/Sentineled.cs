using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV.id
{
	/// <summary>
	/// idiom followed by "."
	/// </summary>
	public class Sentineled : nilnul.obj.Box1<IId>
	{
		public Sentineled(IId val) : base(val)
		{
		}

		public override string ToString()
		{
			return $"{boxed}.";
		}
	}
}

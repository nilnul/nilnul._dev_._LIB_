using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._id._nom._idiom.casible.cased_
{
	public class Lower
		: Boxed
	{
		public Lower(ICasible val) : base(val)
		{
		}
		public override string ToString()
		{
			return boxed.ToString().ToLower();
		}
	}
}

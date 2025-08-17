using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.raw.prj_.cs
{
	public interface BeI: nilnul.obj.BeI1<dev.raw.prj_.Cs>
	{
	}
	public class Be : nilnul.obj.Be1<dev.raw.prj_.Cs>
		,BeI
	{
		public Be(Func<Cs, bool> func) : base(func)
		{
		}

		public Be(Predicate<Cs> predicate) : base(predicate)
		{
		}
	}
}

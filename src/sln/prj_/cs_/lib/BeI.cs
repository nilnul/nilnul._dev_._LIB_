using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj_.cs_.lib
{
	public interface BeI: nilnul.obj.BeI1<dev.src.prj_.cs_.Lib>
	{
	}
	public class Be : nilnul.obj.Be1<dev.src.prj_.cs_.Lib>
		,BeI
	{
		public Be(Func<Lib, bool> func) : base(func)
		{
		}

		public Be(Predicate<Lib> predicate) : base(predicate)
		{
		}
	}
}

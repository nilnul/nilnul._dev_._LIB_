using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj_.cs_.lib.be
{
	public class Vow
		:
		nilnul.obj.be.Vow4<nilnul.dev.src.prj_.cs_.Lib>
	{
		public Vow(BeI1<Lib> be) : base(be)
		{
		}

		public Vow(Predicate<Lib> predicate) : base(predicate)
		{
		}

		public Vow(Func<Lib, bool> func) : base(func)
		{
		}
	}
}

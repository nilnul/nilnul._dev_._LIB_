using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj_.cs.be
{
	public class Vow
		:
		nilnul.obj.be.Vow4<nilnul.dev.src.prj_.Cs>
	{
		public Vow(BeI1<Cs> be) : base(be)
		{
		}

		public Vow(Predicate<Cs> predicate) : base(predicate)
		{
		}

		public Vow(Func<Cs, bool> func) : base(func)
		{
		}
	}
}

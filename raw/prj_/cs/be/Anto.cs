using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.raw.prj_.cs.be
{
	public class Anto : nilnul.obj.be.Anto<nilnul.dev.raw.prj_.Cs>
		,
		nilnul.dev.raw.prj_.cs.BeI
	{
		public Anto(nilnul.obj.BeI1<Cs> be) : base(be)
		{
		}
	}
}

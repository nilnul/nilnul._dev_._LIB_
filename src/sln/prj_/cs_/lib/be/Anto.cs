using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj_.cs_.lib.be
{
	public class Anto : nilnul.obj.be.Anto<nilnul.dev.src.prj_.cs_.Lib>
		,
		nilnul.dev.src.prj_.cs_.lib.BeI
	{
		public Anto(nilnul.obj.BeI1<Lib> be) : base(be)
		{
		}
	}
}

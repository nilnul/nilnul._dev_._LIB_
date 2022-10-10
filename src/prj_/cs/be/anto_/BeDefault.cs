using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj_.cs.be.anto_
{
	public class BeDefault<TBe> : cs.be.Anto
		where TBe : nilnul.obj.BeI1<prj_.Cs>, new()
	{
		public BeDefault() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}
	}
}

using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj_.cs.vow.ee_
{
	public class VowDefault<TVow> : Ee
		where TVow: nilnul.obj.VowI2<dev.src.prj_.Cs>,new()
	{
		public VowDefault(Cs val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}

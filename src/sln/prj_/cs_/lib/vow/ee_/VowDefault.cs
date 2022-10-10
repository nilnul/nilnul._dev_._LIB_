using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj_.cs_.lib.vow.ee_
{
	public class VowDefault<TVow> : Ee
		where TVow: nilnul.obj.VowI2<dev.src.prj_.cs_.Lib>,new()
	{
		public VowDefault(Lib val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}

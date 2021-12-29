using nilnul.fs.address_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file_.ext_.deV_
{
	public class Csproj : nilnul.fs.file_.Ext
	{
		public const string EXT = ".csproj";
		public Csproj(FileI val) : base(val, EXT)
		{
		}

		public Csproj(string spear):this( new nilnul.fs.File(spear))
		{
		}

		public Csproj(SpearI spear):this( new nilnul.fs.File(spear) )
		{
		}
	}
}

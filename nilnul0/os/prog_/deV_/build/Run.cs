using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.win.prog_.deV_.build
{
	public class Run
		: nilnul.win.prog.Run1
	{
		

		public Run() : base(
			MsBuild.Defaulted
		)
		{
		}




		static public Run Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Run>.Instance;
			}
		}

	}
}

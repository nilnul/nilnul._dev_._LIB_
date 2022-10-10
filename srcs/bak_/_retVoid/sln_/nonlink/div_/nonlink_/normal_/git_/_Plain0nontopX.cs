using nilnul.dev;
using nilnul.dev.srcs._bak;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.sln.div_.git_
{
	static public class _Plain0nontopX
	{
		public static void _Exe(
			string folder,
			CancellationToken cancel,
			nilnul.win.program_.Git git = null
		)
		{
			try
			{
				if (
					nilnul.dev.srcs.bak_._retVoid.SettingX.IsBaked(folder)
				)
				{
					Trace.TraceInformation($" {folder} already done last time");
				}
				else
				{
					plain0nontop_._UndoneX._Exe(folder, cancel, git);

				}

			}
			catch (Exception e)
			{
				Trace.TraceError($"exception when baking {folder}:{e}");
			}

		}



	}
}

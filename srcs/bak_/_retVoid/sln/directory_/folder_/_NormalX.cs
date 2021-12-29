using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.dev.srcs._bak;
using nilnul.win.program_;

namespace nilnul.dev.srcs.bak_._retVoid.sln.directory_.folder_
{
	static public class _NormalX
	{

		public static void Exe(
			nilnul.fs.address_.shields_.Disjoint1 srcs,
			nilnul.fs.address_.ShieldI1 _shield
			,
			CancellationToken cancel,
			win.program_.Git git = null
		)
		{
			if (nilnul.dev.srcs.bak_._retVoid.SettingX.IsBaked(_shield.ToString()))
			{
				Trace.TraceInformation($"normal folder {srcs} is already baked");

			}
			else
			{
				Trace.TraceInformation($"normal folder {srcs} is being baked");

				normal_._UndoneX.Exe(srcs, _shield, cancel, git);

			}

		}
	}
}

﻿using nilnul.dev.srcs._bak;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.sln_
{
	/// <summary>
	/// </summary>
	static public class _Nonlink_byDoneOrNotX
	{



		public static void _Exe(string folder, /*Log1 log,*/ CancellationToken cancel, nilnul.win.prog_.Git git = null)
		{
			try
			{
				if (nilnul.dev.srcs.bak_._retVoid.SettingX.IsSlnBaked(folder))
				{
					Trace.TraceInformation($"sln_.folder_.normal: {folder} has been baked.");

				}
				else
				{
					nonlink_._GitX._Exe(folder, cancel, git);

				}

			}
			catch (Exception e)
			{
				Trace.TraceError($"exception in baking {folder}:{e}");
			}

		}
	}
}
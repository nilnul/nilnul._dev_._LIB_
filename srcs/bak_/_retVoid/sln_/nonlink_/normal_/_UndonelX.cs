﻿using nilnul.dev.srcs._bak;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.sln_.folder_.normal_
{
	/// <summary>
	/// </summary>
	static public class _UndoneX
	{
		public static void _Exe(string folder,  CancellationToken cancel, nilnul.win.program_.Git git = null)
		{
			switch (nilnul.fs.folder.categorize_.git_.PlainWorkRepo1.Category_ofAddress(folder))
			{
				case nilnul.fs.folder.categorize_.git_._plainWorkRepo.Ret.Plain:
					 sln_.plain_._IntendGitX._Exe(folder, cancel, git);
					break;

				case nilnul.fs.folder.categorize_.git_._plainWorkRepo.Ret.Work://must be top since src is plain
					 sln_._WorkX.__Exe(   nilnul.fs.folder_.git_.Work1.FroAddress( folder).ToString(), cancel, git);
					break;

				case nilnul.fs.folder.categorize_.git_._plainWorkRepo.Ret.Repo:
					Trace.TraceError($"sln {folder} shall not be repo");
					break;

				default:
					Trace.TraceError($"sln {folder}:unknown git.folder.Category");
					break;
					//throw new UnexpectedReachException("unknown git.folder.Category");

			}

			nilnul.dev.srcs.bak_._retVoid.SettingX.shieldsNewlyBaked.Add(folder);
			

		}
	}
}
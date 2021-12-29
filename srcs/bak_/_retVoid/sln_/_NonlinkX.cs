using nilnul.dev.srcs._bak;
using nilnul.fs;
using nilnul.win.program_;
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
	static public class _NonlinkX
	{
		public static void Exe(string folder, CancellationToken cancel, nilnul.win.prog_.Git git = null)
		{
			Task.Factory.StartNew(
				() =>
				{
					_Exe(folder,cancel,git);
				}
				,
				cancel
				,
				TaskCreationOptions.AttachedToParent
				, TaskScheduler.Current //TaskScheduler

			).ContinueWith(
				(t) =>
				{
					_retVoid.SettingX.shieldsNewlyBaked.Add(folder);
					Trace.TraceInformation($@"baked {typeof(_NonlinkX).FullName}:{folder}.");
				}
				,cancel //bubbel up
				,
				TaskContinuationOptions.OnlyOnRanToCompletion 
				| TaskContinuationOptions.ExecuteSynchronously
				| TaskContinuationOptions.AttachedToParent
				,
				TaskScheduler.Current/*where ExecuteSynchronously continuations won’t run synchronously is when the target scheduler doesn’t allow it.  A TaskScheduler has the ability to say whether tasks are able to run on the current thread or not.  */

			);
		}

		public static void _Exe(string folder,  CancellationToken cancel, nilnul.win.prog_.Git git = null)
		{



			switch (nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category_ofAddress(folder))
			{
				case nilnul.fs.folder.categorize_.git_._plainWorkRepo.Ret.Plain:
					 sln_.nonlink_.git_.plain_._IntendGitX._Exe(folder, cancel, git);
					break;

				case nilnul.fs.folder.categorize_.git_._plainWorkRepo.Ret.Work://must be top since src is plain
					 sln_.nonlink_.git_._WorkX._Exe(   nilnul.fs.folder_.git_.Work.FroAddress( folder), cancel, git);
					break;

				case nilnul.fs.folder.categorize_.git_._plainWorkRepo.Ret.Repo:
					Trace.TraceError($"sln {folder} shall not be (bare) repo");
					break;

				default:
					Trace.TraceError($"sln {folder}:unknown git.folder.Category");
					break;
					//throw new UnexpectedReachException("unknown git.folder.Category");

			}

			//nilnul.dev.srcs.bak_._retVoid.SettingX.shieldsNewlyBaked.Add(folder);
			

		}



		public static void _Exe(FolderI folder, CancellationToken cancel, win.prog_.Git git)
		{
			_Exe(folder.ToString(),cancel, git);
		}
	}
}
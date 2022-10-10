using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.src_.folder_.nonlink_.git_.nonRepo_.incomplete
{
	public static class _TaskX
	{
		/// <summary>
		/// return newly 
		/// </summary>
		/// <param name="folder"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>
		/// <returns>newly baked</returns>
		public static Task Task(
			nilnul.fs.FolderI3 folder,
			CancellationToken cancel,
			nilnul.win.program_.Git git = null)
		{
			return System.Threading.Tasks.Task.Factory.StartNew(
				() =>
				{
					nonRepo_._IncompleteX.Exe(folder, cancel, git);
				}
				,
				cancel
				,
				TaskCreationOptions.AttachedToParent
				,
				TaskScheduler.Current //TaskScheduler
			).ContinueWith(
				(t) =>
				{
					_retVoid.SettingX.shieldsNewlyBaked.Add(folder.address.ToString());
				}
				,
				TaskContinuationOptions.OnlyOnRanToCompletion | TaskContinuationOptions.ExecuteSynchronously | TaskContinuationOptions.AttachedToParent

			);
		}

		public static Task Task(
			string folder,
			CancellationToken cancel,
			nilnul.win.program_.Git git = null
		)
		{
			return Task(nilnul.fs.Folder2.FroAddress(folder), cancel, git);
		}
		[Obsolete()]
		public static Task Task(
			nilnul.fs.FolderI1 folder,
			CancellationToken cancel,
			nilnul.win.program_.Git git = null)
		{

			return Task(folder.ToString(),cancel,git);
		}

	}
}

using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.sln_.nonlink.div_.nonlink_.git_.work_.top_.incomplete_
{
	/// <summary>
	/// </summary>
	public static class _ModuleUndoneX
	{
		/// <summary>
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_location"></param>
		/// <param name="log"></param>
		/// <param name="err"></param>
		/// <remarks>
		/// </remarks>
		/// <returns>
		/// newly processed
		/// </returns>

		public static void _Exe(
			string folder,
			/*srcs._bak.Io log,*/ CancellationToken cancel,
			nilnul.win.prog_.Git git = null
		)
		{
			Trace.TraceInformation($"in {typeof(_ModuleUndoneX).FullName} {nameof(_Exe)}  for {folder} ");

			Task.Factory.StartNew(
				() =>
				{
					cancel.ThrowIfCancellationRequested();
					_incomplete_.inners.task._WaitX._Void(folder, cancel, git);
					cancel.ThrowIfCancellationRequested();
					_incomplete_.container_._UndoneX._Exe(folder, cancel, git);


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
				}
				,
				TaskContinuationOptions.OnlyOnRanToCompletion | TaskContinuationOptions.ExecuteSynchronously

			);



		}
	}
}

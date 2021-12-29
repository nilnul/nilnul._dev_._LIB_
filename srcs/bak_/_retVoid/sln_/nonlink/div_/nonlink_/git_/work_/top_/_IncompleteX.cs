using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.sln_.nonlink.div_.nonlink_.git_.work_.top_
{
	/// <summary>
	/// </summary>
	public static class _IncompleteX
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
			Trace.TraceInformation($"in {typeof(_IncompleteX).FullName} {nameof(_Exe)}  for {folder} ");
			
			cancel.ThrowIfCancellationRequested();


			/*When the parent cancels
If a parent cancels itself before its child task is started, the child never starts. If a parent cancels itself after its child task has already started, the child runs to completion unless it has its own cancellation logic. For more information, see Task Cancellation.*/

			Task.Factory.StartNew(
				() =>
				{
					_incomplete_.inners.task._WaitX._Void(folder, cancel, git);
					cancel.ThrowIfCancellationRequested();
					_incomplete_._ContainerX._Exe(folder, cancel, git);
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
					Trace.TraceInformation($@"baked {typeof(_IncompleteX).FullName}:{folder}.");
				}
				,
				TaskContinuationOptions.OnlyOnRanToCompletion | TaskContinuationOptions.ExecuteSynchronously | TaskContinuationOptions.AttachedToParent

			);/*Because the task executes synchronously, there is no need to call a method such as Wait() to ensure that the calling thread waits for the task to complete.
			Note: you don't need to call Wait inside the continueWith; but you still need to Wait for the whole task (the antecedent together with ContinueWith) outside ContinueWith
			 */

			//Trace.Unindent();



			


		}
	}
}

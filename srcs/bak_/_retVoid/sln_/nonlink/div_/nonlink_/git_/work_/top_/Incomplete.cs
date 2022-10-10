using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.sln_.nonlink.div_.nonlink_.git_.work_.top_
{
	/// <summary>
	/// spawn all the subtasks. and when all done, save the status.
	/// </summary>
	public class Incomplete
	{

		private string _top;

		public string top
		{
			get => _top;
			set => _top = value;
		}

		private CancellationToken _cancel;

		public CancellationToken cancel
		{
			get => _cancel;
			set => _cancel = value;
		}

		private nilnul.win.program_.Git _git;

		public nilnul.win.program_.Git git
		{
			get => _git;
			set => _git = value;
		}

		/// <summary>
		/// 
		/// </summary>
		/// 
		/*When the parent cancels
If a parent cancels itself before its child task is started, the child never starts. If a parent cancels itself after its child task has already started, the child runs to completion unless it has its own cancellation logic. For more information, see Task Cancellation.*/
		public void bak()
		{

			Trace.TraceInformation($"in {typeof(_IncompleteX).FullName} {nameof(Incomplete.bak)}  for {_top} ");
			cancel.ThrowIfCancellationRequested();

			Task parent = System.Threading.Tasks.Task.Factory.StartNew(
				() =>
				{
					Trace.TraceInformation("Parent task executing.");

					//Task child = Task.Factory.StartNew(
					//	() =>
					//	{
					//Trace.TraceInformation("Attached child starting.");

					bool noErr = _incomplete_._InnerModulesX._Exe(_top, cancel, git);

					cancel.ThrowIfCancellationRequested();

					_incomplete_._ContainerX._Exe(_top, cancel, git);

					//Thread.SpinWait(5000000);
					//Trace.TraceInformation("Attached child completing.");
					//	}
					//	,
					//	TaskCreationOptions.AttachedToParent
					//);

				}
				,
				cancel
				, TaskCreationOptions.AttachedToParent
				, null
			).ContinueWith(
				(t) =>
				{
					_retVoid.SettingX.shieldsNewlyBaked.Add(_top);
				}
				,
				TaskContinuationOptions.OnlyOnRanToCompletion | TaskContinuationOptions.ExecuteSynchronously
				
			);/*Because the task executes synchronously, there is no need to call a method such as Wait() to ensure that the calling thread waits for the task to complete.
			Note: you don't need to call Wait inside the continueWith; but you still need to Wait for the whole task (the antecedent together with ContinueWith) outside ContinueWith
			 */




			Trace.TraceInformation($@"baked {typeof(Incomplete).FullName}:{_top}.");

		}

	}
}

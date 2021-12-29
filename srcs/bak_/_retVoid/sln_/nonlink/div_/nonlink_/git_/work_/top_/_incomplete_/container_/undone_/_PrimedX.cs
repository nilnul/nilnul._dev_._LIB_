#define BAK_SERIAL0
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.sln_.nonlink.div_.nonlink_.git_.work_.top_._incomplete_.container_.undone_
{
	/// <summary>
	/// </summary>
	public static class _PrimedX
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
			 CancellationToken cancel,
			nilnul.win.prog_.Git git = null
		)
		{

			try
			{
				Task t_1 = System.Threading.Tasks.Task.Factory.StartNew(
					() =>
					{
						Trace.TraceInformation($"Task  {Task.CurrentId}(module: {folder}) waiting for semaphore(count:{bak_._RetVoidX.Semaphore.CurrentCount})");


						int prev;
						bak_._RetVoidX.Semaphore.Wait(cancel);  //cancel
						try
						{
							Trace.TraceInformation($"Task  {Task.CurrentId}(module: {folder}) enters the semaphore(count:{bak_._RetVoidX.Semaphore.CurrentCount})");

							bool noErr = _primed_._UploadX._Void(folder, cancel, git);
						}
						finally
						{
							prev = bak_._RetVoidX.Semaphore.Release();
						}

						Trace.TraceInformation(
							$"Task {Task.CurrentId}(module:{folder}) releases the semaphore; previous count: {prev}; currentCount:{bak_._RetVoidX.Semaphore.CurrentCount}."
						);
					}
					,
					cancel
					,
					TaskCreationOptions.AttachedToParent
					,
					TaskScheduler.Current
				);

				//var t = Task.Run(
				/*

				 Task Status
The Task class provides a life cycle for asynchronous operations, and that cycle is represented by the TaskStatus enumeration. To support corner cases of types that derive from Task and Task<TResult>, and to support the separation of construction from scheduling, the Task class exposes a Start method. Tasks that are created by the public Task constructors are referred to as cold tasks, because they begin their life cycle in the non-scheduled Created state and are scheduled only when Start is called on these instances.

All other tasks begin their life cycle in a hot state, which means that the asynchronous operations they represent have already been initiated and their task status is an enumeration value other than TaskStatus.Created. All tasks that are returned from TAP methods must be activated. If a TAP method internally uses a task’s constructor to instantiate the task to be returned, the TAP method must call Start on the Task object before returning it. Consumers of a TAP method may safely assume that the returned task is active and should not try to call Start on any Task that is returned from a TAP method. Calling Start on an active task results in an InvalidOperationException exception.
https://docs.microsoft.com/en-us/dotnet/standard/asynchronous-programming-patterns/task-based-asynchronous-pattern-tap#Anchor_4

				 * 
				 * Calling an async method returns a hot task, a task that has already been started. So there is no actual code necessary to force it to run.

According MSDN (thanks to Stephen Cleary) the Task-based Asynchronous Pattern (TAP) pattern requires returned tasks to be hot. That means that all tasks, except those created with new Task will be hot.

From the referenced article:

Tasks that are created by the public Task constructors are referred to as cold tasks... All other tasks begin their life cycle in a hot state.*/



				//);



				//bak_._RetVoidX.Tasks.Add(
				//	t

				//);



				;
			}
			finally
			{
			}

			//Trace.Unindent();
			Trace.TraceInformation($@"baked {typeof(_PrimedX).FullName}:{folder}");
		}
	}
}

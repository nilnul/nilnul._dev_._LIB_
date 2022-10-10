using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_
{
	public static class _RetVoidX
	{
		/// <summary>
		/// the available resources
		/// </summary>
		private const int initialResources = 1;

		/// <summary>
		/// for error margin
		/// </summary>
		private const int preoccupied_resources = 0;

		/// <summary>
		/// total resources = available resources + occupiedResources
		/// </summary>
		private const int maxResources = initialResources + preoccupied_resources;

		[Obsolete()]
		internal static SemaphoreSlim Semaphore = new SemaphoreSlim(initialResources, maxResources);

		//static public nilnul._app_.threads.scheduler_.LimitedConcurrencyLevelTaskScheduler scheduler = new _app_.threads.scheduler_.LimitedConcurrencyLevelTaskScheduler(maxResources);
		
		/// <summary>
		/// 
		/// </summary>
		//public static System.Collections.Generic.SynchronizedCollection<Task> Tasks = new SynchronizedCollection<Task>();//SynchronizedList exists only in .net4.7? or we need to add /*Assemblies:		System.ServiceModel.dll, System.ServiceModel.Primitives.dll*/



		public static void Exe(IEnumerable<string> shieldsInAddresses, CancellationToken cancel, nilnul.win.prog_.Git git = null)
		{
			string shieldsTxt = nilnul.fs.address.str._PhraseX.Phrase(shieldsInAddresses);

			Trace.TraceInformation($"begin baking srcs:{shieldsTxt}...");

			try
			{

				/*Its CreationOptions property value is TaskCreationOptions.DenyChildAttach.*/
				System.Threading.Tasks.Task.Factory.StartNew(
					() => {
						nilnul.dev.srcs.bak_._retVoid._ShieldsX.Exe(shieldsInAddresses, cancel, git);
					}
					,
					cancel
					,
					TaskCreationOptions.AttachedToParent// don't use: | TaskCreationOptions.DenyChildAttach
					,
					TaskScheduler.Current //https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskfactory.scheduler?view=netframework-4.7.2 If this property value is null, the value of the Current property is used..
				).Wait(
					/*cancel*/
				);


				//WaitAll(cancel);
			}
			catch (AggregateException e)//the exceptions, including custom ones, of tasks, are all wrapped here.
			{
				//e.Flatten().Handle(x => {

				//}
				
				//);
				foreach (Exception v in e.Flatten().InnerExceptions)
				{
					if (v is TaskCanceledException)
					{
						Trace.TraceInformation("   TaskCanceledException: Task {0}",
										  ((TaskCanceledException)v).Task.Id);
					}
					else
					{
						Trace.TraceError($"exception when processing srcs: {shieldsTxt}: {e}");
					}
				}


			}
			catch (Exception e)
			{
				Trace.TraceError($"exception when processing srcs: {shieldsTxt}: {e}");
			}
			Trace.TraceInformation($"end baking shields:{shieldsTxt}");

			Trace.TraceInformation($"saving settings:{shieldsTxt}");

			nilnul.dev.srcs.bak_._retVoid.SettingX.Save();

			Trace.TraceInformation($"saved settings:{shieldsTxt}");

		}

		//public static void WaitAll(CancellationToken cancel)
		//{
		//	Task.WaitAll(Tasks.ToArray(), cancel);  ///aggrate exception will be given

		//}
		public static void Exe(IEnumerable<string> shieldsInAddresses)
		{
			Exe(shieldsInAddresses, CancellationToken.None);

		}

	}
}

using nilnul.obj;
using NuGet.Common;
using NuGet.Configuration;
using NuGet.Frameworks;
using NuGet.Packaging.Core;
using NuGet.Versioning;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj_.cs.pres_.raw._closure
{
	/// <summary>
	/// only nilnul pacS are listed.
	/// 
	/// </summary>
	/// <remarks>
	/// some methods are Sync as:
	///		when find a depCandidateInfo with float version, we need to find the minimum available version (X) on the server. And with that version, we insert the dep entry into the net. and only from this point on can we proceed with the (X).  The process of this paragraph can be async.
	///		Other methods not in the above process spanning around the recursion cannot be asyn
	/// </remarks>
	static public class _AsynX
	{
		static object localLock = new object();



		public static async Task Asyn_assumeIdenty(
			string prjIdentity
			,
			Srcs_addresses svrRepoS
			,
			ConcurrentQueue<string> started

			,
			ConcurrentQueue<(string, string)> deps
		)
		{
			///consider renaming of prjIdentity
			///


			lock (localLock)
			{

				if (!started.Contains(prjIdentity))
				{
					started.Enqueue(prjIdentity);
				}
				else
				{
					return;
				}

			}

			var prjMeta = nilnul.dev.src.sln.sub.synd.prj_.cs._meta._LocateX.SpearNulable_ofMain(

				prjIdentity
			);


			var refs = pres_._RawX.Identities_assumeCsPrj(prjMeta);
			refs.Each(
				r =>
				deps.Enqueue(
					(prjIdentity, r)
				)
			);

			Parallel.ForEach(
				refs
				,
				dependency =>
				{

					Asyn_assumeIdenty(
					   dependency,

					   svrRepoS
					   ,
					   started
					   ,
					   deps

				   ).Wait();
				}
			);
		}

		public static async Task Asyn(
			nilnul.fs.address_.spear_.ParentDoc file
			//,
			//string prjIdentity
			,
			Srcs_addresses svrRepoS
			,
			ConcurrentQueue<string> started

			,
			ConcurrentQueue<(string, string)> deps
		)
		{
			///consider renaming of prjIdentity
			///

			var prjIdentity = nilnul.dev.src.prj.asDoc.main._NominaX.NominaAsTxt(file);
			lock (localLock)
			{

				if (!started.Contains(prjIdentity))
				{
					started.Enqueue(prjIdentity);
				}
				else
				{
					return;
				}

			}



			var refs = pres_._RawX.Identities_assumeCsPrj((fs.address_.SpearI)file);
			refs.Each(
				r =>
				deps.Enqueue(
					(prjIdentity, r)
				)
			);

			Parallel.ForEach(
				refs
				,
				dependency =>
				{

					Asyn_assumeIdenty(
					   dependency,

					   svrRepoS
					   ,
					   started
					   ,
					   deps

				   ).Wait();
				}
			);
		}

		public static async Task Asyn1(
			nilnul.fs.address_.spear_.ParentDoc file
			,
			Srcs_addresses svrRepoS
			,
			ConcurrentQueue<string> started

			,
			ConcurrentQueue<(string, string)> deps
		)
		{
			///consider renaming of prjIdentity
			///

			var prjIdentity = nilnul.dev.src.prj.asDoc.main._NominaX.NominaAsTxt(file);
			lock (localLock)
			{

				if (!started.Contains(prjIdentity))
				{
					started.Enqueue(prjIdentity);
				}
				else
				{
					return;
				}

			}



			var refs = pres_._RawX.BasedDocS_fileAssumeCsPrj(file.ToString());

			refs.Each(
				r =>
				deps.Enqueue(
					(prjIdentity, r.doc.ToString())
				)
			);

			Parallel.ForEach(
				refs
				,
				dependency =>
				{

					Asyn1(
					   dependency,

					   svrRepoS
					   ,
					   started
					   ,
					   deps

				   ).Wait();
				}
			);
		}
		public static async Task Asyn_assumePrj(
			string file
			//,
			//string prjIdentity
			,
			Srcs_addresses svrRepoS
			,
			ConcurrentQueue<string> started

			,
			ConcurrentQueue<(string, string)> deps
		)
		{
			await Asyn(
				nilnul.fs.address_.spear_.ParentDoc.Parse(file)
				,
				svrRepoS
				,
				started
				,
				deps
			);
		}


		public static async Task Asyn_assumePrj1(
			string file
			//,
			//string prjIdentity
			,
			Srcs_addresses svrRepoS
			,
			ConcurrentQueue<string> started

			,
			ConcurrentQueue<(string, string)> deps
		)
		{
			await Asyn1(
				nilnul.fs.address_.spear_.ParentDoc.Parse(file)
				,
				svrRepoS
				,
				started
				,
				deps
			);
		}


		

	}
}

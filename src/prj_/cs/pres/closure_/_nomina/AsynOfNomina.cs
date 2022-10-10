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

namespace nilnul.dev.src.prj_.cs.pres.closure_._nomina
{
	/// <summary>
	/// only nomina. no version is taken into account.
	/// </summary>
	/// <remarks>
	/// some methods are Sync as:
	///		when find a depCandidateInfo with float version, we need to find the minimum available version (X) on the server. And with that version, we insert the dep entry into the net. and only from this point on can we proceed with the (X).  The process of this paragraph can be async.
	///		Other methods not in the above process spanning around the recursion cannot be asyn
	/// </remarks>
	static public class _AsynX
	{

		public static async Task Asyn_prjAssumeFile(
			string prjMeta
			,
			Srcs_addresses srcs
			,
			ConcurrentQueue<string> started

			,
			ConcurrentQueue<(string, string)> deps
		)
		{
			var parentDoc = nilnul.fs.address_.spear_.ParentDoc.Parse(prjMeta);

			var identity = dev.src.sln.sub.synd.prj._NominaX.Nomina(parentDoc);
			await Asyn_assumeNomina(
				nilnul.obj_.deV.identy.of_._SegsX.Join(identity)
				,
				srcs,started,deps
			);


		}
		static object localLock = new object();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="prjIdentity"> exact version match.   </param>
		/// <param name="svrRepoS"></param>
		/// <param name="svrIndex">
		///		<paramref name="prjIdentity"/> is already found in this svr
		/// </param>
		/// <param name="deps"></param>
		/// <param name="_cacheNotNul"></param>
		/// <param name="logger"></param>
		/// <param name="_memoNotNul"></param>
		/// <returns></returns>
		public static  async Task Asyn_assumeNomina(
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

			var prjMeta= nilnul.dev.src.sln.sub.synd.prj_.cs._meta._LocateX.SpearNulable_ofMain(

				prjIdentity
			);

			if (prjMeta is null)
			{
				return;
			}


			/// todo: if not found, stop
			/// 
			dev.src.prj_.cs.pre_.dlls._RenameX.Changed_assumeCsPrj(prjMeta, dev.src.sln._nomina.Updates.Defaulted);

			var refs = pres._VwX.Identities_assumeCsPrj(prjMeta);
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

					 Asyn_assumeNomina(
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



	}
}

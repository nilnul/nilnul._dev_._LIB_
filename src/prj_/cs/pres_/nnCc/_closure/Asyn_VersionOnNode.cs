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

namespace nilnul.dev.src.prj_.cs.pres_.nnCc._closure
{
	/// <summary>
	/// version, if not null, is a node, acting as the midpoint between two prjs one of which depends on another.
	/// </summary>
	/// <remarks>
	/// </remarks>
	static public class _Asyn_versionOnNodeX
	{

		public static async Task Asyn_prjFileAssumeNilnul(
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
			await Asyn_identityAssumeNilnul(
				nilnul.obj_.deV.identy.of_._SegsX.Join(identity)
				,
				srcs, started, deps
			);


		}
		static object localLock = new object();

		/// <summary>
		/// ver, if not null, is a node, connecting two dependent prj
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
		public static async Task Asyn_identityAssumeNilnul(
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

			/// todo: prjReference
			dev.src.prj_.cs.pre_.dlls._RenameX.Changed_assumeCsPrj(prjMeta, dev.src.sln._nomina.Updates.Defaulted);

			var refs = pres_._NilnulCircaX.Versioneds(prjMeta);
			refs.Each(
				r =>
				{
					if (r.Item2 is null)
					{
						deps.Enqueue(
							(prjIdentity, r.Item1)
						);

					}
					else
					{
						var mid = r.Item2.ToString() + "," + r.Item1;
						deps.Enqueue(
							(prjIdentity,mid )
						);
						deps.Enqueue(
							(mid ,r.Item1)
						);

					}


					
				}
			);



			Parallel.ForEach(
				refs
				,
				dependency =>
				{

					Asyn_identityAssumeNilnul(
					   dependency.Item1,

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

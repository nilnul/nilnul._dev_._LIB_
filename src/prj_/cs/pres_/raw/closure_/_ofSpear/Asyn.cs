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

namespace nilnul.dev.src.prj_.cs.pres_.raw.closure_._ofSpear
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

		public static async Task Asyn_prjOfFile(
			//nilnul.fs.address_.spear_.ParentDoc

			string file
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

			//var prjIdentity = nilnul.dev.src.prj.asDoc.main._NominaX.NominaAsTxt(file);
			lock (localLock)
			{

				if (
					!started.Any(
						f=> nilnul.fs.address_.spear.Eq.Singleton.Equals(f,file)
					)
				)
				{
					started.Enqueue(file);
				}
				else
				{
					return;
				}

			}



			var refs = pres_._RawX.Spears_fileAssumeCsPrj(file).Select(f=>f.ToString());

			refs.Each(
				r =>
				deps.Enqueue(
					(file, r)
				)
			);

			Parallel.ForEach(
				refs
				,
				dependency =>
				{

					Asyn_prjOfFile(
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

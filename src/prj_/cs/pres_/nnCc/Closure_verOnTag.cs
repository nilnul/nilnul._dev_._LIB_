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
using Microsoft.Msagl.Drawing;

namespace nilnul.dev.src.prj_.cs.pres_.nnCc
{
	/// <summary>
	/// for prjRef, the version is default. for dll refs, the version is on Tag/Edge
	/// only nilnul pacS are listed.
	/// 
	/// </summary>
	static public class _Closure_versionOnTagX
	{



		/// <summary>
		/// reduced
		/// </summary>
		/// <param name="prjMeta">file address</param>
		/// <param name="id"></param>
		/// <param name="cache"></param>
		/// <returns></returns>
		static public nilnul.rel_.net.tagged_.EqDefault<string, nilnul.obj_.deV_.pkg._identity.VersionA, nilnul.txt.Eq> Tagged_assumeNilnul(
			string prjMeta
			,
			Srcs_addresses srcs

		)
		{
			var nodes = new ConcurrentQueue<string>();

			var edges = new ConcurrentQueue<(string, string)>();
			var tags = new ConcurrentDictionary<(string, string), nilnul.obj_.deV_.pkg._identity.VersionA>();


			_closure._Asyn_versionOnTagX.Asyn_prjFileAssumeNilnul(prjMeta, srcs, nodes, edges,tags).Wait();

			var mate = new nilnul.rel_.Net1<string>(nilnul.txt.Eq.Singleton, edges, nodes);

			//var reduced = nilnul.rel_.net_.acyclic.op_.unary_._ReduceX.NodesEdges_assumeAcyclic(mate);

			return new nilnul.rel_.net.tagged_.EqDefault<string, nilnul.obj_.deV_.pkg._identity.VersionA,nilnul.txt.Eq>(
				new rel_.net_.EqDefault1<string, txt.Eq>(
edges,
				nodes
				)
				
				
				,
				new rel_.net._tagged.tags_.NodeEqDefault<string, nilnul.obj_.deV_.pkg._identity.VersionA, txt.Eq>(
					tags	//.Select(kv=>)
				)
			);
		}
		static public Graph Graph(nilnul.rel_.net.tagged_.EqDefault<string, nilnul.obj_.deV_.pkg._identity.VersionA, nilnul.txt.Eq> net)
		{
			return nilnul.rel_.net.tagged._GraphX.Layout(net);

		}

		static public Graph Graph(string prjIdentity
			,
			Srcs_addresses srcs)
		{
			return Graph(
				Tagged_assumeNilnul(prjIdentity,srcs)
			);

		}

	}
}

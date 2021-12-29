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

namespace nilnul.dev.src.prj_.cs.pres.closure_
{
	/// <summary>
	/// till unfound in src
	/// </summary>
	static public class _NominaX
	{


		/// <summary>
		/// reduced
		/// </summary>
		/// <param name="prjMeta">file address</param>
		/// <param name="id"></param>
		/// <param name="cache"></param>
		/// <returns></returns>
		static public nilnul.rel_.Net1<string> Net_assumePrjMeta(
			string prjMeta
			,
			Srcs_addresses srcs

		)
		{
			var nodes = new ConcurrentQueue<string>();

			var edges = new ConcurrentQueue<(string, string)>();


			_nomina._AsynX.Asyn_prjAssumeFile(prjMeta, srcs, nodes, edges).Wait();

			var mate = new nilnul.rel_.Net1<string>(nilnul.txt.Eq.Singleton, edges, nodes);

			var reduced = nilnul.rel_.net_.acyclic.op_.unary_._ReduceX.NodesEdges_assumeAcyclic(mate);

			return new nilnul.rel_.Net1<string>(
nilnul.txt.Eq.Singleton,
				
				reduced.edges,
				reduced.nodes
			);
		}
		static public nilnul.rel_.Net1<string> Net_assumePrjMeta(
			string prjMeta
			)
		{
			return Net_assumePrjMeta(
				prjMeta , nilnul.dev.Srcs_addresses.OvCfg()
			);
		}
		static public Graph Graph(nilnul.rel_.Net1<string> net)
		{
			return nilnul.rel_.net._GraphX.Graph(net);

		}

		static public Graph Graph(string prjIdentity
			,
			Srcs_addresses srcs)
		{
			return Graph(
				Net_assumePrjMeta(prjIdentity,srcs)
			);

		}

	}
}

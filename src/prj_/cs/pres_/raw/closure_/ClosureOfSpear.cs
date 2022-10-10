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

namespace nilnul.dev.src.prj_.cs.pres_.raw.closure_
{
	/// <summary>
	/// only nilnul pacS are listed. according to prjMate (not installed assembly or pushed nugetPac)
	/// </summary>
	static public class _OfSpearX
	{


	
		static public nilnul.rel_.Net1<string> Net_assumePrjMeta(
			string prjMeta
			,
			Srcs_addresses srcs

		)
		{
			var nodes = new ConcurrentQueue<string>();

			var edges = new ConcurrentQueue<(string, string)>();


			_ofSpear._AsynX.Asyn_prjOfFile(prjMeta, srcs, nodes, edges).Wait();

			var mate = new nilnul.rel_.Net1<string>(nilnul.txt.Eq.Singleton, edges, nodes);

			var reduced = nilnul.rel_.net_.acyclic.op_.unary_._ReduceX.NodesEdges_assumeAcyclic(mate);

			return new nilnul.rel_.Net1<string>(
nilnul.txt.Eq.Singleton,
				
				reduced.edges,
				reduced.nodes
			);
		}
		static public nilnul.rel_.Net1<string> Net_prjNomina4File(
			string prjNomina
			,
			Srcs_addresses srcs

		)
		{
			return Net_assumePrjMeta(
 nilnul.dev.src.sln.sub.synd.prj_.cs._meta._LocateX.SpearNulable_ofMain(

				prjNomina
			).ToString()
 ,srcs
			);
			
		}

	

		static public Graph Graph(nilnul.rel_.Net1<string> net)
		{
			return nilnul.rel_.net._GraphX.Graph(net);

		}

		static public Graph Graph_assumePrjMeta(string prjIdentity
			,
			Srcs_addresses srcs)
		{
			return Graph(
				Net_assumePrjMeta(prjIdentity,srcs)
			);

		}

	}
}

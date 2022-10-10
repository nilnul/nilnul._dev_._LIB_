using nilnul.txt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln._nomina
{
	public class Updates : nilnul.txt.Dict
	{
		public Updates()
		{
		}

		public Updates(IEnumerable<Duo> enumerable) : base(enumerable)
		{
		}

		public Updates(params (string,string)[] duos):this(
			duos.Select(
				d=> new Duo(d.Item1,d.Item2)
			)
		)
		{

		}

		static public Updates Defaulted = new Updates(
			("nilnul.set._discrete_","nilnul.collection_._discrete_")
		);

		/// <summary>
		/// some sln is renamed. we need to upd the new name in some prjs
		/// </summary>
		/// <param name="prjIdentity"></param>
		/// <returns></returns>
		 public string rewritePrj(string prjIdentity) {
			//var dotted = prjIdentity + ;

			var s = this.SingleOrDefault(
				n=>prjIdentity.StartsWith(n.Key+ obj_.deV._identity._sur._SepX.Txt)
			);
			if (s.Key is null)
			{
				return prjIdentity;
			}
			return prjIdentity.Splice(
				0,
				s.Key.Length
				,
				s.Value
			);
		}

		 static public string RewritePrj(string prjIdentity) {
			return Defaulted.rewritePrj(prjIdentity) ;
		}


	}
}

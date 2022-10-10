using nilnul.fs.address_;
using nilnul.fs.address_.shield_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln.sub.synd.prj
{
	/// <summary>
	/// </summary>
	///
	[Obsolete(nameof(src.prj.asDoc.main._NominaX))]
	static public class _NominaX
	{
		static public IEnumerable<string> Nomina_ofMain(
			string main
		)
		{
			var mainSegs = nilnul.obj_.deV.identy.noted._ParsedX.NotedNulable(main);

			if (mainSegs is nilnul.fs.folder._repoName.dir.name_.idioms0Comments_.Segs segs11)
			{
				var asSegs11 = segs11.asSegs();

				var torsoToe = nilnul.objs_.started._TorsoTipX.TorsoTip(asSegs11);

				return nilnul.objs.op_.unary_._AppendX.Append(
					torsoToe.Item1.Select(s=>s.name.ToString())
					,
					nilnul.txt_.vered._KeyX._Txt(
						torsoToe.Item2.name.ToString()
					)
				);

			}
			else
			{
				throw new ArgumentException($"{main} is not valid prjIdentity");
			}

		}
		public static IEnumerable<string> Nomina(fs._address.doc_._exted.Main main)
		{
			return Nomina_ofMain(main.ToString());
		}
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		static public IEnumerable<string> Nomina_ofSpear(
			string prjSpear
		)
		{
			var meta = nilnul.fs.address_.spear_.ParentDoc.Parse(prjSpear);

			var doc = meta.doc;

			var main = nilnul.fs._address.doc_.exted._MainX.Main(doc);

			return Nomina(main);

			

		}


		static public string NominaAsTxt_ofSpear(
			string prjSpear
		)
		{
			return string.Join(".", Nomina_ofSpear(prjSpear) );
		}
		public static IEnumerable<string> Nomina(fs._address.DocI doc)
		{
			return Nomina( fs._address.doc_.exted._MainX.Main(doc) );
		}

		public static IEnumerable<string> Nomina(fs.address_.spear_.ParentDoc parentDoc)
		{
			return Nomina(parentDoc.doc);
		}

		public static string NominaAsTxt(fs.address_.spear_.ParentDoc parentDoc)
		{
			return string.Join(".", Nomina(parentDoc) );
		}

		public static string CsNominaOfAlias(string parentDoc)
		{
			return NominaAsTxt(
				nilnul.dev.src.sln.sub.synd.prj_.cs._meta._LocateX.SpearNulable_ofMain(parentDoc)
			);
		}

	}
}

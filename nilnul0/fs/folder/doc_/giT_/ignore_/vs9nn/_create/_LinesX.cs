using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.doc_.git_.ignore_.vsNilnul._create
{
	static public class _LinesX
	{
		static public IEnumerable<string> Seq() {
			return nilnul.fs.git._module._work_.div.doc_.ignore._patch._RscX.Seq_ofNilnulWithWin().Concat(
				nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(
					nilnul.fs.git.depo._setting.ignore_._dev._RscX.					PrjPerNilnul
				).Where(x=>!x.StartsWith("#"))
			)
			.Concat(
				nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(
					nilnul.fs.git.depo._setting.ignore_._dev._RscX.DotNet
				).Where(x=>!x.StartsWith("#"))
			);
		}
		static public IEnumerable<string> Distinct() {
			return Seq().Distinct();
		}

	}
}

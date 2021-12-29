using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.doc_.git_.ignore_.vsNilnul._create
{
	static public class _LinesX
	{
		static public IEnumerable<string> Seq() {
			return nilnul.fs.git._module._work_.div.doc_.ignore._patch._RscX.Seq_ofNilnulWithWin().Concat(
				nilnul.fs.git._module._work_.div.doc_.ignore._patch._RscX.Seq_ofBlob(
					nilnul.fs.git.Properties.Resources.vsSlnIgnore
				)
			);
		}
		static public IEnumerable<string> Distinct() {
			return Seq().Distinct();
		}

	}
}

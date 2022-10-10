using nilnul.obj.seq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.synd_.cs.doc_
{
	static public class _SnksX
	{
		static public IEnumerable<string> Captions(nilnul.fs.FolderI folder) {
			return nilnul.fs.folder.docs_._ExtX.Denotes(folder, ".snk");
		}
	}
}

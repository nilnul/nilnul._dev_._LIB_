using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.doc_.deV_.prj_
{
	static public class Cs
	{
		static public IEnumerable< nilnul.fs._address.DocI> Docs(nilnul.fs.FolderI folder) {
			return nilnul.fs.folder.docs_._ExtX.Docs(folder, ".csproj");
		}
		static public nilnul.fs._address.DocI Doc(nilnul.fs.FolderI folder) {
			return Docs(folder).Single();
		}
		static public nilnul.fs._address.DocI Doc_ofAddress(string folder) {
			return Doc(nilnul.fs.Folder.FroAddress(folder) );
		}

		static public nilnul.fs.address_.spear_.ParentDoc Address_ofContainerAddress(string folder) {
			return nilnul.fs.address_.spear_.ParentDoc.OfContainerAsAddress(folder, Doc_ofAddress(folder) );
		}


	}
}

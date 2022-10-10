using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.divs_.notDotLed_.deV_.noVs
{
	static public class _DocsX
	{
		static public IEnumerable<DocI> Docs(nilnul.fs.FolderI folder) {
			return nilnul.fs.folder.divs_.notDotLed_.deV_._ExcludeVsX.Divs(folder).SelectMany(
				div =>
				nilnul.fs.folder._DocsX.Docs(
					nilnul.fs.folder_._BaseDivisionX.Folder(folder,div)
				)
			);
		}
		static public IEnumerable<Document> Documents(nilnul.fs.FolderI folder) {
			return nilnul.fs.folder.divs_.notDotLed_.deV_._ExcludeVsX.Divs(folder).SelectMany(
				div =>

				nilnul.fs.folder._DocsX.Docs(
					nilnul.fs.folder_._BaseDivisionX.Folder(folder,div)
				).Select(
					doc => new nilnul.fs._address.Document(div,doc)
				)
			);
		}


	}
}

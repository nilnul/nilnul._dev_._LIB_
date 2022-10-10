using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders.divs_.notDotLed_.deV_.noVs
{
	static public class _DocsX
	{
		public static IEnumerable<DocI> Docs(IEnumerable<FolderI> folders)
		{
			return folders.SelectMany(
				x => nilnul.fs.folder.divs_.notDotLed_.deV_.noVs._DocsX.Docs(x)
			);

		}

		public static IEnumerable<Document> Documents(IEnumerable<FolderI> folders)
		{
			return folders.SelectMany(
				x => nilnul.fs.folder.divs_.notDotLed_.deV_.noVs._DocsX.Documents(x)
			);

		}

		public static IEnumerable<nilnul.fs.address_.spear_.ParentDocument> Spears(IEnumerable<FolderI> folders)
		{
			return folders.SelectMany(
				x => nilnul.fs.folder.divs_.notDotLed_.deV_.noVs._DocsX.Documents(x).Select(
					d=>new nilnul.fs.address_.spear_.ParentDocument(x.address.en,d)
				)
			);

		}


		static public IEnumerable<DocI> Docs(IEnumerable<nilnul.fs.Folder> dirs)
		{
			return Docs(
				dirs.Cast<FolderI>()
			);
		}

		static public IEnumerable<Document> Documents(IEnumerable<nilnul.fs.Folder> dirs)
		{

			return Documents(
				dirs.Cast<FolderI>()
			);
		}

		static public IEnumerable<nilnul.fs.address_.spear_.ParentDocument> Spears(IEnumerable<nilnul.fs.Folder> dirs)
		{

			return Spears(
				dirs.Cast<FolderI>()
			);
		}

		static public IEnumerable<DocI> Docs(IEnumerable<DirectoryInfo> dirs)
		{
			return Docs(
				dirs.Select(d=> new nilnul.fs.Folder(d))
			);
		}

		static public IEnumerable<Document> Documents(IEnumerable<DirectoryInfo> dirs)
		{
			return Documents(
				dirs.Select(d=> new nilnul.fs.Folder(d))
			);
		}

		static public IEnumerable<nilnul.fs.address_.spear_.ParentDocument> Spears(IEnumerable<DirectoryInfo> dirs)
		{
			return Spears(
				dirs.Select(d=> new nilnul.fs.Folder(d))
			);
		}

		static public IEnumerable<DocI> Docs_ofAddresses(IEnumerable<string> folders)
		{
			return Docs(
				folders.Select(f=>  nilnul.fs.Folder.FroAddress(f))
			);

		}

		static public IEnumerable<Document> Documents_ofAddresses(IEnumerable<string> folders)
		{
			return Documents(
				folders.Select(f=>  nilnul.fs.Folder.FroAddress(f))
			);

		}

		static public IEnumerable<nilnul.fs.address_.spear_.ParentDocument> Spears_ofAddresses(IEnumerable<string> folders)
		{
			return Spears(
				folders.Select(f=>  nilnul.fs.Folder.FroAddress(f))
			);

		}

		static public IEnumerable<DocI> Docs_ofAddresses(params string[] folders)
		{
			return Docs_ofAddresses(
				(IEnumerable<string>)folders
			);

		}
		static public IEnumerable<Document> Documents_ofAddresses(params string[] folders)
		{
			return Documents_ofAddresses(
				(IEnumerable<string>)folders
			);

		}

		static public IEnumerable<nilnul.fs.address_.spear_.ParentDocument> Spears_ofAddresses(params string[] folders)
		{
			return Spears_ofAddresses(
				(IEnumerable<string>)folders
			);

		}

	}
}

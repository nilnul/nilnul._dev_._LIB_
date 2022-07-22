using nilnul.fs.address_.spear_;
using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nilnul.dev.prj_._sql_.division
{
	/// <summary>
	/// include a directory as nonbuild, checking whether it's already included.
	/// to extend this, note to exclude "bin","obj", "packages" and other generated directories(mostly dirs.)
	/// </summary>
	///
	static public class _IncludeX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="directory">backslashed</param>
		/// <returns></returns>
		static public XElement _El4folder_directoryAssumeComplied(string directory)
		{
			return new XElement(
				"Folder",

				new XAttribute("Include", directory)


			);
		}


		static public XElement _El4folder(nilnul.fs._address.DirectoryI directory)
		{
			return _El4folder_directoryAssumeComplied(
				nilnul.fs._address._route.division_.div_.directory._construe_.phrase_.ByBackslashX.ByBackslash(directory)
			);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="document"></param>
		/// <returns></returns>
		static public XElement _El4document_assumeComplied(string document)
		{
			return new XElement(
				"None",

				new XAttribute("Include", document)

			);
		}

		static public XElement _El4document(nilnul.fs._address.Document document)
		{
			return _El4document_assumeComplied(
				fs._address._route.division_.denotation._construe_.phrase_.ByBackslashX.ByBackslash(document)
			);
		}





	}
}

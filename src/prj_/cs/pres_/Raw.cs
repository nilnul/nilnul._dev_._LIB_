using nilnul.fs;
using nilnul.fs.address_;
using nilnul.fs.address_.spear_;
using NuGet.Packaging.Core;
using NuGet.Versioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nilnul.dev.src.prj_.cs.pres_
{
	/// <summary>
	/// project reference, with  reference of dll from installed package
	/// </summary>
	static public class _RawX
	{

		public static IEnumerable<string> Identities_assumeCsPrj(FileI ee)
		{
			return Identities_assumeCsPrj(ee.file.en);

		}
		static public IEnumerable<string> Identities_fileAssumeCsPrj(string file)
		{

			return Identities( XDocument.Load(file));

		}

		static public IEnumerable<fs.address_.Spear> Spears_fileAssumeCsPrj(string file)
		{
			return pre_.raws._VwX.Spears_prjOfSpear(file);
		}

		static public IEnumerable<fs.address_.spear_.ParentDoc> BasedDocS_fileAssumeCsPrj(string file)
		{
			return pre_.raws._VwX.BasedDocS_prjOfSpear(file);
		}



		public static IEnumerable<string> Identities_assumeCsPrj(SpearI en)
		{
			return Identities_fileAssumeCsPrj(en.ToString());
		}

		static public IEnumerable<string> Identities(nilnul.dev.src.prj_.Cs file)
		{
			return Identities_fileAssumeCsPrj(file.ToString());
		}
		static public IEnumerable<string> Identities_ofBlob(string xml)
		{
			return Identities(XDocument.Parse(xml));
		}

		static public IEnumerable<string> Identities(XDocument doc)
		{

			return pre_.raws._VwX.Identities(doc);
		}

	

	}
}

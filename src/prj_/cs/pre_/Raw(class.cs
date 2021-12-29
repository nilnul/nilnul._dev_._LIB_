using nilnul.fs;
using nilnul.fs.address_;
using NuGet.Packaging.Core;
using NuGet.Versioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nilnul.dev.src.prj_.cs.pre_
{
	/// <summary>
	/// project reference
	/// </summary>
	static public class _RawX
	{

		public static IEnumerable<XElement> Els_assumeCsPrj(FileI ee,string name)
		{
			return Els_assumeCsPrj(ee.file.en,name);

		}

		public static IEnumerable<XElement> Els_assumeCsPrj(SpearI en,string name)
		{
			return Els_fileAssumeCsPrj(en.ToString(),name);
		}

		static public IEnumerable<XElement> Els(nilnul.dev.src.prj_.Cs file,string name)
		{
			return Els_fileAssumeCsPrj(file.ToString(),name);
		}
		static public IEnumerable<XElement> Els_fileAssumeCsPrj(string file, string name)
		{

			return Els( XDocument.Load(file),name);

		}
		static public IEnumerable<XElement> Els_ofBlob(string xml,string name)
		{
			return Els(XDocument.Parse(xml),name);
		}

		static public XElement El0default(XDocument doc,string name)
		{
			return Els(doc,name).SingleOrDefault();
		}
	
		static public IEnumerable<XElement> Els(XDocument doc, string name)
		{
			return doc.XPathSelectElements(
				XPATH4NAME
			).Where(x=>x.Value==name).Select(a=>a.Parent);
		}
		public const string XPATH = "/*/*[local-name()='ItemGroup']/*[local-name()='ProjectReference']";
		static public IEnumerable<XElement> Els(XDocument doc)
		{
			return doc.XPathSelectElements(
				XPATH
			);
		}

		public const string XPATH4NAME = XPATH+ "/*[local-name()='Name']";

		public const string PRJ_REF__4__NAME = "*[local-name()='Name']";


		static public string NameNable_assumePrjRefEl(XElement prjRefEl) {

			return prjRefEl.XPathSelectElement(PRJ_REF__4__NAME)?.Value;
		}





	}
}

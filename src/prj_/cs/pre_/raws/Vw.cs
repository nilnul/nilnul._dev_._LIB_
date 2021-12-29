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

namespace nilnul.dev.src.prj_.cs.pre_.raws
{
	/// <summary>
	/// project reference
	/// </summary>
	static public class _VwX
	{

		public static IEnumerable<XElement> Els_assumeCsPrj(FileI ee)
		{
			return Els_assumeCsPrj(ee.file.en);

		}

		public static IEnumerable<XElement> Els_assumeCsPrj(SpearI en)
		{
			return Els_fileAssumeCsPrj(en.ToString());
		}

		static public IEnumerable<XElement> Els(nilnul.dev.src.prj_.Cs file)
		{
			return Els_fileAssumeCsPrj(file.ToString());
		}
		static public IEnumerable<XElement> Els_fileAssumeCsPrj(string file)
		{

			return Els(XDocument.Load(file));

		}
		static public IEnumerable<XElement> Els_ofBlob(string xml)
		{
			return Els(XDocument.Parse(xml));
		}

		public const string XPATH = "/*/*[local-name()='ItemGroup']/*[local-name()='ProjectReference']";

		static public IEnumerable<XElement> Els(XDocument doc)
		{
			return doc.XPathSelectElements(
				XPATH
			);
		}



		public const string XPATH4NAME = XPATH + "/*[local-name()='Name']";

		static public IEnumerable<string> Identities(XDocument doc)
		{
			return doc.XPathSelectElements(
				XPATH4NAME
			).Select(x => x.Value);
		}

		public const string XPATH4PATH = XPATH + "/@Include";
		static public IEnumerable<string> Paths(XDocument doc)
		{
			return ((IEnumerable<object>) doc.XPathEvaluate(
				XPATH4PATH
			)).OfType<XAttribute>().Select(x => Uri.UnescapeDataString( x.Value ));
		}


		


		static public IEnumerable<string> Identities_ofPrjIdenty(string prjIdenty)
		{
			var path = nilnul.dev.src.sln.sub.synd.prj_.cs._meta._LocateX.SpearNulable_ofMain(prjIdenty);
			return Identities(
				XDocument.Load(path.ToString())
			);
		}


		static public IEnumerable<fs.address_.Spear> Spears_prjOfSpear(string path)
		{
			
			return Paths(
				XDocument.Load(path.ToString())
			).Select(
				x=>
				nilnul.fs.path.co_.starT_.spear_.enD_.denotation_.dntAppended._ConcatX.Spear(
					path
					,
					x
				)
			);
		}

		static public IEnumerable<fs.address_.spear_.ParentDoc> BasedDocS_prjOfSpear(string path)
		{
			
			return Spears_prjOfSpear(path).Select(s=> new fs.address_.spear_.ParentDoc(s));
		}



	}
}

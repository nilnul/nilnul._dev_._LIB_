using nilnul.fs;
using nilnul.fs.address_;
using nilnul.objs;
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

namespace nilnul.dev.src.prj_.cs.dep_.pac_.none
{
	static public class _AddX
	{

		public static void Vod_assumeCsPrj(FileI ee, string refered)
		{
			 Vod_assumeCsPrj(ee.file.en,refered);

		}

		public static void Vod_assumeCsPrj(SpearI en, string refered)
		{
			 Vod_fileAssumeCsPrj(en.ToString(),refered);
		}

		static public void Vod(nilnul.dev.src.prj_.Cs file, string refered)
		{
			 Vod_fileAssumeCsPrj(file.ToString(),refered);
		}
		static public void Vod_fileAssumeCsPrj(string file, string refered)
		{
			var doc = XDocument.Load(file);

			 Vod(doc,refered);
			doc.Save(file);

		}
		static public void Vod_ofBlob(string xml, string refered)
		{
			 Vod(XDocument.Parse(xml),refered);
		}

		static public void Vod(XDocument doc, string refered)
		{
			var r = doc.XPathSelectElements(
				"/*/*[local-name()='ItemGroup']/*[local-name()='Reference']"
			).LastOrDefault();

			if (r is null)
			{

			}
			else
			{
				r.AddAfterSelf(
					// the publicKeyToken
				);
			}


		}

		


	}
}

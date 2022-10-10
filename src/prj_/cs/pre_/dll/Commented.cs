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
//[Obsolete()]
namespace nilnul.dev.src.prj_.cs.pre_.dll
{
	static public class _CommentedX
	{

		public static void Vod_assumeCsPrj(FileI ee, string refered)
		{
			Vod_assumeCsPrj(ee.file.en, refered);

		}

		public static void Vod_assumeCsPrj(SpearI en, string refered)
		{
			Modified_fileAssumeCsPrj(en.ToString(), refered);
		}

		static public void Vod(nilnul.dev.src.prj_.Cs file, string refered)
		{
			Modified_fileAssumeCsPrj(file.ToString(), refered);
		}
		static public bool Modified_fileAssumeCsPrj(string file, string refered)
		{
			var doc = XDocument.Load(file);

			var r = Modified(doc, refered);
			if (r)
			{
				doc.Save(file);

			}
			return r;

		}
		static public bool Modified_ofBlob(string xml, string refered)
		{
			return Modified(XDocument.Parse(xml), refered);
		}

		static public bool Modified(XDocument doc, string refered)
		{
			var r = doc.XPathSelectElements(
				"/*/*[local-name()='ItemGroup']/*[local-name()='Reference']"
			)
				;
			r = r.Where(
				e => e.Attribute("Include").Value.Split(new[] { ',' },  StringSplitOptions.RemoveEmptyEntries)[0].Trim() == refered
			);

			var t = r.ToArray();

			t.Each(x => x.ReplaceWith(
			   new XComment(
				   x.ToString()
			   )
		   ));
			return t.Any();
		}




	}
}

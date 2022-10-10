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

namespace nilnul.dev.src.prj_.cs.target
{
	static public class _EnsureX
	{
		static public bool Updated_fileAssumeCsPrj(string file,string target)
		{

			var doc= XDocument.Load(file);
var el= doc.XPathSelectElements(
				"/*/*[local-name()='PropertyGroup']/*[local-name()='TargetFrameworkVersion']"
			)
			.Single();
			if (el.Value!=target)
			{
				el.Value = target;
				doc.Save(file);
				return true;
			}
			return false;

		}

		public static bool Updated_assumeCsPrj(FileI ee,string target)
		{
			return Updated_assumeCsPrj(ee.file.en,target);

		}

		public static bool Updated_assumeCsPrj(SpearI en, string target)
		{
			return Updated_fileAssumeCsPrj(en.ToString(),target);
		}

		static public bool Updated(nilnul.dev.src.prj_.Cs file,string target)
		{
			return Updated_fileAssumeCsPrj(file.ToString(),target);
		}

		


	}
}

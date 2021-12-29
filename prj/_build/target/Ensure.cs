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

namespace nilnul.dev.prj._build.target
{
	/// <summary>
	/// works for both Csproj and sqlProj
	/// </summary>
	static public class _EnsureX
	{
		static public bool Updated_fileAssumePrj(string file,string target)
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
		public static bool Updated_assumePrj(SpearI en, string target)
		{
			return Updated_fileAssumePrj(en.ToString(),target);
		}
		public static bool Updated_assumePrj(FileI ee,string target)
		{
			return Updated_assumePrj(ee.file.en,target);

		}


		static public bool Updated(nilnul.dev.src.IPrj file,string target)
		{
			return Updated_fileAssumePrj(file.ToString(),target);
		}


		


	}
}

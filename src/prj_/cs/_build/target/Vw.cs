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
	static public class _VwX
	{

		public static string Txt_assumeCsPrj(FileI ee)
		{
			return Txt_assumeCsPrj(ee.file.en);

		}

		public static string Txt_assumeCsPrj(SpearI en)
		{
			return Txt_fileAssumeCsPrj(en.ToString());
		}

		static public string Txt(nilnul.dev.src.prj_.Cs file)
		{
			return Txt_fileAssumeCsPrj(file.ToString());
		}
		/// <summary>
		/// this used in "packages.config" and the dir name in nuget installed.
		/// </summary>
		static public Dictionary<string, string> Dict = new Dictionary<string, string>() {
				["v4.8"]="net48"
				,["v4.7.2"]="net472"
			};
		static public string DntPerTarget(string txt) {
			
			
			if (Dict.ContainsKey(txt))
			{
				return Dict[txt];
			}
			return "net"+ txt.Substring(1).Replace(".","");

		}
		static public string DntInInstalled_fileAssumeCsPrj(string file) {
			var txt = Txt_fileAssumeCsPrj(file);
			
			return DntPerTarget(txt);

		}
		static public string Txt_fileAssumeCsPrj(string file)
		{

			return Txt( XDocument.Load(file));

		}

		static public string Txt(XDocument doc)
		{
			return doc.XPathSelectElements(
				"/*/*[local-name()='PropertyGroup']/*[local-name()='TargetFrameworkVersion']"
			)
			.Select(pr => pr.Value).Single();
		}

		

		static public string Txt_ofBlob(string xml)
		{
			return Txt(XDocument.Parse(xml));
		}

	}
}

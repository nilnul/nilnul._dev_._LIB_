using nilnul.fs;
using nilnul.fs.address_;
using nilnul.objs;
using NuGet.Packaging.Core;
using NuGet.Versioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nilnul.dev.src.prj_.cs.pre_
{
	/*
	///		<Reference Include="System.Web" />
	///		<Reference Include="System.Web.Cors, Version=5.2.7.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL">
	///     <HintPath>packages\Microsoft.AspNet.Cors.5.2.7\lib\net45\System.Web.Cors.dll</HintPath>
	///   </Reference>

   <Reference Include="_nilnul_._LINQ_, Version=1.0.7819.39633, Culture=neutral, PublicKeyToken=085f320e4a727230">
      <HintPath>packages\_nilnul_._LINQ_.1.0.7819.39633\lib\net48\_nilnul_._LINQ_.dll</HintPath>
      <Private>True</Private>
    </Reference>
   <Reference Include="_nilnul_._LINQ_, Version=1.0.7819.39633, Culture=neutral, PublicKeyToken=085f320e4a727230">
      <HintPath>packages\_nilnul_._LINQ_.1.0.7819.39633\lib\net48\_nilnul_._LINQ_.dll</HintPath>
      <Aliases>global, something</Private>
    </Reference>

	 */
	/// <summary>
	/// referenced to a dll. the dll might be from nuget package.
	/// </summary>
	/// <remarks>
	///   
	/// </remarks>
	/// 
	static public class _DllX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ee"></param>
		/// <param name="refered"></param>
		/// <returns></returns>
		public static XElement Element_assumeCsPrj(FileI ee, string refered)
		{
			return Element_assumeCsPrj(ee.file.en, refered);

		}

		public static XElement Element_assumeCsPrj(SpearI en, string refered)
		{
			return Element_fileAssumeCsPrj(en.ToString(), refered);
		}

		static public XElement Element(nilnul.dev.src.prj_.Cs file, string refered)
		{
			return Element_fileAssumeCsPrj(file.ToString(), refered);
		}
		static public XElement Element_fileAssumeCsPrj(string file, string refered)
		{
			var doc = XDocument.Load(file);

			return Element0default(doc, refered);


		}
		static public XElement Element_ofBlob(string xml, string refered)
		{
			return Element0default(XDocument.Parse(xml), refered);
		}


		static public XElement Element0default(XDocument doc, string refered)
		{
			var r = doc.XPathSelectElements(
				"/*/*[local-name()='ItemGroup']/*[local-name()='Reference']"
			)
				;
			r = r.Where(
				e => e.Attribute("Include").Value.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)[0].Trim() == refered
			);
			return r.SingleOrDefault();
		}

		static public XElement ElementNable_ofRefElS(IEnumerable<XElement> doc, string refered)
		{
			var r = doc.Where(
				e => e.Attribute("Include").Value.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)[0].Trim() == refered
			);
			return r.SingleOrDefault();
		}


		static public string Identity(XElement e)
		{
			return
				new string(
					e.Attribute("Include").Value.Trim().TakeWhile(c => c != ',').ToArray()
				)
			;
		}


	}
}

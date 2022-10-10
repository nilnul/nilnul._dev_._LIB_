using nilnul.fs;
using nilnul.fs.address_;
using nilnul.objs;
using nilnul.txt;
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

namespace nilnul.dev.src.prj_.cs.pre_.dll.versions.change_
{
	/*
	  <Reference Include="EntityFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089">
      <HintPath>..\..\(packages)\EntityFramework.6.4.4\lib\net45\EntityFramework.dll</HintPath>
      <Private>True</Private>
    </Reference>

	note in the above, the dll version is inconsistent with pac version.
	 */

	/// <summary>
	/// change the version in both "Include"Attr and "HintPath"Element
	/// </summary>
	static public class _VerX
	{



		static public bool Changed(XElement element, string newVer)
		{
			var r = false;
			const string Attr = "Include";
			var AttrInclude = element.Attribute(Attr);
			var includeOldValue = AttrInclude.Value;

			var includeSplit = includeOldValue.Split(
				','
			);

			var oldVer = includeSplit[1].Split('=')[1].Trim();

			if (oldVer == newVer)
			{
				//return false;
			}
			else
			{
				includeSplit[1] = $"Version={newVer}";
				AttrInclude.Value = string.Join(",", includeSplit);
				r = true;
			}

			//hintPath

			var hintPathEl = element.XPathSelectElement("*[local-name() = 'HintPath']");
			if (hintPathEl is null)
			{
				return r;
				//return true;

			}

			var oldPathVal = hintPathEl.Value;

			if (string.IsNullOrWhiteSpace(oldPathVal))
			{
				return r;
				//return true;
			}

			var dnts = oldPathVal.Split(new[] { '/', '\\' }).ToArray();

			var dntsIdentity = dnts[dnts.Length - 4];
			var regex = nilnul.obj_.deV_.pkg.identity._VersioningX.RegexTxtForEnding;

			dnts[dnts.Length - 4] = Regex.Replace(
				dntsIdentity

				,
				regex
				//$@"{Regex.Escape(oldVer)}$"
				,
				newVer, RegexOptions.IgnorePatternWhitespace
			);
			if (dntsIdentity == dnts[dnts.Length - 4])
			{
				return r;
			}

			hintPathEl.Value = string.Join(
				System.IO.Path.DirectorySeparatorChar.ToString()
				,
				dnts
			);

			return true;



		}





	}
}

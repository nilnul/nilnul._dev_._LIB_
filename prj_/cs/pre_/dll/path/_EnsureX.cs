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

namespace nilnul.dev.prj_.cs.pre_.dll.path
{
	/*
	  <Reference Include="EntityFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089">
      <HintPath>..\..\(packages)\EntityFramework.6.4.4\lib\net45\EntityFramework.dll</HintPath>
      <Private>True</Private>
    </Reference>

	note in the above, the dll version is inconsistent with pac version.
	 */

	/// <summary>
	/// change the path;
	/// </summary>
	static public class _EnsureX
	{
		static public bool _AsChanged_0el4pre_1path(XElement element, string newVer)
		{
			//hintPath

			var hintPathEl = element.XPathSelectElement("*[local-name() = 'HintPath']");
			if (hintPathEl is null)
			{
				return false;
				//return true;
			}

			var oldPathVal = hintPathEl.Value;
			if (oldPathVal == newVer)
			{
				return false;
			}

			hintPathEl.Value = newVer;
			return true;
		}
	}
}
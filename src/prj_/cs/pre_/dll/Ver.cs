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

namespace nilnul.dev.src.prj_.cs.pre_.dll
{
	static public class _VersionX
	{
		static public nilnul.obj_.deV_.pkg._identity.VersionA Nulable(XElement element)
		{

			const string Attr = "Include";
			var AttrInclude = element.Attribute(Attr);

			var includeOldValue = AttrInclude.Value;
			if (string.IsNullOrWhiteSpace(includeOldValue))
			{
				return null;
			}

			var includeSplit = includeOldValue.Split(
				','
			);
			if (includeSplit.Length >1)    //no version such as "<Reference Include="System" />"
			{
				var verTxt = includeSplit[1].Split('=')[1].Trim();

				return nilnul.obj_.deV_.pkg._identity._VersionX.Parse(verTxt);

			}
			return null;
		}
	}
}

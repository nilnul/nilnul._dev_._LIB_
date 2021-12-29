using nilnul.fs.address_.spear_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.dev.src.prj_.cs.pre_.dll.path
{
	/*
  <Reference Include="Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed, processorArchitecture=MSIL">
      <HintPath>..\..\(packages)\Newtonsoft.Json.13.0.1\lib\net45\Newtonsoft.Json.dll</HintPath>
    </Reference>	 
	*/
	/// <summary>
	/// the version in the path might be different from the version per the "Include" attribute.
	/// 
	/// </summary>
	static public class _VersionX
	{
		const string HINT_PATH = "HintPath";
		const string DIR_PACKAGES = @"packages\";
		static public nilnul.obj_.deV_.pkg._identity.VersionA VersionNulable(XElement e)
		{
			var hintPath = e.Elements().SingleOrDefault(
				a => a.Name.LocalName == HINT_PATH
			);

			if (!(hintPath is null))
			{
				var val = hintPath.Value?.Trim();
				if (!string.IsNullOrWhiteSpace(val))
				{
					var denotationNulable = nilnul.fs.path.nulable._ParseX.Parse(
						val
					);

					if (denotationNulable is null)
					{
						return null; //path parse exception
					}

					var splitted = val.Split(new[] { '\\', '/' });
					var identy = splitted[splitted.Length - 4];
					var ver = nilnul.obj_.deV_.pkg.identity._VersionX.OfIdenty(identy);
					return ver;
				}
			}
			return null;
		}

	

	}
}

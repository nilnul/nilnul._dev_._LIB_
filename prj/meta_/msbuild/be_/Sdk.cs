using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.dev.prj.meta_.msbuild.be_
{
	/// <summary>
	/// is it sdk styled proj file;
	/// dotnet 5plus uses sdk; dotnet 4minus uses explicit imports;
	/// </summary>
	///
	interface ISdk { }
	static public class _SdkX
	{
		static public bool _Be_0msbuild(string s)
		{
			return _Be(
				XDocument.Load(s)
			);
		}

		public static bool _Be(XDocument xDocument)
		{
			return	xDocument.Root.Attribute("Sdk") is not null;
		}
	}
}

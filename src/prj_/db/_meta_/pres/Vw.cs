using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nilnul.dev.src.prj_.db._meta_.pres
{
	/// <summary>
	/// for each ref, update it using the most new ones.
	/// </summary>
	static public class _VwX
	{
		static public IEnumerable<XElement> Els(XDocument doc) {
			var xpath = "/*/*[local-name()='ItemGroup']/*[local-name()='ArtifactReference']"; ;
			return doc.XPathSelectElements(
				xpath
			);
		}
	}
}

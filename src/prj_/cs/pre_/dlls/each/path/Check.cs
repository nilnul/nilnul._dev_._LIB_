using nilnul.fs.address_.spear_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.dev.src.prj_.cs.ref_.dlls.eachPath
{
	/// <summary>
	/// check the path, in order to, later, to let the path point to a centrufugal place
	/// </summary>
	static public class Check
	{
		const string HINT_PATH = "HintPath";
		const string DIR_PACKAGES = @"packages\";

		static public IEnumerable<XElement> Problematics(XDocument document) {
			var els = dlls._VwX.Els(document);

			return els.Where(
				e => {
					var hintPath = e.Element(HINT_PATH);
					if (!(hintPath is null))
					{
						var val = hintPath.Value?.Trim();
						if (!string.IsNullOrWhiteSpace(val))
						{
							if (!val.StartsWith(DIR_PACKAGES))
							{
								return true;//problematic
							}
						}
					}
					return false;
				}
			);

			//return els;
		}
		static public IEnumerable<XElement> Problematics_ofPrjMeta(string document)
		{
			return Problematics(
				XDocument.Load(document)
			);
		}
		private static IEnumerable<XElement> Problematics(nilnul.fs.address_.SpearI parentDoc)
		{
			return Problematics_ofPrjMeta(parentDoc.ToString());
		}
		static public IEnumerable<XElement> Problematics_ofPrjIdenty(string document)
		{
			return Problematics(
				nilnul.dev.src.sln.sub.prj_.cs._meta._LocateX.Spear_ofMain(document)
			);
		}

	}
}

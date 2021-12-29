using nilnul.fs;
using nilnul.fs.address_;
using nilnul.fs.address_.spear_;
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

namespace nilnul.dev.src.prj_.cs.pre_.dll._rename.path_
{
	/// <summary>
	/// change the {HintPath} of a dll reference
	/// </summary>
	static public class _OnDictX
	{

		public static void Vod_assumeCsPrj(FileI ee, string refered)
		{
			Vod_assumeCsPrj(ee.file.en, refered);

		}
		static public bool Modified_fileAssumeCsPrj(string file, string refered)
		{
			var doc = XDocument.Load(file);

			var r = Modified(doc, refered);
			if (r)
			{
				doc.Save(file);

			}
			return r;

		}

		public static void Vod_assumeCsPrj(SpearI en, string refered)
		{
			Modified_fileAssumeCsPrj(en.ToString(), refered);
		}

		public static bool Modified_fileAssumeCsPrj(ParentDoc file, string reference)
		{
			return Modified_fileAssumeCsPrj(file.ToString(), reference);
		}


		static public void Vod(nilnul.dev.src.prj_.Cs file, string refered)
		{
			Modified_fileAssumeCsPrj(file.ToString(), refered);
		}
		static public bool Modified_ofBlob(string xml, string refered)
		{
			return Modified(XDocument.Parse(xml), refered);
		}

		static public bool Modified(XDocument doc, string refered)
		{
			var r = doc.XPathSelectElements(
				"/*/*[local-name()='ItemGroup']/*[local-name()='Reference']"
			)
				;
			r = r.Where(
				e => e.Attribute("Include").Value.Split(new[] { ',' },  StringSplitOptions.RemoveEmptyEntries)[0].Trim() == refered
			);


			var changed = false;
			var t = r.ToArray();

			t.Each(x =>
			{
				var hintPathEl = x.XPathSelectElement("*[local-name()='HintPath']");
				if (hintPathEl is null)
				{
					return;

				}
				
				var oldVal =hintPathEl.Value;

				var newVal = oldVal;

				dev.src.sln._nomina.Updates.Defaulted.Each(
					kv =>
					{

						newVal = Regex.Replace(
							newVal
							,
							$@"^{Regex.Escape(kv.Key)}.|[/\\]{Regex.Escape(kv.Key)}."
							,
							kv.Value+"."
						);
					}

				);

				if (newVal != oldVal)
				{
					hintPathEl.Value = newVal;
					changed = true;
				}
			});
		
			return changed;
		}


		
	}
}

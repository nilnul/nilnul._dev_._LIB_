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

namespace nilnul.dev.src.prj_.cs.pre_.dll._rename
{
	static public class _PathX
	{

		public static bool Modified_assumeCsPrj(FileI ee, string refered, string newIdentity)
		{
			return Modified_assumeCsPrj(ee.file.en, refered, newIdentity);

		}

		public static bool Modified_assumeCsPrj(SpearI en, string refered, string newIdentity)
		{
			return Modified_fileAssumeCsPrj(en.ToString(), refered, newIdentity);
		}

		static public bool Modified(nilnul.dev.src.prj_.Cs file, string refered, string newIdentity)
		{
			return Modified_fileAssumeCsPrj(file.ToString(), refered, newIdentity);
		}
		static public bool Modified_fileAssumeCsPrj(string file, string refered, string newIdentity)
		{
			var doc = XDocument.Load(file);

			var r = Modified(doc, refered, newIdentity);
			if (r)
			{
				doc.Save(file);

			}
			return r;

		}
		static public bool Modified_ofBlob(string xml, string refered, string newIdentity)
		{
			return Modified(XDocument.Parse(xml), refered, newIdentity);
		}

		static public bool Modified(XDocument doc, string refered, string newIdentity)
		{
			var r = doc.XPathSelectElements(
				"/*/*[local-name()='ItemGroup']/*[local-name()='Reference']"
			)
				;
			r = r.Where(
				e => e.Attribute("Include").Value.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)[0].Trim() == refered
			);


			var changed = false;
			var t = r.ToArray();

			t.Each(x =>
			{
				var hintPathEl = x.XPathSelectElement("*[local-name() = 'HintPath']");
				if (hintPathEl is null)
				{
					return;

				}

				var oldVal = hintPathEl.Value;

				var newVal = oldVal;



				newVal = Regex.Replace(
					newVal
					,
					$@"^{Regex.Escape(refered)}|[/\\]{Regex.Escape(refered)}"
					,
					newIdentity
				);


				if (newVal != oldVal)
				{
					hintPathEl.Value = newVal;
					changed = true;
				}
			});

			return changed;
		}


		static public bool Modified_assumeRefPacElement(XElement doc, string refered, string newIdentity)
		{
			var changed = false;
			var x = doc;
			var hintPathEl = x.XPathSelectElement("*[local-name() = 'HintPath']");
			if (hintPathEl is null)
			{
				return false;

			}

			var oldVal = hintPathEl.Value;

			var newVal = oldVal;



			newVal = Regex.Replace(
				newVal
				,
				$@"^{Regex.Escape(refered)}|[/\\]{Regex.Escape(refered)}"
				,
				newIdentity
			);


			if (newVal != oldVal)
			{
				hintPathEl.Value = newVal;
				changed = true;
			}


			return changed;
		}


	}
}

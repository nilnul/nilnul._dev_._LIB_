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
	static public class _RenameX
	{

		public static bool Changed_assumeCsPrj(FileI ee, string identity, string newIdentity)
		{
			return Changed_assumeCsPrj(ee.file.en, identity, newIdentity);

		}

		public static bool Changed_assumeCsPrj(SpearI en, string identity, string newIdentity)
		{
			return Changed_fileAssumeCsPrj(en.ToString(), identity, newIdentity);
		}

		static public bool Changed(nilnul.dev.src.prj_.Cs file, string identity, string newIdentity)
		{
			return Changed_fileAssumeCsPrj(file.ToString(), identity, newIdentity);
		}
		static public bool Changed_fileAssumeCsPrj(string file, string identity, string newIdentity)
		{
			var doc = XDocument.Load(file);
			var changed = Changed(
				doc
				, identity, newIdentity
			);

			///due the change of "Include" attribute
			///
			if (changed)
			{
				doc.Save(file);

			}


			return changed;

		}




		static public bool Changed(XDocument doc, string identity, string newIdentity)
		{
			if (identity == newIdentity)
			{
				return false;
			}

			var element = pre_._DllX.Element0default(doc, identity);

			if (element is null)
			{
				return false;
			}

			if (pre_._DllX.Element0default(doc, newIdentity) is null)
			{
				const string Attr = "Include";
				var oldValue = element.Attribute(Attr).Value;

				element.Attribute(Attr).Value = oldValue.Splice(
					0
					,
					oldValue.IndexOf(',')
					,
				   newIdentity
			   );

				_rename._PathX.Modified_assumeRefPacElement(element, identity, newIdentity);
			}
			else
			{
				element.Remove();
			}

			return true;


		}





	}
}

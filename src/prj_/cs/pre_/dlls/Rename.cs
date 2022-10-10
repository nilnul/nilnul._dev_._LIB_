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

namespace nilnul.dev.src.prj_.cs.pre_.dlls
{
	static public class _RenameX
	{

		public static bool Changed_assumeCsPrj(FileI ee, dev.src.sln._nomina.Updates keyValues)
		{
			return Changed_assumeCsPrj(ee.file.en, keyValues);

		}

		public static bool Changed_assumeCsPrj(SpearI en, dev.src.sln._nomina.Updates keyValues)
		{
			return Changed_fileAssumeCsPrj(en.ToString(), keyValues);
		}

		static public bool Changed(nilnul.dev.src.prj_.Cs file, dev.src.sln._nomina.Updates keyValues)
		{
			return Changed_fileAssumeCsPrj(file.ToString(), keyValues);
		}
		static public bool Changed_fileAssumeCsPrj(string file, dev.src.sln._nomina.Updates keyValues)
		{
			var doc = XDocument.Load(file);
			var changed = Changed(
				doc
				, keyValues
			);

			if (changed)
			{
				doc.Save(file);

			}
			return changed;

		}




		static public bool Changed(XDocument doc, dev.src.sln._nomina.Updates keyValues)
		{

			var changed = false;
			_VwX.Els(doc).ToArray().Each(
				x =>
				{
					var identity = _VwX.Identity(x);
					var rewritten = dev.src.sln._nomina.Updates.Defaulted.rewritePrj(identity);
					if (rewritten != identity)
					{
						const string Attr = "Include";
						var oldValue = x.Attribute("Include").Value;

						x.Attribute("Include").Value = oldValue.Splice(
							0
							,
							oldValue.IndexOf(',')
							,
						   rewritten
					   );


						// change the hintPath


						var hintPathEl = x.XPathSelectElement("*[local-name() = 'HintPath']");
						if (hintPathEl is null)
						{


						}
						else
						{
							var oldVal = hintPathEl.Value??"";

							var newVal = 

									 Regex.Replace(
										oldVal
										,
										$@"^{Regex.Escape(identity)}|[/\\]{Regex.Escape(identity)}"
										,
										rewritten
									);
								
							if (newVal != oldVal)
							{
								hintPathEl.Value = newVal;
								//if (!changed)
								//{
								//	changed = true;

								//}
							}
						}



						if (!changed)
						{
							changed = true;
						}
					}
				}


		   );
			return changed;
		}





	}
}

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
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nilnul.dev.src.prj_.cs.pre_.dll.aliases
{
	static public class _EnsureX
	{

		public static bool Modified_assumeCsPrj(FileI ee, string refered, string alias)
		{
			return Modified_assumeCsPrj(ee.file.en, refered, alias);

		}

		public static bool Modified_assumeCsPrj(SpearI en, string refered, string alias)
		{
			return Modified_fileAssumeCsPrj(en.ToString(), refered, alias);
		}

		public static bool Modified_assumeCsPrj(ParentDoc file, Dictionary<string, string> dictionary)
		{
			return Modified_fileAssumeCsPrj(file.ToString(), dictionary);
		}

		static public bool Modified(nilnul.dev.src.prj_.Cs file, string refered, string alias)
		{
			return Modified_fileAssumeCsPrj(file.ToString(), refered, alias);
		}

		static public dev.prj_.cs.Modify Modify_fileAssumeCsPrj(string file, Dictionary<string, string> dictionary)
		{
			//var doc = XDocument.Load(file);

			var prjModi = new dev.prj_.cs.Modify(file);

			 Modify(prjModi.content, dictionary);
			return prjModi;

		}


		static public bool Modified_fileAssumeCsPrj(string file, Dictionary<string, string> dictionary)
		{
			var doc = XDocument.Load(file);

			var r = Modified(doc, dictionary);
			if (r)
			{
				doc.Save(file);

			}
			return r;

		}

		static public bool Modified_fileAssumeCsPrj(string file, string refered, string alias)
		{
			var doc = XDocument.Load(file);

			var r = Modified(doc, refered, alias);
			if (r)
			{
				doc.Save(file);

			}
			return r;

		}

		static public bool Modified_ofBlob(string xml, string refered, string alias)
		{
			return Modified(XDocument.Parse(xml), refered, alias);
		}

		static public bool Modified(XDocument doc, Dictionary<string, string> dict)
		{
			var r = doc.XPathSelectElements(
				"/*/*[local-name()='ItemGroup']/*[local-name()='Reference']"
			)
			;
			var changed = false;

			dict.Each(
				d =>
				{
					var refered = d.Key;
					var alias = d.Value;
					var r1 = r.Where(
						e => e.Attribute("Include").Value.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)[0].Trim() == refered
					);

					var t = r1.ToArray();


					t.Each(x =>
					{
						var aliasElement = x.XPathSelectElement(
							//"[local-name()='Aliases']"
							"*[local-name()='Aliases']"
						);


						if (aliasElement is null)
						{
							var aliasElementNew = new XElement(
								"Aliases"
								,
								$"global,{alias}"
							);
							x.Add(
								aliasElementNew
							);
							aliasElementNew.Name = aliasElementNew.Parent.GetDefaultNamespace() + aliasElementNew.Name.LocalName;
							if (!changed)
							{
								changed = true;

							}
						}
						else
						{
							if (string.IsNullOrWhiteSpace(aliasElement.Value))
							{
								aliasElement.Value = alias;
								if (!changed)
								{
									changed = true;

								}
							}
							else
							{
								if (!aliasElement.Value.Split(
									new[] { ',' },
									StringSplitOptions.RemoveEmptyEntries
								).Select(x1 => x1.Trim())
								.Contains(alias)
								)
								{
									aliasElement.Value += $",{alias}";
									if (!changed)
									{
										changed = true;

									}

								}
							}
						}
					}
				   );

				}
			);




			return changed;
		}

		static public void Modify(nilnul.xml.Edit doc, Dictionary<string, string> dict)
		{


			doc.touch(
				Modified(
					doc.xdoc,
					dict
				)
			);




		}

		static public bool Modified(XDocument doc, string refered, string alias)
		{
			var r = doc.XPathSelectElements(
				"/*/*[local-name()='ItemGroup']/*[local-name()='Reference']"
			)
			;


			r = r.Where(
				e => e.Attribute("Include").Value.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)[0].Trim() == refered
			);

			var t = r.ToArray();

			var changed = false;

			t.Each(x =>
			{
				var aliasElement = t.First().XPathSelectElement(
					//"[local-name()='Aliases']"
					"*[local-name()='Aliases']"
				);


				if (aliasElement is null)
				{
					var aliasElementNew = new XElement(
						"Aliases"
						,
								$"global,{alias}"
					);
					x.Add(
						aliasElementNew
					);
					aliasElementNew.Name = aliasElementNew.Parent.GetDefaultNamespace() + aliasElementNew.Name.LocalName;
					if (!changed)
					{
						changed = true;

					}
				}
				else
				{
					if (string.IsNullOrWhiteSpace(aliasElement.Value))
					{
						aliasElement.Value = alias;
						if (!changed)
						{
							changed = true;

						}
					}
					else
					{
						if (!aliasElement.Value.Split(
							new[] { ',' },
							StringSplitOptions.RemoveEmptyEntries
						).Select(x1 => x1.Trim())
						.Contains(alias)
						)
						{
							aliasElement.Value += $",{alias}";
							if (!changed)
							{
								changed = true;

							}

						}
					}
				}
			}
		   );


			return changed;
		}


	}
}

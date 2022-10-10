using nilnul.fs.address_.spear_;
using nilnul.obj.str.be_;
using nilnul.objs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nilnul.dev.prj_._cs_.evt_.build_.post
{
	static public class _OnUpdX
	{

		static public void Vod_ofFile(string file)
		{

			var xmlLoad = XDocument.Load(file, LoadOptions.PreserveWhitespace);
			var changed = false;

			var elName = "RunPostBuildEvent";
			var elVal = "OnOutputUpdated";

			var xpath4El = @"/*/*[local-name()='PropertyGroup']/*[local-name()='RunPostBuildEvent']";



			var el2search = xmlLoad.XPathSelectElements(xpath4El);

			if (el2search.Skip(1).Any())
			{
				throw new Exception($"plural {elName}s found for {elName}.");
			}


			if (el2search.Any())
			{
				if (
					!nilnul.txt.eq_.Trim.Singleton.Equals(

						el2search.First().Value
						,
						elVal

					)
				)
				{
					el2search.First().Value = elVal;
					changed = true;
				}

				goto save;

			}

			var propGrpS =
				"/*/*[local-name()='PropertyGroup']"
			;

			var lastProp2Search = xmlLoad.XPathSelectElements(propGrpS).LastOrDefault();
			var el = new XElement(
				"PropertyGroup"
				,
				new XElement(
					elName
					,
					elVal

				)
			);
			if (!(lastProp2Search is null))
			{

				lastProp2Search.AddAfterSelf(el);
			}
			else
			{
				xmlLoad.Root.Add(el);

			}
			el.DescendantsAndSelf().Each(
				x => x.Name = x.Parent.GetDefaultNamespace() + x.Name.LocalName

			);

			changed = true;
			goto save;

		save:
			if (changed)
			{
				xmlLoad.Save(
					file
					,
					 SaveOptions.DisableFormatting
				);

			}

		}


		public static void OfFile(nilnul.fs.address_.SpearI parentDoc)
		{
			Vod_ofFile(parentDoc.ToString());
		}
		static public void OfDoc(string file)
		{
			OfFile(
				nilnul.dev.src.sln.sub.prj.meta_._ChoosePrjX.Spear_ofDoc(file)
			);
		}

		static public void OfNomina(string identity)
		{


			var file = nilnul.dev.src.sln.sub.synd.prj_.cs._meta._LocateX.SpearNulable_ofMain(identity);
			OfFile(file);
		}

		public static void OfContainerAddress(string v)
		{

			OfFile(
				nilnul.fs.folder.doc_.deV_.prj_.Cs.Address_ofContainerAddress(v)
			);

		}
	}
}

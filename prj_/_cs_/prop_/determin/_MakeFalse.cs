using nilnul.dev.prj_.cs;
using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nilnul.dev.prj_._cs_.prop_.determin
{
	/*
	<PropertyGroup>
    
	    <Deterministic>true</Deterministic>
	</PropertyGroup>

	 */
	static public class _MakeFalse
	{
		static public void Vod(XElement el)
		{
			el.Value = "false";
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="determineEl"></param>
		/// <returns>true if changed; false otherwise</returns>
		static bool _ChangeEl(XElement determineEl)
		{
			if (
				!nilnul.txt.eq_.Trim.Singleton.Equals(

					determineEl.Value
					,
					"false"

				)
			)
			{
				Vod(determineEl);
				return true;
			}
			return false;
		}
		public static void Changed_makeFalse(Modify prjModify)
		{
			



			var xpath4El = @$"/*/*[local-name()='PropertyGroup']/*[local-name()='{prop_._Determin.ElName}']";

			var el2search = prjModify.xdoc.XPathSelectElements(xpath4El);

			if (el2search./*Skip(1).*/Any())
			{
				///for each compilationConfiguration, there might be one.
				///
				foreach (var item in el2search)
				{
					prjModify.touch(_ChangeEl(item));
				}
				return;

				//throw new Exception($"plural elements found for {prop_._Determin.ElName}.");
			}
	/*		
			if (el2search.Any())
			{
				var theEl = el2search.First();
				if (
					!nilnul.txt.eq_.Trim.Singleton.Equals(

						theEl.Value
						,
						"false"

					)
				)
				{
					Vod(theEl);
					prjModify.touch();
					return ;


				}

				else
				{
					return ;
				}

			}
	*/

			var propGrpS =
				"/*/*[local-name()='PropertyGroup']"
			;

			var firstProp2Search =prjModify.xdoc.XPathSelectElements(propGrpS).FirstOrDefault();

			XElement el ;
			if (firstProp2Search is null)
			{
				 el = new XElement(
					"PropertyGroup"
					,
					new XElement(
						prop_._Determin.ElName
						,
						"false"

					)
				);
				prjModify.xdoc.Root.Add(el);

			}
			else
			{
				 el = new XElement(
					"PropertyGroup"
					,
					new XElement(
						prop_._Determin.ElName
						,
						"false"

					)
				);

				firstProp2Search.AddBeforeSelf(el);

			}
			nilnul.xml.el.enclosed._RemoveEmptyNsX.RemoveEmptyNs(el);
			prjModify.touch();
			return ;

		}

		static public bool Changed_makeFalse(XDocument xmlLoad)
		{



			var xpath4El = @$"/*/*[local-name()='PropertyGroup']/*[local-name()='{prop_._Determin.ElName}']";

			var el2search = xmlLoad.XPathSelectElements(xpath4El);

			if (el2search.Skip(1).Any())
			{
				throw new Exception($"plural elements found for {prop_._Determin.ElName}.");
			}

			if (el2search.Any())
			{
				var theEl = el2search.First();
				if (
					!nilnul.txt.eq_.Trim.Singleton.Equals(

						theEl.Value
						,
						"false"

					)
				)
				{
					Vod(theEl);
					return true;


				}

				else
				{
					return false;
				}

			}

			var propGrpS =
				"/*/*[local-name()='PropertyGroup']"
			;

			var firstProp2Search = xmlLoad.XPathSelectElements(propGrpS).FirstOrDefault();

			XElement el ;
			if (firstProp2Search is null)
			{
				 el = new XElement(
					"PropertyGroup"
					,
					new XElement(
						prop_._Determin.ElName
						,
						"false"

					)
				);
				xmlLoad.Root.Add(el);

			}
			else
			{
				 el = new XElement(
					"PropertyGroup"
					,
					new XElement(
						prop_._Determin.ElName
						,
						"false"

					)
				);

				firstProp2Search.AddBeforeSelf(el);

			}
			nilnul.xml.el.enclosed._RemoveEmptyNsX.RemoveEmptyNs(el);
			return true;

		}


		static public void Vod_ofFile(string file)
		{

			var xmlLoad = XDocument.Load(file, LoadOptions.PreserveWhitespace);


			
			if (Changed_makeFalse(xmlLoad) )
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
		static public void OfDoc(string doc)
		{
			OfFile(
				nilnul.dev.src.sln.sub.synd._prj._LocateX.Spear_ofDoc(doc)
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



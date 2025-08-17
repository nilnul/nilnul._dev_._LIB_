using nilnul.fs.address_.spear_;
using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nilnul.dev.prj_.sql._meta_.document_.build
{
	/// <summary>
	/// change build to none, such that the files in this project are scripts to run, not to build for publishing into a db at the server.
	/// </summary>
	static public class ToNoneX
	{
		static public void ToNone_assumeBuildEl(XElement el)
		{
			//var newEl = new XElement(el);
			//newEl.Name = el.Name.Namespace + "";
			//el.ReplaceWith(
			//	new XElement(
			//);
			el.Name = el.Name.Namespace + "None";
		}
		static public bool ToNone_assumeBuildEls(IEnumerable<XElement> els)
		{
			if (els.Any())
			{
				els.Each(
							e => ToNone_assumeBuildEl(e)
						);
				return true;
			}
			return false;

		}

		static public bool BuildsToNones(XDocument doc)
		{
			return ToNone_assumeBuildEls(
				doc.XPathSelectElements(
					 @"/*/*[local-name()='ItemGroup']/*[local-name()='Build']"
				)
			);
		}

		static public bool OfPrj_assumeSql(string prj) {
			var doc = XDocument.Load(prj);
			var changed= BuildsToNones(
				doc
			);
			if (changed)
			{
				doc.Save(prj);
			}
			return changed;
		}

		private static bool OfPrj(nilnul.fs.file_.ext_.deV_.Sqlproj parentDoc)
		{
			return OfPrj_assumeSql(parentDoc.ToString());
		}

		private static bool OfPrj(nilnul.fs.address_.SpearI parentDoc)
		{
			return OfPrj(new fs.file_.ext_.deV_.Sqlproj(parentDoc));
		}


		static public bool OfPrjNomina(string prjNomina) {
			return OfPrj(
				raw.sln.sub.synd.prj_._sql._LocateX.Spear_ofMain(prjNomina)
			);
		}

	}
}

using nilnul.fs.address_.spear_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nilnul.dev.prj_.cs_._lib_.evt_.build_.post
{
	static public class _UpdX
	{

		static public void _OfFile(string file)
		{
			

			//file = nilnul.dev.src.sln.sub.synd.prj_.cs._meta._LocateX.Spear_ofMain("nilnul._txt_._LIB_").ToString();
			var xmlLoad = XDocument.Load(file);
			var xpath =
				"/*/*[local-name()='PropertyGroup']/*[local-name()='PostBuildEvent']"
			;

			var element = xmlLoad.XPathSelectElement(xpath);
			element.Value = _upd.RscX.TxtNoRem();
			xmlLoad.Save(
				file
			);

		}


		public static void OfFile(nilnul.fs.address_.SpearI parentDoc)
		{
			_OfFile(parentDoc.ToString());
		}
		static public void OfDoc(string file)
		{
			OfFile(
				nilnul.dev.src.sln.sub.prj.meta_._ChoosePrjX.Spear_ofDoc(file)
			);
		}


	}
}

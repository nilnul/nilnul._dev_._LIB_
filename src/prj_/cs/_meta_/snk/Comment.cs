using nilnul.fs.address_.spear_;
using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nilnul.dev.src.prj_.cs._meta_.snk
{
	/// <summary>
	/// edit the project file, and comment out the settings that introduces ".snk"
	/// </summary>
	static public class _CommentOutX
	{
		static public void Vod(
			string prjFile
		)
		{
			var xml = XDocument.Load(prjFile);

			///find the elemnt
			///
			//var el=xml.Element("AssemblyOriginatorKeyFile");

			//el.ReplaceWith(
			//	new XComment(
			//		el.ToString()
			//	)
			//);

			var xpath = "/*/*[local-name()='PropertyGroup']/*[local-name()='SignAssembly']";

			var el1 = xml.XPathSelectElements(xpath).SingleOrDefault();

			if (!(el1 is null))
			{

				el1.ReplaceWith(
					new XComment(
						el1.ToString()
					)
				);

				xml.Save(prjFile);

			}





		}

		public static void Vod(ParentDoc parentDoc)
		{
			Vod(parentDoc.ToString());
		}

		public static void Vod_ofNomina(string nomina)
		{
			Vod(
				nilnul.dev.src.sln.sub.synd.prj_.cs._meta._LocateX.SpearNulable_ofMain(nomina)
			);
		}

	}
}

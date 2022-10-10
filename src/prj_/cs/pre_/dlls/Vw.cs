using nilnul.fs;
using nilnul.fs.address_;
using nilnul.fs.address_.spear_;
using NuGet.Packaging.Core;
using NuGet.Versioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nilnul.dev.src.prj_.cs.pre_.dlls
{
	static public class _VwX
	{
		public const string XPATH = "/*/*[local-name()='ItemGroup']/*[local-name()='Reference']";
		static public IEnumerable<XElement> Els(XDocument doc)
		{
			return doc.XPathSelectElements(
				XPATH
			);
		}

		public static IEnumerable<XElement> Els_assumeCsPrj(FileI ee)
		{
			return Els_assumeCsPrj(ee.file.en);

		}

		static public IEnumerable<XElement> Els_fileAssumeCsPrj(string file)
		{

			return Els( XDocument.Load(file));

		}
		public static IEnumerable<XElement> Els_assumeCsPrj(SpearI en)
		{
			return Els_fileAssumeCsPrj(en.ToString());
		}

		static public IEnumerable<XElement> Els(nilnul.dev.src.prj_.Cs file)
		{
			return Els_fileAssumeCsPrj(file.ToString());
		}

		static public IEnumerable<XElement> Els_assumeIdenty(string file)
		{

			return Els_assumeCsPrj(
				nilnul.dev.src.sln.sub.synd.prj_.cs._meta._LocateX.SpearNulable_ofMain(file)
			);

		}

		static public IEnumerable<XElement> Els_ofBlob(string xml)
		{
			return Els(XDocument.Parse(xml));
		}




		static public IEnumerable<(string, nilnul.obj_.deV_.pkg._identity.VersionA)> Versioneds(XDocument doc)
		{
			var txts = Els(doc).Select(
				e=> {
					var props=e.Attribute("Include").Value.Trim().Split(',');

					var iden = props.First().Trim();
					var skipped = props.Skip(1);

					var ver=skipped.Select(
						x=>x.Split('=').Select(aa=>aa.Trim())
					).FirstOrDefault(
						y=> y.First()=="Version"
					)?.Last();

					if (ver is null)
					{
						return (iden, (nilnul.obj_.deV_.pkg._identity.VersionA)null);
					}
					else
					{
						return (iden, nilnul.obj_.deV_.pkg._identity._VersionX.Parse(ver));
					}
				}
			);
			return txts;
			
		}
		static public IEnumerable<(string, nilnul.obj_.deV_.pkg._identity.VersionA)> Versioneds_fileAssumeCsPrj(string file)
		{

			return Versioneds(XDocument.Load(file));

		}

		public static IEnumerable<(string, nilnul.obj_.deV_.pkg._identity.VersionA)> Versioneds(ParentDoc prjFile1)
		{
			return Versioneds_fileAssumeCsPrj(prjFile1.ToString());
		}

		static public IEnumerable<AssemblyName> Assemblies(XDocument doc)
		{
			var txts = Els(doc).Select(
				e=> {
					var props = e.Attribute("Include").Value.Trim();
					return new AssemblyName(props);
				}
			);
			return txts;
		}
		static public  string Identity(XElement e)
		{
			return pre_._DllX.Identity(e);
			;
		}

		static public IEnumerable< string> Identities(XDocument doc)
		{
			return Els(doc).Select(
				e=>new string(
					e.Attribute("Include").Value.Trim().TakeWhile(c=>c!=',').ToArray()
				)
			);
		}


		static public IEnumerable<nilnul.obj_.deV_.pkg.Identity> Versioneds_verPerPath(XDocument document)
		{
			var els = dlls._VwX.Els(document);

			return els.Select(
				e => new nilnul.obj_.deV_.pkg.Identity(
					_DllX.Identity(e)
					,
					dll.path._VersionX.VersionNulable(e)
				)

			);

		}
		static public IEnumerable<nilnul.obj_.deV_.pkg.Identity> Versioneds_verPerPath_ofPrjMeta(string document)
		{
			return Versioneds_verPerPath(
				XDocument.Load(document)
			);
		}
		private static IEnumerable<nilnul.obj_.deV_.pkg.Identity> Versioneds_verPerPath(nilnul.fs.address_.SpearI parentDoc)
		{
			return Versioneds_verPerPath_ofPrjMeta(parentDoc.ToString());
		}
		static public IEnumerable<nilnul.obj_.deV_.pkg.Identity> Versioneds_verPerPath__ofPrjIdenty(string document)
		{
			return Versioneds_verPerPath(
				nilnul.dev.src.sln.sub.synd.prj_.cs._meta._LocateX.SpearNulable_ofMain(document)
			);
		}




	}
}

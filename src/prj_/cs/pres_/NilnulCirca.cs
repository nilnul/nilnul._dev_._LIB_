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

namespace nilnul.dev.src.prj_.cs.pres_
{
	/// <summary>
	/// project reference, with reference of dll from installed package
	/// </summary>
	static public class _NilnulCircaX
	{

		public static IEnumerable<string> Nominas_assumeCsPrj(FileI ee)
		{
			return Nominas_assumeCsPrj(ee.file.en);

		}

		public static IEnumerable<string> Nominas_assumeCsPrj(SpearI en)
		{
			return Nominas_fileAssumeCsPrj(en.ToString());
		}

		static public IEnumerable<string> Nominas_assumePrjNomina(string file)
		{
			return Nominas_assumeCsPrj(
				nilnul.dev.src.sln.sub.synd.prj_.cs._meta._LocateX.SpearNulable_ofMain(file)
			);
		}


		static public IEnumerable<string> Nominas(nilnul.dev.src.prj_.Cs file)
		{
			return Nominas_fileAssumeCsPrj(file.ToString());
		}

		static public IEnumerable<string> Nominas_fileAssumeCsPrj(string file)
		{

			return Nominas( XDocument.Load(file));

		}
		static public IEnumerable<string> Nominas_ofBlob(string xml)
		{
			return Nominas(XDocument.Parse(xml));
		}

		static public IEnumerable<string> Nominas(XDocument doc)
		{

			return pres._VwX.Identities(doc).Where(
				s=>
				nilnul.obj_.deV.identy.be_.NilnulCirca.Singleton.be(s)
			);
		}

		static public IEnumerable<(string, nilnul.obj_.deV_.pkg._identity.VersionA)> Identities(XDocument doc)
		{

			return pres._VwX.Versioneds(doc).Where(
				s=>
				nilnul.obj_.deV.identy.be_.NilnulCirca.Singleton.be(s.Item1)
			);
		}

		static public IEnumerable<AssemblyName> Assemblies(XDocument doc)
		{

			return pres._VwX.Assemblies(doc).Where(
				s=>
				nilnul.obj_.deV.identy.be_.NilnulCirca.Singleton.be(s.Name)
			);
		}
		public static IEnumerable<AssemblyName> Assemblies_ofFile(string file)
		{
			return Assemblies( XDocument.Load(file));

		}

		public static IEnumerable<(string, nilnul.obj_.deV_.pkg._identity.VersionA)> Versioneds_ofFile(string file)
		{
			return Identities( XDocument.Load(file));

		}

		public static IEnumerable<(string, nilnul.obj_.deV_.pkg._identity.VersionA)> Versioneds(ParentDoc prjMeta)
		{
			return Versioneds_ofFile( prjMeta.ToString());

		}

		public static IEnumerable<AssemblyName> Assemblies_ofFile(nilnul.fs.address_.SpearI prj)
		{
			return Assemblies_ofFile(prj.ToString());
		}
	}
}

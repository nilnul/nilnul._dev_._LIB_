using nilnul.fs;
using nilnul.fs.address_;
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

namespace nilnul.dev.src.prj_.cs.pres
{
	/// <summary>
	/// project reference, with  reference of dll from installed package
	/// </summary>
	static public class _VwX
	{

		public static IEnumerable<string> Identities_assumeCsPrj(FileI ee)
		{
			return Identities_assumeCsPrj(ee.file.en);

		}

		public static IEnumerable<string> Identities_assumeCsPrj(SpearI en)
		{
			return Identities_fileAssumeCsPrj(en.ToString());
		}

		static public IEnumerable<string> Identities_assumePrjNomina(string file)
		{
			return Identities_assumeCsPrj(
				nilnul.dev.src.sln.sub.synd.prj_.cs._meta._LocateX.SpearNulable_ofMain(file)
			);
		}
		static public IEnumerable<string> Identities(nilnul.dev.src.prj_.Cs file)
		{
			return Identities_fileAssumeCsPrj(file.ToString());
		}


		static public IEnumerable<string> Identities_fileAssumeCsPrj(string file)
		{

			return Identities( XDocument.Load(file));

		}
		static public IEnumerable<string> Identities_ofBlob(string xml)
		{
			return Identities(XDocument.Parse(xml));
		}


	
		static public IEnumerable<string> Identities(XDocument doc)
		{

			return pre_.dlls._VwX.Identities(doc).Concat(
				pre_.raws._VwX.Identities(doc)
			);
		}

		static public IEnumerable<(string, nilnul.obj_.deV_.pkg._identity.VersionA)> Versioneds(XDocument doc)
		{

			return pre_.dlls._VwX.Versioneds(doc).Concat(
				pre_.raws._VwX.Identities(doc).Select(x=>(x, null as nilnul.obj_.deV_.pkg._identity.VersionA) )
			);
		}
		/// <summary>
		/// some System references is version less.
		/// </summary>
		/// <param name="doc"></param>
		/// <returns></returns>
		static public IEnumerable<AssemblyName> Assemblies(XDocument doc)
		{

			return pre_.dlls._VwX.Assemblies(doc).Concat(
				pre_.raws._VwX.Identities(doc).Select(x=> new AssemblyName(x) )
			);
		}


		
		public static IEnumerable<AssemblyName> Assemblies_ofFile(string file)
		{
			return Assemblies(XDocument.Load(file));

		}

		public static IEnumerable<(string, nilnul.obj_.deV_.pkg._identity.VersionA)> Versioneds_ofFile(string file)
		{
			return Versioneds(XDocument.Load(file));

		}

		public static IEnumerable<(string, nilnul.obj_.deV_.pkg._identity.VersionA)> Versioneds(nilnul.fs.address_.SpearI prjMeta)
		{
			return Versioneds_ofFile(prjMeta.ToString());

		}

		public static IEnumerable<AssemblyName> Assemblies_ofFile(nilnul.fs.address_.SpearI prj)
		{
			return Assemblies_ofFile(prj.ToString());
		}

	}
}

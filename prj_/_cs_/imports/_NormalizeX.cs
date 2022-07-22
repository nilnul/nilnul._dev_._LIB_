using nilnul.fs.address_.spear_;
using nilnul.obj.str.be_;
using nilnul.objs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nilnul.dev.prj_._cs_.imports
{
	static public class _NormalizeX
	{

		
		static public string Changed(string xDoc)
		{
			return Regex.Replace(
				xDoc,
				@"
					(""|'|<HintPath>)
					((\.\.\\)*\(packages\))\\
				"
,
				(m) => {
					return m.Result(@"$1packages\");
				}
				,
				RegexOptions.IgnorePatternWhitespace
			);

			

		}

		static public bool _OfFile(string file)
		{

			var xDoc = System.IO.File.ReadAllText(file);

			var changed = Changed(xDoc);
			if (changed ==xDoc)
			{
				return false;
			}

			System.IO.File.WriteAllText(file, Changed(xDoc) );
			return true;

		}
		public static bool OfFile(nilnul.fs.address_.SpearI parentDoc)
		{
			return  _OfFile(parentDoc.ToString());
		}
		static public bool OfDoc(string file)
		{
			 return OfFile(
				nilnul.dev.src.sln.sub.prj.meta_._ChoosePrjX.Spear_ofDoc(file)
			);
		}

		static public bool OfIdentity(string identity)
		{


			var file = nilnul.dev.src.sln.sub.synd.prj_.cs._meta._LocateX.SpearNulable_ofMain(identity);
			return  OfFile(file);
		}

		public static bool OfContainerAddress(string v)
		{

			return  OfFile(
				nilnul.fs.folder.doc_.deV_.prj_.Cs.Address_ofContainerAddress(v)
			);

		}
	}
}

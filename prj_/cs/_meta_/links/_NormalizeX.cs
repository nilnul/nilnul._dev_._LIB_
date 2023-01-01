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

namespace nilnul.dev.prj_.cs._meta_.links
{
	/// <summary>
	/// normalize relative path, to the subdir which might be a symlink
	/// </summary>
	///

	//[Obsolete(nameof(links.norm_._DottedX))]
	static public class _NormalizeX
	{

		
		static public string Change_ofClob(string xDoc)
		{

			//return links.norm_._DottedX.Changed(xDoc);
			var r = Regex.Replace(
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
			return r;
		

			

		}

		//public static void _Modify(Modify prjModify)
		//{
		//	var old = prjModify.content.xdoc.ToString();
		//	var r = Changed(old);
		//	if (r==old)
		//	{
		//		return;
		//	}
		//	//prjModify.content.xdoc.repl

		//}
		static public bool _OfFile(string file)
		{

			var xDoc = System.IO.File.ReadAllText(file);

			var changed = Change_ofClob(xDoc);
			if (changed ==xDoc)
			{
				return false;
			}

			System.IO.File.WriteAllText(file, changed );
			return true;

		}
		public static bool OfMeta(nilnul.fs.address_.SpearI parentDoc)
		{
			return  _OfFile(parentDoc.ToString());
		}
		static public bool OfDoc(string file)
		{
			 return OfMeta(
				nilnul.dev.src.sln.sub.prj.meta_._ChoosePrjX.Spear_ofDoc(file)
			);
		}

		static public bool OfIdentity(string identity)
		{


			var file = nilnul.dev.src.sln.sub.synd.prj_.cs._meta._LocateX.SpearNulable_ofMain(identity);
			return  OfMeta(file);
		}

		public static bool OfContainerAddress(string v)
		{

			return  OfMeta(
				nilnul.fs.folder.doc_.deV_.prj_.Cs.Address_ofContainerAddress(v)
			);

		}

	}
}

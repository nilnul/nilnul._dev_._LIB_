using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.fs.address_.spear_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj.be_.cs_
{
	static public class _LibX
	{

		public static bool Be_assumePrj(fs._address._route.division_._div._dir.dnt_.Exted exted)
		{
			return
				 nilnul.fs._address._route.division_._div._dir.dnt_._exted.ext.Eq.Singleton.eq(
				exted.ext
				,
				".csproj"
				)
				 &&
				 nilnul.dev.src.prj_.cs.be_.Lib.Be_ofMain(exted.stub)

				;


		}

		static public bool Be_docAssumePrj(string identity)
		{

			return Be_assumePrj(nilnul.fs._address._route.division_._div._dir.dnt_.Exted.Parse(identity));






		}
		private static bool Be_assumePrj(DocI doc)
		{
			return Be_assumePrj(
				nilnul.fs._address._route.division_._div._dir.dnt_.Exted.Ov(
					nilnul.fs._address._route.division_._div._dir.dnt._RegressionsX.ToNew(
					doc
					)
				)
			);
			//throw new NotImplementedException();
		}


		static public bool Be_assumePrj(nilnul.fs.address_.spear_.based_.Child parent)
		{
			return Be_docAssumePrj(parent.doc.ToString());
		}

		public static bool Be_assumePrj(ParentDoc located)
		{
			return Be_assumePrj(located.doc);
			//throw new NotImplementedException();
		}


		static public bool Be_assumePrj(string _csPrj)
		{

			return Be_assumePrj(
nilnul.fs.address_.spear_.based_.Child.Parse(_csPrj)
			);
		}

	}
}

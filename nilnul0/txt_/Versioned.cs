using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.txt_
{
	/*
	 eg:
		abc.def.ghij12.3123.58
			in comparision with Pac dir name such as "abc.def.ghij.12.3123.58", we don't need the "." to separate between identy and version.
		abc.def3.ghij.ClassName123
			according to our rule, the 123 shall be interpreted as the version for the whole identy's nominal "abc.def3.ghij.ClassName", not the ver for the id's nom "ClassName"
				This is in line with our infoGrow model in that the "123", as a qualifier,  shall include the whole precedent as the qualified.
				to make 123 the ver for only "ClassName", change the above to "abc.def3.ghij.ClassName123__567", where 123 is the ver for only "ClassName", and 567 is the whole version for the whole nomina "abc.def3.ghij.ClassName123__". Note here we need to use double "_", as a single "_" is interpreted as part of the ver "123_567"
		abc.def3.ghij.ClassName123__3.23.593.123b
			where "abc.def3.ghij.ClassName123__" is the nomina, and  "3.23.593.123b" is the version
		
		abc.def3.ghij.ClassName123__.3.23.593.123b
			where "abc.def3.ghij.ClassName123__." is the nomina, and  "3.23.593.123b" is the version
				note here we take the "." as the end of the nomina.

	we also call "Versioned" as "Identy", in analog with "Vered" as "Id"


	Versioned/Vered is a concept in nilnul.txt, and Id/Identity is a concept in Dev.
		for example,
			nilnul.dev.sln.Identy,
			nilnul.dev.prj.Identy
			nilnul.fs.git.managed.Identy

			nilnul.fs._address._route.division_._div._dir.dnt.Identy
			nilnul._obj.typ._identy.Versioned
			nilnul.obj.var._identy.Versioned

	cuz "nilnul.txt" comes before "nilnul.dev", so "Version" parse takes precedence - we peel off the version first before proceding to parse it as a dev caption.
		for example, NumA1, not Num1A, as "A" means abstract class, and is a concept of "nilnul.Dev", so "A" shall be immediatly after Num the type.



	note a132 is an id, where the single letter nom "a" implies this is a temporary, interim, or transient variable.
		for type, the nom must be at leat two chars.

	 */
}

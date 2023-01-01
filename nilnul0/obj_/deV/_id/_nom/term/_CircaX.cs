using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._id._nom.idiom
{
	/// <summary>
	/// eg:
	///		_class_ of "class".
	///	not:
	///		_classA_ of "classA", as nom "classA" shall be stripped of affixes to "class"
	/// </summary>
	static public class _CircaX
	{
		static public string Pre(string x) {
			return $"_{x}";
		}

		static public string Between(string x) {
			return $"_{x}_";
		}

		static public string Aft(string x) {
			return $"{x}_";
		}

		/*
		_someTerm
			prior to someTerm
		someTerm_
			subtype of someTerm
		_someTerm_
			inner of some term
		"someTerm."
			note with the suffixed ".", meas extension/posterior

		 */
	}
}

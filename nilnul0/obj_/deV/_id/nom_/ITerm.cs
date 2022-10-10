using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._id._nom
{
	/// <summary>
	/// at least one character.
	/// eg:
	///		a
	///		ab
	///	not eg:
	///		""
	///		_a
	///			a is a term, but _a is not
	///		_
	///		a_
	///			but a is a term
	///		__
	///		_ab_
	///			ab is a term, but _ab_ is not <see cref="term.ICirca"/>
	///		
	/// </summary>
	/// <remarks>
	/// alias:
	///		term
	///			temp
	///				same initial
	///		
	/// vs nom:
	///		in common:
	///			AbcDef4hh is a nom, and a term.
	///		different:
	///		in length:
	///			"" is not a term, as it doesnot contain more than nil letter, but is a nom
	///		in circa:
	///			_ab_ is nom, but only ab is term
	///		in affix:
	///			ExtensionX is nom, whileas "Extension" without the suffix "X" is term, and X is also a term
	/// </remarks>
	public interface ITerm
	{
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._id
{
	/// <summary>
	/// at least one letter. for nil lettered ones, <see cref="obj_.deV.IWord0empty"/>
	/// in an identifier, the part before a num, which is a version
	/// eg:
	///		"abc" in "abc"
	///		"abc" in "abc1"
	///		"abc" in "abc123"
	///		_abc_ in _abc_1
	///		_abc_ in _abc_1(comment
	///		_abc_ in _abc(comment)_1
	///			this is a nom vered and then commented.
	///				used in naming dir.
	/// no dot. no version at the end. can be camelCase
	///		_ in "_1"
	/// 
	/// </summary>
	/// <remarks>
	/// alias:
	///		nom, nomination, nomanclature, nominal
	///		 term, or term with affix
	///	--------------------
	///	definition is :
	///		1) give a name
	///		2) give a meaning, which is paraphrased by known definitions/names.
	/// </remarks>
	/// 
	public interface INom
	{
	}
}




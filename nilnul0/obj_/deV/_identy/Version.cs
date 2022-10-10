using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV.identy._versioned
{
	/// <summary>
	///	note here
	///		the version vs the ver:
	///			version is multiple part, ver is one part that is a natural num
	///				but ver is later extended to include single-letter switch that follows the first char.
	///					the switch can be punc like "."
	/// </summary>
	/// <remarks>
	/// <see cref="nameof(nilnul.txt_._versioned.IVersion)"/>
	/// </remarks>

	interface IVersion
		:
		nilnul.txt_._versioned.IVersion		//separated by ".". when used in nugetPac dir, led by "." when appended to identity. in nodeJs, "@" is prepended instead of ".".
	{
	}
}

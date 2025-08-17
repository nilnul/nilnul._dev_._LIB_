using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._identifier
{
	/// <summary>
	///	a four part pure numbered; <see cref="System.Version"/>
	/// </summary>
	/// <remarks>
	/// for <see cref="nilnul.dev.raw"/>, <see cref="nilnul.txt_._versioned.IVersion"/> is enough; we often only use major and minor;
	/// for <see cref="nilnul.dev.pak"/>, <see cref="nilnul.dev._pak.Versionary"/> with tags are used. we often use patch, build, and tags for a build;
	/// 
	/// </remarks>
	///	vs:
	///		the version vs the ver:
	///			version is multiple part, ver is one part that is a natural num
	///				but ver is later extended to include single-letter switch that follows the first char.
	///					the switch can be punc like "."
	///	vs:
	///		<see cref="nilnul.txt_._versioned.IVersion"/>, which can contain 0 or more than four ver, and which can has other separator than '.';
	///
	/// extension:
	///		<see cref="nilnul.dev.raw.IVersion"/> later;
	///		

	public interface IVersion
		:
		nilnul.txt_._versioned.IVersion		/// /separated by ".". When used in nugetPac dir, led by "." when appended to identity. in nodeJs, "@" is prepended instead of ".".
	{
	}
}

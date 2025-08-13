using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._identifier._version.minor.be_
{
	/// <summary>
	/// In software versioning, even numbers often represent stable versions, while odd numbers represent development versions. Many would use this interpretation for <see cref="_version.IMajor"/>, but in nilnul, we use apply it in <see cref="_version.IMinor"/>;
	/// </summary>
	/// The reason is that, 2.0, where 0 is even, and we can use 2 for short as a stable version.
	/// <remarks>
	/// 
	/// eg:
	///		:For example, in Node.js, odd-numbered versions are used by users and package authors to preview upcoming features, while even-numbered versions become Long-Term Support (LTS) releases.
	///		:Before 2004, Linux used an odd-even system where odd-numbered versions were development releases and even-numbered versions were stable releases. For example, Linux 2.3 was a development version, and Linux 2.4 was the stable release that followed.
	///	Note: 0 is regarded as regularly even here. For special treatment of 0, <see cref="_version.major_.INil"/>

	/// </remarks>
	/// alias:
	///		even0odd
	///		parity
	/// 
	internal class IParity
	{
	}
}

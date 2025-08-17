using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._identifier._version_
{
	/// <summary>
	/// "build" is reserved for different building (using different building settings or tools) on same source code;
	/// </summary>
	/// <remarks>
	/// it can be based on a timestamp <see cref="nilnul.time.texfy_.full_"/>, or <see cref="nilnul._time.clock.phrase_"/> as <see cref="nilnul._time.date.phrase_"/> has already embodied by <see cref="_version.IPatch"/>
	/// </remarks>
	/// vs
	///		:<see cref="nilnul.dev.raw.IVersion"/>, where there is no build
	///		<see cref="nilnul.dev.raw._version_.IPatch"/>, where it's one of git snap which is src state at any expressible times;
	internal class IBuild
	{
	}
}

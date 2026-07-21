using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._identy._nomina._sur
{
	///	aggressively abbreviated, to a single word.
	///	
	/// <summary>
	/// No dot shall appear anywhere in a seg.
	/// eg:
	///		"abc" in "nilnul.abc.Def"
	///	;seg better be a single word. If it's a multiple-word idiom, try to break that into a few segs.
	/// </summary>
	/// 
	/// <remarks>
	/// <see cref="_nomina.ILocal"/> uses full name, and this uses abbreviated name, as this is part of a long identy that is open to further grow, while <see cref="_nomina.ILocal"/> is closed to further growth;
	/// </remarks>
	/// 
	///	alias:
	///		seg
	///		term
	public interface ISeg
		:
		nilnul.txt_.IId
	{

	}
}

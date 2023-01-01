using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._id._nom.idiom.suffixed_.plural_
{


	/// <summary>
	/// convert to a collective word, by appending s, if term is only one casible, or "S", if term has plural casibles.
	/// CourseSessionS denotes str of courseSession whileas CourseSessions denote sessions of Course.
	/// SemesterCourseSessionS denotes str of SemesterCourseSession, not CourseSessionS of semester
	/// 
	/// </summary>
	/// <remarks>
	///
	///	We shall avoid this usage for:
	///		CourseSessionSHelper
	///			But the above will not confuse in that S and H will not be taken as word as we restricted one-letter word.
	///
	/// CourseSession_S
	/// </remarks>
	///
	[Obsolete(nameof(idiom_.IEsEd), true)]

	static public class _SierraX
	{
		static public string _Op(string txt) {
			//if (txt.EndsWith("ses"))
			//{
			//	return txt + "es"; //recursively 
			//}
			//if (txt.EndsWith("S"))
			//{
			//	return txt + "es"; //recusively
			//}
			return txt + "S";
		}

	}
}

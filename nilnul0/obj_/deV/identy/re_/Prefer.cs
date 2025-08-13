using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV.identy.re_
{
	/// <summary>
	/// eg: for,
	///		nilnul.txt_.word_.Vered
	///		vs:
	///			nilnul.txt_.vered_.Word
	///	word_.Vered is preferred, as word_.Vered is an interpretation of word, a conversion from word to Vered will not throw exception; but vered to word is a <see cref="nilnul.obj.vow.ee_"/>, which might throw exception in such case like: "a.b1.1.23", which is not a word, but a vered, where "23" is the ver;
	/// </summary>
	/// <remarks>
	/// the vendor's id shall be put last to maintain a bigger scope of application. eg: nilnul.task.schedule_.byTimeZone_.ByVendor is preferred to byVendor_.ByTimeZone;
	/// </remarks>
	/// alias:
	///		preferred
	///		preferrence
	///		canonical
	internal class Prefer
	{
	}
}

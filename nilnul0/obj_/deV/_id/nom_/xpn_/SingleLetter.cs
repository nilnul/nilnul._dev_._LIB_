using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._id.nom_.xpn_
{
	// single letter idiom is not counted into the id.
	/// <summary>
	/// single letter is reserved for temp/interim, or variable, or sepcial meaning (for example, NumA, where A means abstract)
	/// So single letter cannot be used as the nom of id.
	/// <see cref="nameof(nilnul.txt_.VeredI1)"/> can allow the basis to be a single letter (in fact it can even allow empty txt as basis). nilnul.txt_.vered_.SingleLetter can be used to denote the interim variable/class name
	/// <seealso cref="nameof(nilnul.txt_._versioned.version_.LetterEnd)"/>. when a letter ends a version, that version is open and hence interim.
	/// </summary>
	/// <remarks>
	/// becuz this is used locally, we don't define this as a type, which is used globally
	/// </remarks>

	[Serializable]
	public class SingleLetterReservedForVarException : Exception
	{
		public SingleLetterReservedForVarException() { }
		public SingleLetterReservedForVarException(string message) : base(message) { }
		public SingleLetterReservedForVarException(string message, Exception inner) : base(message, inner) { }
		protected SingleLetterReservedForVarException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
	/// <summary>
	/// single letter is reserved for:
	///		temprary use
	///		local use.
	///	eg:
	///		a local variable "t", or, if vered as Id, "t1"
	/// not:
	///		"A" in "RealNumberA", meaning "abstract". Even "A" is single letter, it is not used indepently. So it's not defined here; rather, it's defined in "idiom.Affixed"
	/// </summary>
	public interface ISingleLetter
	{
	}
}

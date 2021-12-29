using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.type
{
	/// <summary>
	/// identifier, including name and version. name denotes the stub/innate/unchanged, version denotes evolution.
	/// This is used in naming  a type; for namespace segment, use id.Circa, or _id._nom.idiom.Circa
	/// no "dot" is allowed.
	/// no other punctuation is allowed
	/// </summary>
	/// <remarks>
	/// alias:
	///		identifier
	///		caption
	///		title
	///		subject
	///		topic
	///		address
	///		name
	///	vs:
	///		identity:
	///			a1.b2.c3.D4,
	///			whileas id: is a1
	///					that is, identity is a str of id
	///			
	/// </remarks>
	public interface IId
	{

	}
}

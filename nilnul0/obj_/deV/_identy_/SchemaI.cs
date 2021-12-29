using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._identy_
{
	/// <summary>
	/// any id is interpreted under a context. ids are distinct in a context.
	/// To make a name portable, we shall zeroize the context. Such context is a special context: "global"; in C#, we can use "global::" to leading a full name.
	/// a special namespaceSegment is phrased as "nilnul". this segment shall not be used other than the first place, making any full name beginning with "nilnul." a portable name. Other topNamespaceSegment can be registered like the way domain name is registered; such as wyt, wangyoutian
	/// </summary>
	/// <remarks>
	/// alias:
	///		frame
	///		,
	///		context
	///		,
	///		sur
	///		
	/// </remarks>

	public interface NamespaceI
	{
		_identy.Sur sur { get; }
	}
}

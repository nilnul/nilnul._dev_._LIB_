using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV
{
	/// <summary>
	/// a namespace/schema/context and an id. id in a context/realm/domain. contextual id. absoluted id
	/// eg:
	///		nilnul.num.Real1        #where Real1 is an ID, where 1 is the ver of ID
	///
	///  identity is used to identify something in src, so version is not applicable. version is a concept in compiling and packing
	/// </summary>
	/// <remarks>
	/// nomanclature:
	///		in dev.Src, the src code, for example, an identifier, donot have the luxuray to append a multipart version such as "1.2.3". only a simple ver such as 1 can be appended to the nom in an Id, which in turn constitute the whole identity
	/// note:
	///		identity doesnot include version, as identity is used to denote dev object while version such as "1.2.3" is illegal in identifying a development object except dir name such as those for nuget package. we treat this as versioned/ or identity. note "identy" is different from "identity".
	///  </remarks>
	public interface IIdenty:_identy_.IVersioned
	{
	}
}

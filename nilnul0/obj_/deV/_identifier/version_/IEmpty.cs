using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._identifier.version_
{
	/// <summary>
	/// empty is not versioned. This is equivalent defaults to 0 when being compared.
	/// </summary>
	/// <remarks>
	/// it might be normalized to 0.0, rather than a thrown exception;
	/// </remarks>
	public interface IEmpty:IVersion
	{
	}

}

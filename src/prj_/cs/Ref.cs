using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj_.cs
{
	/// <summary>
	/// the <see cref="nameof(IPre)"/> is both references and ProjectReferenceS. When compiled, some pres are removed. the remained pres are reserved as the ref of the ".dll" refs in manifesto of the ".dll"
	/// </summary>
	/// <remarks>
	/// vs pre:
	///		pre is in the meta of the prject in the source. some pres are not used and hence not included in the compiled ".dll"
	/// vs dep:
	///		ref is a compiling concept. one lib refernces the notions in another lib. ref is specified in ".dll", which can be viewed using ildasm.exe
	///		dep is a nuget package concept. one pac is dependent on other pacs. dep is specified in ".nupkg"
	/// </remarks>
	interface IRef
	{
	}


}

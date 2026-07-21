using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj.co_
{
	/// <summary>
	/// for a realm, we first have a trivia base case as the project.
	/// Then we can extend it to an axiomatic case as a cap project.
	/// </summary>
	/// <remarks>
	/// eg:
	///		nilnul.geometry as the base case, and nilnul.geometry.dimensional as the furthermore dimensioned geometry.
	///	eg:
	///		nilnul.os as the common core of all os.
	///		nilnul.win as the specific os based on the above.
	///		,to summarize various os such as windows, linux, macOs, we need another project called, say, nilnul.os.combo, where we can use multiple os on one machine using the technology of:
	///			virtual machine
	///			,or, booting from one of multiple installation of os on the same machine
	///	；
	/// eg:
	///		<see cref="nilnul.set"/>, <see cref="nilnul.collective"/> which can be infinite
	///		<see cref="nilnul.rel"/>, <see cref="nilnul.relative"/> which can be infinite
	///		<see cref="nilnul.pic"/> about pixelated|rasterized pic including the definition of color, <see cref="nilnul.img"/> concerning geometrical vectoral model which involves infinite obstruse concept.
	///		<see cref="nilnul.prob"/> the conceptual marker interfaces, the fundamental definitions such as probability, <see cref="nilnul.stat"/> concerned with statistics of data, survey samples from prob, and fit for a prob, also involving confidence interval, estimate, etc, that is not theoretically beautiful.
	///		<see cref="nilnul.usr"/>, <see cref="nilnul.acc"/> involving 3rd party crossSite authentication.
	///		<see cref="nilnul.computer.net"/>, <see cref="nilnul.web"/> about applications|softwares on hardwares defined&operated by prior one
	///		<see cref="nilnul.bit"/>, <see cref="nilnul.logic"/> introducing nonrecursive or nonfinite or nonsimple reasoning, per Godel,the previous is complete and consisitent in that it's not innudating natrual number which involves recursion, while logic takes in natural number or recursion.	
	/// </remarks>
	/// <see cref="prjs_.ISchool"/>
	/// alias:
	///		base9ext
	///			,where base|ext correspond with the two clauses in recursion:<see cref="obj.op.IRecur"/>
	internal class IBase9ext:prjs_.ISchool
	{
	}
}

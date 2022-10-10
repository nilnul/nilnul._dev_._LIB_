using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using nilnul.dev.src.prj_.lib.schema._typ;
namespace nilnul._obj.typ._id
{
	/// <summary>
	/// we follow a model called infoGrow.
	/// 
	/// type B is dependent on type A. we name B as "a.B". If B is also dependent upon other things, the other things can be named as "a._b.C"
	///		"C" is the difference resulted from B-A. but "minus" is not associative, is not easy to compute as "+". This vindicates the infoGrow model, which uses the "grow", or "+", to extend code.
	///		
	/// growth model often makes name shorter, makes where to place clearer/simpler
	/// 
	/// groth model helps build a tree out of flat structure. tree carries more info rather than flat structure as there is an extra structure in addition to flat linear structure of things; you can traverse a tree to get a linear structure but you lack information to build a tree given only a linear structure of things. So tree is prefered.
	/// </summary>
	///<remarks>
	/// 
	///</remarks>
	///<see cref="nilnul.dev.src.prj_.lib.schema._typ.IInfoGrow"/>
	///
	/// alias:
	///		info gain
	///			also used in information entropy theory, in classification algorithm: decision tree to get rid of some branches, as used by IBM and academias
	interface IInfoGrow
	{
	}
}

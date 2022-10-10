using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typs_.synonym
{
	/// <summary>
	/// we follow a development ideologue called "Saturation Attack", that is just name a type where you think it shall be. There might be many synonym types, one of which is called canonical. And if it is the same as the other type, connect them by:
	///		1) using framework mechanism if there is any, such as type forward
	///		2) forward your call to the primary type.
	///		2) use xml such as see/seealso comment in your code comment, especilly before the type at the xml-generated documentation.
	///	Saturation Attack is cost effective as it minimizes the thoughts needed from developer.
	///	Compiler and other machine automation might need to do more to optimize such as to merge many into one; but machine can do this more efficiently than human.
	/// </summary>
	/// <remarks>
	/// Of course, we expect the saturationAttack can be efficient only if it's carried out by professionals whose job is time-tight.
	/// </remarks>
	/// alias:
	///		swarming
	///			some analogue to scrum;also more reminding to synonym, as the two extremimums are same.
	///		saturation attach|tactic
	/// <see cref="_obj.typ._id.IInfoGrow"/>
	class ISwarm
	{
	}
}

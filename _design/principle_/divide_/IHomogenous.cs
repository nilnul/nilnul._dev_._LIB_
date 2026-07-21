using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev._design.principle_.divide_
{
	/// <summary>
	/// subdivide/subdelegate/subsystemize/demote/subgrade/subside a system into subsystems which are homogenous to the original system (which means they are of the same type, or they have the same structure, or they have the same behavior, etc), along a destructor traversing roadmap (which is often the <see cref="nilnul.data.struc_.IDirectory"/>, a tree for traversal). 
	/// ;eg:
	///		to study a language, we can subdivide it into sublanguages such as phrases|lexicography, and then sentences|syntax. And both are embodied in data and prog|procedure|code respectively, for which we then can apply dichotomy to study its grammar, its semantics, its pragmatics, etc, if the subsystem is workable due to being small/simple enough, or further subdivide it otherwise. We can recursively subdivide until the subsystems are simple enough to be solved directly; and the traversal path is an unbalanced tree which means the subsystems are not of the same size, and hence we can treat the subsystems as various workload by different effort.
	/// 
	/// </summary>
	/// <remarks>
	/// This brings out an advantage that it's homogeneous hence the subsystem can be solved by the same method as the original system, and hence we can solve the original system by solving the subsystems. This is the essence of the homogenous design principle.
	/// 
	/// </remarks>
	/// 
	/// aspects:
	///		,homogenous subdivide into subsystems
	///		,unbalanced traversal along a tree|directory structure
	///		,recursively
	///		, the subdivide is the branch, and the dichotomy is the leaves, which is the node of knowledge primitives, from the perspective of knowledge algebra, a term coined by WangYoutian.
	///		
	///		
	/// alias:
	///		subsystems
	internal class IHomogenous
	{
	}
}

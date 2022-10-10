using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev._design._rules
{
	/// <summary>
	/// name is import as it implies our design
	/// list item
	/// </summary>
	enum Li
	{
		/// <summary>
		/// <see cref="nilnul._obj.typ._id.IInfoGrow"/>
		/// Shall the type contains the parent type's info?
		/// eg:
		///		nilnul.abc.Def
		///			shall Def contain the info of abc?
		///		if Def contains info of Abc, then where shall we put the info of Def-Abc?
		/// </summary>
		/// alias:
		///		info grow
		///		info gain
		///			occupied by data mining-decision tree algorithm
		///		info path
		InfoGrow
			,
		/// <summary>
		/// <see cref="nilnul.obj_.deV._identy.sur_.ITape"/>
		/// in what namespace shall it be placeed?
		/// the namespace 's each seg, up to the tip, shall contains minimal information. That is, taper the tail thin. eg: we have marker interface, which is just a placeholder
		/// This is a depth-major rule.
		/// </summary>
		/// rather than placed under <see cref="nilnul.win._proc.Id"/>, it's placed as <see cref="nilnul.win.proc.Id"/>, and the integer used is placed in <see cref="nilnul.win.proc._id"/>
		/// that is extension precedes intra<see cref="nilnul.obj._id._nom.term.extsed"/>.
		Taping2tip
			,
		/// <summary>
		/// <see cref="nilnul._obj.typs_.synonym.ISwarm"/>
		/// create types at various place to make it easy found.
		/// let the type implementaion be in a canonical place, and let other place call it.
		/// also:
		///		versioning locally help we swarm similar/related logic together.
		/// </summary>
		/// <remarks>
		/// Swarm on all fronts. One operation is implemented by multiple path/algorithms; they are different in concept, or in methodology.
		/// </remarks>
		/// swarm by professionals
		/// smallest effort principle
		SwarmSynonyms
			,
		/// <summary>
		/// a version of the method is placed alongside the old one in the same class.
		/// </summary>
		/// <remarks>
		/// the assembly's version is thus kept stable to the maximum
		/// </remarks>
		/// this is a lazy developer rule. let the housekeeper- the compiler/optimizingAutomation do the chore.
		VersionLocally
			,
		/// <summary>
		/// extension current type (eg: cartesian product of two types; build one type on another), and we get a new type
		/// restrict current type, we get a new type, which is a subtype.
		/// by extension types:X first and then restriction, we get a new type, which accommodate less instances than the extension, but more than that type of X. Often pure extension is too lax to be useful, thinking Sql Cartesian Join of two tables without where.
		/// </summary>
		ExtensionAndThenRestriction
	}
}

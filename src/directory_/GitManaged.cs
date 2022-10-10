using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.directory_
{
	/// <summary>
	/// a git Manned(managed); i.e.: either a module or a repo_.Bare
	/// 
	/// </summary>
	/// <remarks>
	/// a src is a plain folder. sometimes src can be a gitWork, but this is not recommended. Implication: src cannot be a repo, bare or not.
	///
	/// alias:
	///		gitMananged
	///	including:
	///		gitModule
	///		git bare repo
	/// 
	/// </remarks>
	interface IGitManned
	{
	}
}

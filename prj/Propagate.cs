using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj
{
	/// <summary>
	/// when is appropriate to put some code not in old prj, but in a new prj?
	///		when we need a closure of concept.
	///			for example:
	///				we need to clean each prj, that is: drop the bin and obj folder of each prj.
	///				if we place the code into "nilnul.dev", where we have code for other functionalities, we need to different our cleaining code, so we have to :
	///					1) add the differential nominal everywhere.
	///					2) the cleaning code will call each other, in forking and looping, and form a closure. But the closure is submerged into other unrelated code.
	///					3) the naming is not natural. for example, we may name:
	///						nilnul.fs.addresses_.disjoint.Clean,
	///						or
	///						nilnul.dev.srcs.clean_.of_.addresses_.disjoing.
	///
	///						the latter is more clear about that srcs must be preset.
	///						but the former is unambiguous in the naming, if we put it into a project where srcs are implict configured.
	/// </summary>
	/// <remarks>
	/// alias:
	///		spinoff
	///		partition
	///		offshoot
	///		propagate
	///		
	/// </remarks>
	class Spinoff
	{
	}
}

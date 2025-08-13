using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.build_._ms
{
	/// <summary>
	/// .sln is not msbuild format; but is converted to a .sln.cache, which is msbuild format.
	/// you can opt to save the generated format.
	/// </summary>
	/// is the generated stored in ".vs/"?
	public interface IConverted
		:
		nilnul.os.prog_.deV_.build_.ms._run.IMake
	{
	}
}

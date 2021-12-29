using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src
{
	/// <summary>
	/// a project, such as csproj/sqlProj/etc,in a src. a project generally is not direct in a src, but in a sln, which is in turn in a src.
	/// the meta of a prj is in a file. the meta resides in the folder where the prj resides; prj implies the content of a folder, and stores metadata in a doc in that folder. however, a folder may have multiple prj meta file, each being a different configuration for the prj. So we better take prj as the file 
	/// </summary>
	/// <remarks>
	/// vs nilnul.dev.src.sln.Prj
	///		'cuz one prj can be used among many slns, then prj shall be defined not inside one sln. prj2sln relation is one2one, not many2one.
	///
	/// 
	/// </remarks>
	public interface IPrj {

	}
	//public class Prj:nilnul
	//{
	//}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.raw.sln.sub.dir_
{
	/// <summary>
	/// there might be multiple prjMetaFiles(such as .csproj) inside this dir, and there might be another project in the directory of this dir, so prj shall not be regarded as a folder, but a file(the .csproj meta file, for example)
	/// </summary>
	/// <see cref="src.sln.sub.IPrj"/>
	public interface ISynd
	{
	}
}

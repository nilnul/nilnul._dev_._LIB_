using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.deV_.pac_
{

	/// <summary>
	/// when nuget installs packages for a project, installed folders will be placed into a dir "packages/" in sln or prj.
	/// we can also point the container by symlink to a folder that is shared by all locals projects, to save space.
	/// 
	/// each dir responds to a pac.
	/// </summary>
	/// <remarks>
	/// nuget packages installed
	/// </remarks>
	public interface IInstalled
	{
	}
}
/*
 * 
 place a doc named "Nuget.config" to a folder''s super(including self) with the blob:
  
 <?xml version="1.0" encoding="utf-8"?>
 <configuration>
   <config>
     <add key = "repositoryPath" value="(packages)" />
	 <add key = "dependencyVersion" value="HighestMinor" />

   </config>
 </configuration>


 then packages installed in sub(including self) will be in the specified path. This path can be a symlink

that will save a lot of space.
*/

/*
 make the dir "packages/" an symlink to a shared folder will, not only saving space, also make the dir contained underneath the project and thus rendering the project portable 
 */
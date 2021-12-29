using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj_.cs_.lib.cfg.refered
{
	/*
	 * 
  <runtime>
    <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
      <dependentAssembly>
        <assemblyIdentity name="Newtonsoft.Json" publicKeyToken="30ad4fe6b2a6aeed" culture="neutral" />
        <bindingRedirect oldVersion="0.0.0.0-13.0.0.0" newVersion="13.0.0.0" />
      </dependentAssembly>
    </assemblyBinding>
  </runtime>

	 */

	/*Automatic binding redirects are enabled by default for Windows desktop apps that target the .NET Framework 4.5.1 and later versions. The binding redirects are added to the output configuration (app.config) file when the app is compiled and override the assembly unification that might otherwise take place. The source app.config file is not modified. You can disable this feature by modifying the project file for the app or by deselecting a checkbox in the project's properties in Visual Studio.*/
	interface IRedir
	{

	}
}

/*
 Add-BindingRedirect (Package Manager Console in Visual Studio)
12/07/2017
2 minutes to read





Available only within the Package Manager Console in Visual Studio on Windows.
 */

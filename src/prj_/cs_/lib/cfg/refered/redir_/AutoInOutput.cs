using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj_.cs_.lib.cfg.refered.redir_
{
	/*When you create a desktop app in Visual Studio that targets the .NET Framework 4.5.1 or a later version, the app uses automatic binding redirection. This means that if two components reference different versions of the same strong-named assembly, the runtime automatically adds a binding redirection to the newer version of the assembly in the output app configuration (app.config) file. This redirection overrides the assembly unification that might otherwise take place. The source app.config file is not modified. For example, let's say that your app directly references an out-of-band .NET Framework component but uses a third-party library that targets an older version of the same component. When you compile the app, the output app configuration file is modified to contain a binding redirection to the newer version of the component. If you create a web app, you receive a build warning regarding the binding conflict, which in turn, gives you the option to add the necessary binding redirect to the source web configuration file.
	 * 
	 * You can enable automatic binding redirection if your app targets older versions of the .NET Framework. You can override this default behavior by providing binding redirection information in the app.config file for any assembly*/
	class AutoInOutput
	{
	}
	/*There might be rare cases when a machine administrator wants all apps on a computer to use a specific version of an assembly. For example, the administrator might want every app to use a particular assembly version, because that version fixes a security hole. If an assembly is redirected in the machine's configuration file, all apps on that machine that use the old version will be directed to use the new version. The machine configuration file overrides the app configuration file and the publisher policy file. This file is located in the %runtime install path%\Config directory. Typically, the .NET Framework is installed in the %drive%\Windows\Microsoft.NET\Framework directory.*/

	//https://docs.microsoft.com/en-us/dotnet/framework/configure-apps/redirect-assembly-versions
}

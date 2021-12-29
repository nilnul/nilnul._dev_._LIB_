using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.win.program_.dotnet.cfg
{
	/*Thanks for your help, it helped a lot finding the issue. The hint with the path helped me "seeing what is going on" and finding the troublemaker.

BTW, this snippet

 config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal)
 config.FilePath
is useful finding the storage location.*/
	interface LocationI
	{
	}
}

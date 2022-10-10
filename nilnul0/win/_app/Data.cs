using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.win._app
{
	/*To get the AppData directory, it's best to use the GetFolderPath method:

Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
%AppData% is an environment variable, and they are not automatically expanded anywhere in .NET, although you can explicitly use the Environment.ExpandEnvironmentVariable method to do so. I would still strongly suggest that you use GetFolderPath however, because as Johannes Rössel points out in the comment, %AppData% may not be set in certain circumstances.

Finally, to create the path as shown in your example:

var fileName = Path.Combine(Environment.GetFolderPath(
    Environment.SpecialFolder.ApplicationData), "DateLinks.xml");
	
		 he environment does not need to be present, in some cases when running a program under another user account the user's environment will not be loaded and %Appdata% will be empty. 
		 The path is different if you're talking ASP.NET.

I couldn't find any of the 'SpecialFolder' values that pointed to /App_Data for ASP.NET.

Instead you need to do this:

 HttpContext.Current.ApplicationInstance.Server.MapPath("~/App_Data")  
(Note: You don't need the 'Current' property in an MVC Controller)

If theres another more 'abstract' way to get to App_Data would love to hear how.

shareimprove this answer
answered Jul 27 '09 at 10:14

Simon_Weaver
63.4k57405488
Just a note since asp.net core is coming out now. This approach relies specifically on IIS. – George Mauer Aug 10 '16 at 16:00
4
HostingEnvironment.MapPath(@"~/App_Data") is better and works in both MVC / WebAPI and WCF contexts where there is no HttpContext - but not sure about core' – Simon_Weaver Sep 17 '16 at 11:44
ust wanted to share another way of accessing 'App_Data' folder in my mvc application in case that someone needs this.

 Path.Combine(HttpRuntime.AppDomainAppPath,"App_Data")
		 */
	class Data
	{
	}
}

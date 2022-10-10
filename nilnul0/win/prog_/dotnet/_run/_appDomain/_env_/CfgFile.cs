using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.win.program_.dotnet._run._appDomain._env_
{
	/*AppDomain.CurrentDomain.SetData("APP_CONFIG_FILE" , "C:\SomeFolder\MyCustomApp.Config")
	 Conceptually, this works just fine.  Therefore, the problem must be in your implementation.  To prove that I created a console application and did the following:

Add an App.config and a second that was automatically named App1.config
Set App1.config to Content, Copy Always
Added a single string, application setting using the designer in Visual Studio
Opened App.config and copied the contents to App1.config
Changed the value for the setting in App1.config
Added the code below
 

using System;
using AlternateAppConfigSample.Properties;

namespace AlternateAppConfigSample
{
 class Program
 {
  static void Main(string[] args)
  {
   SetAlternateConfigFile();
   DisplayValue();
  }

  private static void DisplayValue()
  {
   string myValue = Settings.Default.MyCustomValue;

   Console.WriteLine(myValue);
   Console.ReadLine();
  }

  private static void SetAlternateConfigFile()
  {
   AppDomain.CurrentDomain.SetData("APP_CONFIG_FILE", "App1.config");
  }
 }
}


It's important to set the configuration file before it's loaded.  In my case, when I make a call to the Singleton Settings instance the configuration file will be read.  So, if I call DisplayValue(), SetAlternateConfigFile(), and then DisplayValue() I'll get the same result.  Apparently, it's ignored.
 

A couple of things to look at:

What exceptions are you getting?  And where are the exceptions occurring?
Permissions issue with the folder you specified?  Try the current path and see if the problem goes away.
 I just tried it in a WinForms application and it worked fine as well.  I put my call to SetData in the Main method of the Program class.

I'll wait to see what you find.  I would definitely put the file in your application folder for this purpose.  The goal is to find why it doesn't work, so start eliminating differences.*/
	class CfgFile
	{
	}
}

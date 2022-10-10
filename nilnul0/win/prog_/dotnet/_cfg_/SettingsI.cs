using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.win.program_.dotnet._cfg_
{
	/*
	 My mistake was calling Reset() before Reload(). I was unaware that Reset() also saves in the same turn, I was thinking it resets the values only in memory. – HorstWalter Apr 23 '10 at 15:55
add a comment
up vote
0
down vote
Thanks for your help, it helped a lot finding the issue. The hint with the path helped me "seeing what is going on" and finding the troublemaker.

BTW, this snippet

 config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal)
 config.FilePath
is useful finding the storage location.*/
	interface SettingsI
	{
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.ide_.vs.prj_.test.cfg
{
	/*
	 Settings.Default.X = "History"; // X is string
Settings.Default.Save();
	 Since all test cases have their own directory, the settings have to be created (saved) within the test case.
	 As test methods have to be executed, the unit-test framework will instantiate test classes in a real application context. Thus tests are executed in a directory on the file system which implies having configuration files. –

		
		I tried it with Visual Studio 2010 on Windows 7 and the Visual Studio Unit Test framework is actually creating a temporary folder for test applications in which I found my user.config file with correct settings. I think it might be the same thing on VS 2008. The path scheme to these folder is of the kind:

Windows 10 path:

C:\Users\$USER$\AppData\Local\Microsoft_Corporation\UnitTestAdapter__Running__StrongName_{guid}\{number}

Windows Vista/Seven path:

C:\Users\$USER$\AppData\Local\Microsoft_Corporation\TestAppDomain{Number}

Windows XP path:

C:\Documents and Settings\$USER$\Local Settings\Microsoft_Corporation\TestAppDomain{Number}

Good luck.


Matt
answered Apr 22 '10 at 23:48

thanks a lot, you helped me a lot. Minor tweak: its .. \Local Settings\Application Data\Microsoft_Corporation\... for XP – HorstWalter Apr 23 '10 at 16:08
		 */
	interface LocationI
	{
	}
}

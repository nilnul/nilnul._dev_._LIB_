using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.win.program_.dotnet.cfg
{
	/*
	 My mistake was calling Reset() before Reload(). I was unaware that Reset() also saves in the same turn, I was thinking it resets the values only in memory. – HorstWalter Apr 23 '10 at 15:55

		My problem was that I called Reset() before Reload(). Actually my test case checks whether the objects are stored correctly, so it saves and reloads the settings. I was unaware of the fact, that Reset() "resets and saves on disk" - I was assuming it only resets in memory. I must only call Reload().
*/
	interface ResetI
	{
	}
}

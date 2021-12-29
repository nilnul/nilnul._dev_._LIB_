using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV_.pkg._identity._version
{
	/// <summary>
	/// aliase:
	///		revision
	/// </summary>
	public class PreRelease
	{
		
		public string  preRelease;
		public override string ToString()
		{
			return $"-{preRelease}";
		}

	}
}

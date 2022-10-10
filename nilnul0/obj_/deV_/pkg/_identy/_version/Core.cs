using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV_.pkg._identity._version
{
	public class Core
	{
		/// <summary>
		/// breaking changes.
		/// </summary>
		/// <remarks>
		/// in source code, new versions can be merged into old versions to make old major a new minor with new code.
		///		this merge process might be very conflicting. as new cold often replace in place old code.
		///			how to solve the src code conflict?
		///				we can in source code, keep the old code, but omit them from copiling so as to only compileing newer code. for example mark them as obsolete(true)
		/// by doing so, we can, in the new major, remove redundnat code from the repo, such as to move forward lightly without legacy burden. and new project can use the new major.
		///		for existant project that uses the old major, they should continue using the old major, but can upgrade with new minor.
		/// </remarks>
		public int major;
		/// <summary>
		/// incremental changes. compatible. backward compatibility
		/// </summary>
		public int minor;

		/// <summary>
		/// two-way compatibility.
		/// "build" in MsVersion
		/// </summary>
		public int patch;

		public Core(int major, int minor, int patch)
		{
			this.major = major;
			this.minor = minor;
			this.patch = patch;
		}

		public override string ToString()
		{
			return$"{major}.{minor}.{patch}";
		}



	}
}

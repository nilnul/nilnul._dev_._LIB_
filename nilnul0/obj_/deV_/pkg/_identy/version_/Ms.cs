using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.obj_.deV_.pkg._identity.version_
{
	/**/

	/// <summary>
	/// 1.0.0.1
	/// <see cref="nameof(System.Version)"/>
	/// </summary>
	public class Ms:VersionA, _version_.CoreI,IVersion
	{
		/// <summary>
		/// 
		/// </summary>
		///
		private _version.Core _core;
		public _version.Core core { get { return _core; }
			set {
				_core = value;
			}
		}



		/// <summary>
		/// </summary>
		public _version.Revision revision;

		// todo: optional -prerelease ?

		public Ms(_version.Core core, _version.Revision revision=null)
		{
			this.core = core;
			this.revision = revision;
		}

		public Ms(int v1, int v2, int v3, int v4):this(new _version.Core(v1,v2,v3), new _version.Revision(v4))
		{
		}

		/// <summary>
		/// appending 0 is omitted
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return ((System.Version)this).ToString();
			//return $"{core}{revision}";	
		}

		static public implicit operator System.Version(Ms ms) {
			return new Version(ms.core.major,ms.core.minor,ms.core.patch,ms.revision.numAsInt);
		}

		public Ms(System.Version version):this(version.Major,version.Minor, version.Build,version.Revision)
		{

		}

	


	}
}

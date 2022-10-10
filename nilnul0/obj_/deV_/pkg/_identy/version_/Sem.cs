using NuGet.Versioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.obj_.deV_.pkg._identity.version_
{
	/*
	 * 
	 major.minor.(patch-preRelease)+build
	so preRelease shall be understood as a subtractee from minor.
	and build shall be understood as ver_.Ms 's revision, even though "+" is used before build, and "." is used before revision
	 */
	/// <summary>
	/// in the form of
	///		major.minor.patch.revision-pre.release+tag
	/// </summary>
	public class Sem :
		VersionA,

		_version_.CoreI
		, IVersion
	{
		private SemanticVersion _boxed;

		public SemanticVersion boxed
		{
			get { return _boxed; }
			set
			{
				_boxed = value;
			}

		}
		public _version.Core core
		{
			get
			{
				return new _version.Core(_boxed.Major, _boxed.Minor, _boxed.Patch);
			}

		}


		public string pre
		{
			get
			{
				return _boxed.Release;
			}
		}




		public Sem(SemanticVersion val)
		{
			this._boxed = val;
		}

		//public static Sem Parse(GroupCollection s)
		//{


		//	return Parse(
		//		string.Join("", s.Cast<Group>().Select(g => g.Value))
		//	);

		//}

		public static Sem Parse(string s)
		{

			return new Sem(
				SemanticVersion.Parse(s)
			);

		}
		public override string ToString()
		{
			return _boxed.ToString();
		}


	}
}

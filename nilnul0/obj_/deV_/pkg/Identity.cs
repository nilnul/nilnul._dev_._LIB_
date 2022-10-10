using NuGet.Packaging.Core;
using NuGet.Versioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.obj_.deV_.pkg
{
	/// name is unordered. ver is ordered.
	/// dot separated
	/// 	/// name and ver together is used as Id/Identifier.

	/// <summary>
	/// this is identity (where versioniong can be semVer,), not identy (where version admits no semVer)
	/// Here the versioning is nulable.
	/// the dll inside the pkg is still versioned with non-semVer, but System.Version
	/// </summary>
	/// <remarks>
	/// alias:
	///		identifier
	///		identity
	///		identification
	///		id
	///	nomenclature:
	///		some use number as id. in this case, the id is also called sn
	///		but name is id humanly.
	///		we mix them
	///	</remarks>

	public class Identity //: ISpec
	{
		/// <summary>
		/// key stone
		/// </summary>
		public string key;
		//_vered.Ver ver;

		public obj_.deV_.pkg._identity.VersionA ver;

		static public string _RegexTxt {
			get {
				return $@"^(?<basis>.*?).(?<ver>{ obj_.deV_.pkg._identity._VersionX.RegexTxt})$";
			}
		}



		public Identity(string name, obj_.deV_.pkg._identity.VersionA ver)
		{
			this.key = name;
			this.ver = ver;
		}

		public Identity(PackageIdentity packageIdentity):this(
			packageIdentity.Id,
			packageIdentity.Version
		)
		{

		}

		public Identity(string id, NuGetVersion version):this(id, obj_.deV_.pkg._identity._VersionX.Parse(version.ToString()))
		{
		}

		public Identity(string nom, string version):this(
			nom
			,
			obj_.deV_.pkg._identity._VersionX.Parse(version)
		)
		{
		}
		public Identity(string identity, nilnul.obj_.deV_.pkg._identity.version_.Ms version):this(identity, (nilnul.obj_.deV_.pkg._identity.VersionA)(version))
		{
		}

		public Identity(string identity, Version version):this(identity, new nilnul.obj_.deV_.pkg._identity.version_.Ms(version))
		{
		}

		public PackageIdentity toPacIdentity()
		{
			return VersionedX.PakId(
				key, ver.ToString()
			);
		}
		public override string ToString()
		{
			return $"{key }.{ver}";
		}

		static public Identity Parse(string name) {

			var match = Regex.Match(name);

			return new Identity(
				match.Groups["basis"].Value
				,


				obj_.deV_.pkg._identity._VersionX.Parse(
					match.Groups["ver"].Value
				)
			);


		}

		static public Regex Regex
		{
			get
			{
				return new Regex(
					_RegexTxt
					,
					RegexOptions.CultureInvariant | RegexOptions.Compiled | RegexOptions.ExplicitCapture | RegexOptions.IgnorePatternWhitespace | RegexOptions.Singleline
				);
			}
		}


	}

	static public class VersionedX{
		static public PackageIdentity PakId(string name, string version) {
			return new PackageIdentity(
				name,
				NuGetVersion.Parse(version)
			);
		}
	}
}

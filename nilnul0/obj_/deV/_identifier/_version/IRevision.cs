using System;

namespace nilnul.obj_.deV._identifier._version
{
	/// <summary>
	/// corresponding to source|raw code revision, which is represented by a commit hash id in Git;
	/// for maintance by developers;
	/// for <see cref="System.Version"/> and <see cref="NuGet.Versioning.NuGetVersion"/>, the last part is revision;
	/// </summary>
	/// <remarks>
	/// This is used in <see cref="FileVersion"/>, not in <see cref="PackageVersion"/>
	///together with up to <see cref="IMinor"/>, the software is unique per build number.
	///not intended to mean anything for consuming program;
	/// </remarks>
	/// alias:
	///		revision
	///			like a snap in git repo.
	///			if we name this as revision, then build can mean the tags in identification; this is the doings of semver.org 
	///			, somewhat like "version" in it
	///	vs:
	///		build
	///			is used in nilnul.dev.pak.Versionary, and is a semVer;
	///			,it's not manually maintained by software engineer, but by compiling tools, resulted differently due to difference of tools or settings for the building process.
	///
	[Obsolete(nameof(_version_.IBuild ) + " is preferred in that revision might confuse with nilnul.fs.git.repo.revision, and build is more expressive of the fact that it's about build, not src" )]
	public interface IBuild { }
}


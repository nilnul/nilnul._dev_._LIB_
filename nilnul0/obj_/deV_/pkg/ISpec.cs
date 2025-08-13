using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV_.pkg
{
	/// <summary>
	/// eg:
	///		nilnul._acc_._LINQ_,Version=1.1.220731.182834, Culture=neutral, processorArchitecture=MSIL
	///	that is :
	///		with tags, including attrs.
	/// in identy, the version cannot allow SemVer. to accomodate semVer, we define Spec as the extension of identy.
	/// </summary>
	/// <remarks>
	/// for dll refs, it seems the version is only of the type "SysVersion", none of the type "SemVersion"
	///  SemVersion shall be delegated into prj:"nilnul.dev._pac_"
	/// </remarks>
	/// <see cref="IMeta"/>
	/// vs:
	///		data
	/// <see cref="IInfo"/>
	public interface ISpec
	{
	}

	
}

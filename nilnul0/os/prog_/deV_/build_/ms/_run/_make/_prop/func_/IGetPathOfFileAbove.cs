using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog_.deV_.build_.ms._run._make._prop.func_
{
	/// <summary>
	/// searches upward for a directory containing the specified file, beginning in (and including) the specified directory. It returns the full path of the nearest matching file if it is found, otherwise an empty string.
	/// </summary>
	/// <remarks>
	///eg:
	/// <Import Project="$([MSBuild]::GetDirectoryNameOfFileAbove('$(MSBuildThisFileDirectory)../', 'Directory.Build.props'))/Directory.Build.props" />
	/// </remarks>
	internal class IGetPathOfFileAbove
	{
	}
}

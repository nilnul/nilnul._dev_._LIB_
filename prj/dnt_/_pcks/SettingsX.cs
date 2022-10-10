using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj.dnt_._pcks
{
	/// <summary>
	/// 
	/// </summary>
	static public class SettingsX
	{
		/// <summary>
		/// "packages" is the name used by visualstudio.
		/// </summary>
		/// <remarks>
		/// we prefer ".packages" or ".pcks", as it has inner folders; according to our rule: <see cref="nilnul.fs.folder.divisions_.NoDotLedFolder"/>, we can stop traverse its inner folders.
		/// </remarks>
		static public string Caption { get {
				return Settings1.Default.caption ?? (string) Settings1.Default.Properties[nameof(Settings1.caption)].DefaultValue;
			} }
	}
}

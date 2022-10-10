using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj._meta_.props_._aim
{
	/// <summary>
	/// configuration in sln/prj as the target for our building process
	/// </summary>
	/// alias:
	///		aim
	static public class Li_
	{
		//public const string Symbols4Debug= "Symbols4Debug";


		/// <summary>
		/// on debug. pushed to "my", a internal one.
		/// </summary>
		public const string Symbol= "Symbol";

		public const string Debug = nameof(Debug);// "Symbol";

		/// <summary>
		/// build on Realse. Push is automated on this to nuget.org
		/// </summary>
		public const string Nuget = nameof(NuGet);

		/// <summary>
		/// we append the "-dev" tag to the generated version such as to make it <see cref="nilnul.obj.identy.ITagged"/>, indicating this is a preview release. 
		/// </summary>
		/// <remarks>
		/// The optimization is set as release, as we already have debug optimization of symbolsed pkg.
		/// </remarks>
		/// alias:
		///		nuget4dev
		///			we want to keep the name short, and leading chars should be quite distinct, as the textbox in the toolbar of visual studio is not wide .
		/// 
		public const string Dev2nuget = nameof(Dev2nuget);



	}
}

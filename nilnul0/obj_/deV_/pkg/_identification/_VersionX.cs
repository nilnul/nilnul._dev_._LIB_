using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.obj_.deV_.pkg._identity
{



	/*SemanticVersion Class
Definition
Namespace:
System.Management.Automation
Assembly:
System.Management.Automation.dll
Package:
Microsoft.WSMan.Runtime v7.0.0*/
	/// <summary>
	/// major ,minor, patch, revision are also in alphabetic order
	/// </summary>
	/// <see cref="_identification.IVersionary"/>
	///
	[Obsolete("to be moved to nilnul.dev._pak._identification.")]
	static public class _VersionX
	{



		//public const string _Regex = /*Regex0.ToString()*/

		//	@"(?<major>\d+)
		//	(?>\.(?<minor>\d+))?
		//	(?>\.(?<patch>\d+))?
		//	(
		//		(?>\.(?<revision>\d+))
		//		|
		//		(
		//			(?>\-(?<pre>[0-9A-Za-z\-\._]+))?
		//			(?>\+(?<build>[0-9A-Za-z\-\._]+))?
		//		)
		//	)?
		//	";





		static public readonly Regex Regex0 = new Regex(
			@"(?<major>\d+)
			(?>\.(?<minor>\d+))?
			(?>\.(?<patch>\d+))?
			(?>\.(?<revision>\d+))?
			(
				
					(?>\-(?<pre>[0-9A-Za-z\-\._]+))?
					(?>\+(?<build>[0-9A-Za-z\-\._]+))?
				
			)?
"
			,
				RegexOptions.CultureInvariant | RegexOptions.Compiled | RegexOptions.ExplicitCapture | RegexOptions.IgnorePatternWhitespace
			,
				TimeSpan.FromSeconds(0.5)
		);



		[Obsolete(nameof(NuGet.Versioning.NuGetVersion.Parse))]
		static public VersionA Parse(string s)
		{

			var m = Regex0.Match(s);

			//var ms= new System.Version(
			//	nilnul.num.integer_.int32.parse_._EmptyAsNilX.Parse(m.Groups["major"].Value ?? "")
			//	,
			//	nilnul.num.integer_.int32.parse_._EmptyAsNilX.Parse(m.Groups["minor"].Value ?? "")
			//	,
			//	nilnul.num.integer_.int32.parse_._EmptyAsNilX.Parse(m.Groups["patch"].Value ?? "")
			//	,
			//	nilnul.num.integer_.int32.parse_._EmptyAsNilX.Parse(m.Groups["revision"].Value ?? "")
			//);

			if (m.Groups["pre"].Success || m.Groups["build"].Success)
			{


				//return new version_.Sem(
				//	new NuGet.Versioning.SemanticVersion(
				//		ms

				//	)
				//);

				return version_.Sem.Parse(s);
			}
			//return new ver_.Ms( System.Version.Parse(s) );  //for unavailable values, it's -1, result in an exception.

			return new version_.Ms(
				nilnul.num.integer_.int32.parse_._EmptyAsNilX.Parse(m.Groups["major"].Value ?? "")
				,
				nilnul.num.integer_.int32.parse_._EmptyAsNilX.Parse(m.Groups["minor"].Value ?? "")
				,
				nilnul.num.integer_.int32.parse_._EmptyAsNilX.Parse(m.Groups["patch"].Value ?? "")
				,
				nilnul.num.integer_.int32.parse_._EmptyAsNilX.Parse(m.Groups["revision"].Value ?? "")

			);

			//if (m.Groups["revision"].Success)
			//{

			//	return new version_.Ms(
			//		int.Parse(m.Groups["major"].Value)
			//		,
			//		int.Parse(m.Groups["minor"].Value)
			//		,
			//		int.Parse(m.Groups["patch"].Value)
			//		,
			//		int.Parse(m.Groups["revision"].Value)

			//	);
			//}

			//return version_.Sem.Parse(s);



		}


		static public string RegexTxt
		{
			get
			{
				return Regex0.ToString();
			}
		}


	}

}

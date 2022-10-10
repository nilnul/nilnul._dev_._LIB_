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
	static public class _VersionX
	{



		public const string _Regex = /*Regex0.ToString()*/

			@"(?<major>\d+)
			(?>\.(?<minor>\d+))?
			(?>\.(?<patch>\d+))?
			(
				(?>\.(?<revision>\d+))
				|
				(
					(?>\-(?<pre>[0-9A-Za-z\-\._]+))?
					(?>\+(?<build>[0-9A-Za-z\-\._]+))?
				)
			)?
			";





		static public readonly Regex Regex0 = new Regex(
			@"(?<major>\d+)
			(?>\.(?<minor>\d+))?
			(?>\.(?<patch>\d+))?
			(
				(?>\.(?<revision>\d+))
				|
				(
					(?>\-(?<pre>[0-9A-Za-z\-\._]+))?
					(?>\+(?<build>[0-9A-Za-z\-\._]+))?
				)
			)?
"
			,
				RegexOptions.CultureInvariant | RegexOptions.Compiled | RegexOptions.ExplicitCapture | RegexOptions.IgnorePatternWhitespace
			,
				TimeSpan.FromSeconds(0.5)
		);




		static public VersionA Parse(string s)
		{

			var m = Regex0.Match(s);
			if (m.Groups["pre"].Success || m.Groups["build"].Success)
			{
				return version_.Sem.Parse(s);
			}
			//return new ver_.Ms( System.Version.Parse(s) );  //for unavailable values, it's -1, result in an exception.

			return new version_.Ms(
				nilnul.num.integer_.int32.parse_._EmptyAsNilX.Parse(m.Groups["major"].Value ?? "")
				,
				nilnul.num.integer_.int32.parse_._EmptyAsNilX.Parse(m.Groups["minor"].Value ?? "")
				,
				nilnul.num.integer_.int32.parse_._EmptyAsNilX.Parse(

				m.Groups["patch"].Value ?? ""
				)
				,
				nilnul.num.integer_.int32.parse_._EmptyAsNilX.Parse(
					m.Groups["revision"].Value ?? ""
				)

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

	/// <summary>
	/// <seealso cref="nameof(nilnul.txt_._versioned.IVersion)"/>
	/// </summary>

	public interface IVersion
	{

	}

	/// <summary>
	/// define some operators which cannot be done on subtype for super type
	/// </summary>
	public abstract class VersionA : IVersion
	{

		static public bool operator <(VersionA x, VersionA b)
		{

			return version.Comparer.Singleton.Compare(x, b) < 0;

		}
		static public bool operator <=(VersionA x, VersionA b)
		{

			return version.Comparer.Singleton.Compare(x, b) <= 0;

		}


		static public bool operator >=(VersionA x, VersionA b)
		{

			return b <= x;

		}
		static public bool operator >=(VersionA x, Version b)
		{

			return x >= (new version_.Ms(b) as VersionA);

		}

		static public bool operator <=(VersionA x, Version b)
		{

			return x <= (new version_.Ms(b) as VersionA);

		}

		static public bool operator >(VersionA x, VersionA b)
		{
			return b < x;
		}



		static public bool operator ==(VersionA x, VersionA b)
		{
			return version.Comparer.Singleton.Compare(x, b) == 0;
		}

		static public bool operator ==(VersionA x, version_.Ms b)
		{
			return x == (VersionA)(b);
		}
		static public bool operator !=(VersionA x, version_.Ms b)
		{
			return !(x == b);
		}

		static public bool operator ==(VersionA x, Version b)
		{
			return x == new version_.Ms(b);
		}

		static public bool operator !=(VersionA x, Version b)
		{
			return !(x == b);
		}
		static public bool operator ==(Version x, VersionA b)
		{
			return b == x;
		}
		static public bool operator !=(Version x, VersionA b)
		{
			return !(x == b);
		}



		static public bool operator !=(VersionA x, VersionA b)
		{
			return !(x == b);
		}


	}

}

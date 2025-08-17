using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.raw.sln.prj._name._tgt.primitive.alias
{
	static public class _SortieX
	{
		static public string[] DB = new string[] {
			"db"
		};
		static public string[] LINQ = new string[] {
			"linq"
		};
		static public string[] LIB = new string[] { "lib", "dll","lib4fx" };
		static public string[] TEST = new string[] { "test", "tst", "test4fx" };	// try?

		static public string[] CTR4WIN = new string[] {
			"CTR4win"
			,
			"win_ctr"
			,"CTR"

		};


		static public string[] API = new string[] {
			"api"
		};
		/// <summary>
		/// sometimes webCtr is built upon a web prj; sometimes webCtr is a library not build upon a web prj
		/// </summary>
		static public string[] CTR4WEB = new string[] {
			"CTR4web"
			,
			"web_ctr"
			//,"ctr"	//"WEB._CTR_"
		};

		/// <summary>
		/// for web
		/// </summary>
		static public string[] DEMO = new string[] {
			"DEMO"

		};
		static public string[] WEB = new string[] {
			"web"
		};






		static public IEnumerable<string> LIB0CTR = LIB.Concat(CTR4WIN);

		static public primitive.Aliases LIB0CTR_asAlias = new Aliases(LIB0CTR);

		static public IEnumerable<string[]> Egs = new[] {
			LINQ
			,
			LIB
			,
			TEST
			,
			CTR4WIN,DB
			,
			API
			,
			CTR4WEB
			,
			DEMO
			,
			WEB
		};

		static public IEnumerable<string> Sortie(string x)
		{
			var t11 = Egs.Where(t => t.Contains(x, nilnul.txt.eq_.CaseInsensitive.Singleton));

			if (t11.Any())
			{
				return t11.SelectMany(t1 => t1);

			}
			return new[] { x };

			/*

			var r = Enum.GetValues(
							typeof(Primitive_)
						).Cast<Primitive_>().Select(
				t => t.ToString()).Where(
							t1 =>
							nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(t1, x)
			);


			switch (x.ToUpper())
			{
				//case nameof( Primitive_.Lib) .ToUpper():// "LIB":
				case "LIB":
					r= 
						r.Concat(LIB)
						
					;

					break;

			}

			return r;
			*/

		}

		static public IEnumerable<string> Sortie_ofCirca(string x)
		{

			return Sortie(
				nilnul.obj_.deV._id.nom_.idiom.circa._CoreX.Core(x)
			);

		}





	}
}

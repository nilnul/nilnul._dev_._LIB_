using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._id._nom.idiom
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// alias:
	///		scule, as in minuscule/majuscale
	///		case
	/// </remarks>
	static public class _PhraseX 
	{
		static public string Upper(IEnumerable<string> casibles) {
			return string.Join("_",casibles.Select(x=>x.ToUpper()) );
		}

		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		///	 alias:
		///		snake_case
		/// </remarks>
		/// <param name="casibles"></param>
		/// <returns></returns>
		static public string Lower(IEnumerable<string> casibles) {
			return string.Join("_",casibles.Select(x=>x.ToLower()) );
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="casibles"></param>
		/// <returns></returns>
		/// <remarks>
		/// alias:
		///		Pascal
		/// </remarks>
		static public string Capital_assumeItemIsDwelt(IEnumerable<string> casibles) {
			return string.Join("",
				casibles.Select(x=>nilnul.txt_.dwelt.op_.unary_._StartUpperX.Txt(x.ToLower()))
				);
		}
		static public string Camel_assumeStarted(IEnumerable<string> casibles) {
			return casibles.First().ToLower()
				+
				Capital_assumeItemIsDwelt(casibles.Skip(1))
			;
		}

	}
}

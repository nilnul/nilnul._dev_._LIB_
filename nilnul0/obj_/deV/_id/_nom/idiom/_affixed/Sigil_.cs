using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._id._nom.idiom._affixed
{
	/// <summary>
	/// </summary>
	public enum Sigil_
	{
		/// <summary>
		/// usable in JS
		/// </summary>

		[Description("$")]
		Dollar
			,
		/// <summary>
		/// usable in c#, js
		/// </summary>
		[Description("_")]
		Lodash
			,
		/// <summary>
		/// @ used in c# src to euphemeralize reserved word
		/// </summary>
		///
		[Description("@")]
		At

	}
}

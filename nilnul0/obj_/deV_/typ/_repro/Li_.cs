using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV_.typ._repro
{
	public enum Li_
	{
		/// <summary>
		/// eg:
		///		(T,T1) as a tuple
		/// </summary>
		Extend
			,
		/// <summary>
		/// by applying some logic to exclude some values when constructed;
		/// eg:
		///		take in a <see cref="Extend"/>, and throw exception at some values;
		/// </summary>
		/// <see cref="nilnul.obj.vow.EeI{T}"/>
		Constrain
	}
}

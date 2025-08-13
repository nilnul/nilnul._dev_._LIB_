using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._nomina.nom_._human
{
	internal enum Li_
	{
		/// <summary>
		/// public; 
		/// </summary>
		/// <remarks>
		/// roman ordinal is appended when necessary.
		/// eg:
		///		_wangyoutian_._WEB_
		///			,for public use.
		///	this is dependent on <see cref="nilnul"/>
		/// </remarks>
		FullName

			,
		/// <summary>
		/// publish.
		/// the content before publish is personal, but is exposed via an interface like the web where some content is transformed before being exposed.
		/// Access control might be interjected inbetween the personal resource, and the public interface.
		/// </summary>
		/// <remarks>
		/// eg:
		///		_wyt_._WEB_
		///		for publish use, where some content is in the site, but not directly visible,but through controllers which might tattoo some contents.
		///	This is based on <see cref="FullName"/>
		/// </remarks>
		Abbreviation

			,
		/// <summary>
		/// private
		/// </summary>
		/// <remarks>
		/// eg:
		///		_my_._WEB_
		///		for personal use.
		///	; this is dependent on <see cref="Abbreviation"/>
		/// </remarks>
		My
			,
	}
}

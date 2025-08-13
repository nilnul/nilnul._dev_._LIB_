using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln_._person
{
	/// <summary>
	/// sln is viewed/regarded/processed by person
	/// </summary>
	internal enum Li_
	{
		/// <summary>
		/// maybe adfixed by roman ordinal <see cref="nilnul.num.ord_.IOneBased"/> in case of confliction.
		/// public, mainted by everyone;
		/// </summary>
		/// <remarks>
		/// when there is confliction, a ver (generally date of birth) can be appended.
		/// </remarks>
		/// alias:
		///		public
		Full
,

		/// <summary>
		/// owned by one, published to community;
		/// dependent on <see cref="Full"/>
		/// </summary>
		/// <remarks>
		/// eg:
		///		personal team. 
		/// </remarks>
		/// alias:
		///		profess
		///		publish
		///		print
		///		post
		///		promulgate
		///		proclaim
		///		promo
		///		promote
		///		
		///		
		Abbreviation
			,

		/// <summary>
		/// private
		/// </summary>
		/// <remarks>
		///dependent on <see cref="Abbreviation"/>
		/// </remarks>
		/// alias:
		///		private
		///		privy
		My
			,
		/// <summary>
		/// this prj is for a special profession.
		/// </summary>
		/// <remarks>
		/// eg:
		///		called by a profession, a region, a group of people;
		/// </remarks>
		Alias
			,
		/// Temp
		/// ,
		//Local
		//	,
	}
}

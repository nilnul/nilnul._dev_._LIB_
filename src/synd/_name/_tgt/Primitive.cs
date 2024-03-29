﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln.prj._name._tgt
{
	/// <summary>
	/// some prj might be compound such as:
	///		WEB._DEMO_
	///		
	/// </summary>
	public enum Primitive_
	{
		/// <summary>
		/// a web project for designing of the sln
		/// </summary>
		Ken,

		Db
			,
		Sql
			,
		Linq
			,
		/// <summary>
		/// alias:
		///		dll
		/// </summary>
		Lib
			,
		Test
			,
		/// <summary>
		/// alias:
		///		exe
		///		console
		///		
		/// </summary>
		Cmd
			,
		Ctr4win
		,
		Win
			,
		Web
			,
		/// <summary>
		/// a web project for documentation (including:
		///		:design of the system
		///		:techinal reference for maintaining
		///		:manual for user
		///	).
		///	documentation might autogenerated xml.
		/// </summary>
		/// <remarks>
		/// alias:
		///		man
		/// </remarks>
		Doc


	}
}

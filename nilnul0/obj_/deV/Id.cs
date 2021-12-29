using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV
{
	/// <summary>
	/// the id (a nom followed by a ver) of a deV obj.
	/// <see cref="nameof(nilnul.obj_.deV.IId)"/>
	/// </summary>
	/// <remarks>
	/// id is used to pinmark dev object_ such as:
	///		dnt_:
	///			dir
	///			doc
	///		sln
	///		prj
	///		namespace
	///		gitRepo
	///		type
	///			member
	///				method
	///		variable:
	///			for example t,t1 means local temporary variable as the nom is single letter.
	///		database.
	///			schema
	///			name_
	///				tbl
	///				view
	///				func
	///				proc
	///				trig
	///		pac:
	///			such as nuget package.
	///		
	/// </remarks>
	interface IId:_id_.IVered
	{
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV
{
	/// half of dev is nomenclature, and developer takes up nomenclator, and theoriest is onomastics
	/// naming street/house/ocean/place/bird/creature/animal is hard; you first need to know the thing that you are going to name before giving a good name. <seealso cref="" href="https://en.wikipedia.org/wiki/-onym#Words_that_end_in_-onym"/>
	/// the canonical name is orthonym.
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
	/// <seealso cref="nilnul.txt_.vered_.IId"/>
	public interface IId:

		IWord0empty
		,
		_id_.IVered
		,
		nilnul.txt_.vered_.IId
		,
		nilnul.obj.IId

	{
	}
}

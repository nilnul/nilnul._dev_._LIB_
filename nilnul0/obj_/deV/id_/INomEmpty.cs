using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV.id_
{
	/// <summary>
	/// id with empty nom
	/// with nom being empty, this doesnot imply anything. purely used as a meaningless randomizable handle to denote something.
	///eg:
	///	in db, we use such column named id to denote each row.the id has no any semantics; thus totally reserved and controlled by db maintainers; user cannot edit, and may be able to read or not.
	/// </summary>
	class INomEmpty
	{
	}
}

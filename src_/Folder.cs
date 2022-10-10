using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.folder_.git_;

namespace nilnul.dev.src_
{
	/// <summary>
	/// the src is a shield.
	/// If given an address, the address may
	///		non-exist,
	///			 and can be created a folder
	///		or exist
	///			as a file; thus not a folder.
	///		a folder.	
	/// </summary>
	public interface IFolder { }

	/// <summary>
	/// </summary>
	/// 

	public interface FolderI {

		nilnul.fs.folder_.git_.None folder { get; }

	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_.shield.sortie_;
using nilnul.fs.address_.shields_;

namespace nilnul.dev
{
	/*
	 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
	/// srcs is a collection of address_.shields_.Disjoint.
	/// for a collection of addresses, it shall be converted to shields.
	 
	 */
	/// <summary>
	/// 
	/// srcs is a finite collection of disjoint addresses. note: an address can be a spear or a shield; the address refers to both the address itself (for a file, the blob; for a folder, empty) and its content (for a file, empty; for a folder, the destinations).
	///
	/// srcs in user settings must be prepocessed to be disjoint to act as srcs. So the user settings can be taken as a provider.
	/// 
	///
	/// for user settings, src can be an address nonexists or a file. but a src shall be nonlink folder if it wants to be processed further.
	///
	/// 
	/// All your data should be put in one of the srcs; each src contains a collection of slns
	/// </summary>
	public interface ISrcs {

	}

	
}

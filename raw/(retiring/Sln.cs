using nilnul;
using nilnul.dev;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev
{
	/// <summary>
	/// a "Sln" is a folder which contains a collection of repos. together this collection is to solve a problem; hence providing a solution.
	/// a sln itself is often not a repo. so some files in sln may be out of version control
	/// </summary>
	public class Sln
		//: nilnul.dev.git.Folder
	{
		private nilnul.fs.FolderI _folder;

		public nilnul.fs.FolderI folder
		{
			get { return _folder; }
			set { _folder = value; }
		}

		public Sln(nilnul.fs.FolderI folder)
		{
			_folder = folder;
		}

		public Sln( string location)
			: this(nilnul.fs.Folder.FroAddress(location))
		{
		}


	}
}

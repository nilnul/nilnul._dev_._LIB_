using nilnul;
using nilnul.dev;
using nilnul.fs;
using nilnul.fs.address_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev
{

	public class Sln1 :
		nilnul.fs.Folder
		,
		SlnI
	{
		public Sln1(ShieldI val) : base(val)
		{
		}

		public Sln1(AddressI val) : base(val)
		{
		}

		public Sln1(DirectoryInfo folder) : base(folder)
		{
		}

		public FolderI folder => this;

	}
}

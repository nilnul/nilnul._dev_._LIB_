using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;

namespace nilnul.dev.sln_
{
	public class NotLink :
		nilnul.fs.folder_.Normal

	{
		public NotLink(FolderI val) : base(val)
		{
		}

		public NotLink(ShieldI shield) : base(shield)
		{
		}
	}
}

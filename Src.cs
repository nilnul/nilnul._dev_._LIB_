using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.folder_.git_;

namespace nilnul.dev
{
	public class Src : 
		
		nilnul.obj.Box<nilnul.fs.folder_.git_.None>
		,
		
		SrcI
	{
		public Src( nilnul.fs.folder_.git_.None none):base(none)
		{

		}
		public Src(FolderI val) : this( new fs.folder_.git_.None(val))
		{
		}

		public Src(string address):this( nilnul.fs.Folder.FroAddress(address))
		{

		}

		public None folder => this.boxed;
	}
}

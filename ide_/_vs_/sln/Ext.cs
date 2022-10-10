using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.ide_._vs_.sln
{
	public class Ext:nilnul.fs._address.doc_._exted.Ext
	{
		public const string Name = "sln";
		public const string DOTTED = "." + Name;
		public Ext():base(Name)
		{

		}


		static public Ext Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Ext>.Instance;
			}
		}



	}
}

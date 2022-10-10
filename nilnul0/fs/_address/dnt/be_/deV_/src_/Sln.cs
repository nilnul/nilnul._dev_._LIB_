using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.doc.be_.vs_
{
	public class Sln :

		nilnul.fs._address.doc.be_.Ext //.Ext
	{
		

		public Sln() : base( nilnul.dev.ide_._vs_.sln.Ext.DOTTED)
		{
		}



		static public Sln Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Sln>.Instance;
			}
		}


	}
}

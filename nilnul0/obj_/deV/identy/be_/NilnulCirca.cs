using NuGet.Packaging.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV.identy.be_
{
	public class NilnulCirca : nilnul.txt.BeI
	{
		public bool be(string obj)
		{
			return nilnul.obj_.deV._id._nom.idiom._CircasX.Txts("nilnul").Contains(
				string.Join(
					""
					,
					obj.TakeWhile(c => c != '.')
				)
			);
			
		}


		static public NilnulCirca Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<NilnulCirca>.Instance;
			}
		}

		
	}
}

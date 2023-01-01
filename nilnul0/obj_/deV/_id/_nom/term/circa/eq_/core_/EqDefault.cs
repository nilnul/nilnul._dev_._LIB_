using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._id.nom_.idiom.circa.eq_.core_
{

	public class TxtEqDefault<TEq> : _Core
		where TEq : IEqualityComparer<string>, new()
	{
		public TxtEqDefault() : base(nilnul.obj_.Singleton<TEq>.Instance)
		{
		}

		static public TxtEqDefault<TEq> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<TxtEqDefault<TEq>>.Instance;
			}
		}

	}
	
}

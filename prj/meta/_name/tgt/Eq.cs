using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj._name.tgt
{
	public class Eq : IEqualityComparer<string>
	{
		public bool Equals(string x, string y)
		{
			return  nilnul.obj_.deV._id.nom_.idiom.circa.eq_.core_.CaseInsentive.Singleton.Equals(x,y)
			||
			sln.prj._name._tgt.primitive.alias._SortieX.Sortie_ofCirca(
				x
			).Contains(
				y
				,
				nilnul.obj_.deV._id.nom_.idiom.circa.eq_.core_.CaseInsentive.Singleton
			)
			;

		}

		public int GetHashCode(string obj)
		{
			return 0;
			//throw new NotImplementedException();
		}


		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}

	}
}

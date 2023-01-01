using nilnul.obj_.deV._id._nom._idiom._casible.concept_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._id._nom._idiom._casible.concepts.be_
{
	/*extern alias obj;*/
	public class Valid :

		nilnul.obj.BeI1<ConceptsI>,BeI
	{
		public bool be(ConceptsI obj)
		{
			return obj.Count() > 0
				&& obj.First() is EntityI
				&& obj.Last() is EntityI
				&& NoAdjacentJunct(obj)
			;
			//throw new NotImplementedException();
		}

		static public bool NoAdjacentJunct(ConceptsI obj) {

			return nilnul.bit.str_.enumable.be_.Adjacent.Singleton.be(
				obj.Select(x=> x is concept_.JuncI)
			);
		}

		

		
	}
}

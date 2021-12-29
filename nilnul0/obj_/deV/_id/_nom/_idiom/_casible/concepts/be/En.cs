using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._id._nom._idiom._casible.concepts.be
{
	public class En<T> : nilnul.obj.be.En2<ConceptsI, T>
		where T : BeI, new()

	{
		public En(ConceptsI val) : base(val)
		{
		}
	}
}

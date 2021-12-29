using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln.prj._name._tgt.primitive
{
	/// <summary>
	/// explicitly implement this class  to avoid common pitfall for programmers using other Contain without heeding the "case", "circa".  "name-of-seg" is not processed here, so programmers need to care for that.
	/// </summary>
	public class Aliases
		: nilnul.obj.Box1<IEnumerable<string>>
		,
		nilnul.obj._collection_.ContainI<string>
	{
		public Aliases(IEnumerable<string> val) : base(val)
		{
		}

		/// <summary>
		/// circa removed. case insensitive
		/// </summary>
		/// <param name="element"></param>
		/// <returns></returns>
		public bool contain(string element)
		{
			return boxed.Contains(element,
				nilnul.obj_.deV._id.nom_.idiom.circa.eq_.core_.CaseInsentive.Singleton
				);
			//throw new NotImplementedException();
		}
	}
}

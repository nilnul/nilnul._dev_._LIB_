using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj._life.prep.integrate
{
	/// <summary>
	/// build will trigger the postbuild event, where pak (or publish if this is an app/web/db, possibly to a staging area, where another deploy project life is on) is automatically triggered for library project and pushed.
	/// So we merge the two phase together here.
	/// </summary>
	/// alias:
	///		publish
	///		integration
	///			like in Continuos Integration
	///		delivery
	///			like in continous delivery.
	///			but integration means merge others' job, delivery means let other able to integrate ours.
	///		build9pak
	///		
	class IDeliver
	{
	}
}

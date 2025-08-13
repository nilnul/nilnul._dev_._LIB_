using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev._design.diagram_.dynam_
{
	/// <summary>
	/// event graph; <see cref="nilnul.task.prj.simulate"/>.
	/// </summary>
	/// <remarks>
	/// the event is pushed to the scheduler one after another. if its schedule time is the same, then first in first out rule is upheld;
	/// </remarks>
	internal class IDiscreteEvent
	{
	}
}

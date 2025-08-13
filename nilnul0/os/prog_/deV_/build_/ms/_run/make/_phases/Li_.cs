using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog_.deV_.build_.ms._run.make._phases
{
	internal enum Li_
	{

		/// <summary>
		/// Evaluation is the first phase of a project build. All properties and items are evaluated in the order in which they appear in the project. Imported projects are evaluated as they are encountered in the project. Targets and tasks are not run until the execution phase, and any properties or items they would declare or emit are ignored during evaluation.
		/// </summary>
		Evaluation
			,
		/// <summary>
		/// Targets and tasks are not run until the execution phase, and any properties or items they would declare or emit are ignored during evaluation.
		/// Execution is the second phase of a project build. Selected targets are built and tasks are run. Properties and items can be created or modified compared to their evaluation values.
		/// </summary>
		Execution
	}
}

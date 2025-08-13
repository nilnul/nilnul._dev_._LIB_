using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.win.prog_.builder_._ms._options
{
	class AllCfg
	{
		/*
		You can't by default build all configurations using MSBuild command line options. In order to do this you need to create a new target (VS Project).

The way I do it is:

msbuild /t:BuildAll /Configuration:"Debug;Release;ContinuousIntegration"
		 */
	}
}

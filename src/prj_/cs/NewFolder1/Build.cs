using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Build.BuildEngine;
using Microsoft.Build.Execution;
using Microsoft.Build.Framework;
using Microsoft.Build.Evaluation;

namespace nilnul.dev.src.prj_.vS_.cs
{
	public static class _BuildX
	{
		// Requires the following references:
		// Microsoft.Build.Engine
		// Microsoft.Build.Framework

		[Obsolete()]
		public static bool Succeeded(string projectFile, string target, IDictionary<string, string> properties)
		{
			Engine engine = new Engine();
			engine.RegisterLogger(new ConsoleLogger());
			BuildPropertyGroup buildProperties = new BuildPropertyGroup();
			foreach (KeyValuePair<string, string> property in properties)
			{
				buildProperties.SetProperty(property.Key, property.Value);
			}

			return engine.BuildProjectFile(projectFile, new[] { target }, buildProperties);
		}
		public static BuildResult Result(string projectFile, string target, IDictionary<string, string> properties)
		{
			BuildParameters parameters = new BuildParameters(new ProjectCollection())
			{
				Loggers = new ILogger[] { new ConsoleLogger() }
			};
			return BuildManager.DefaultBuildManager.Build(
				parameters,
				new BuildRequestData(projectFile, properties, null, new[] { target }, null));
		}

	}
}
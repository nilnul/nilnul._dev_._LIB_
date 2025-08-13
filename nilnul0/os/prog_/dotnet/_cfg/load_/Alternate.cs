using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;
using System.Configuration.Assemblies;

namespace nilnul.win.program_.dotnet._cfg.load_
{
	/*The hack in the linked question works if it is used before the configuration system is used the first time. After that, it doesn't work any more.
The reason:
There exists a class ClientConfigPaths that caches the paths. So, even after changing the path with SetData, it is not re-read, because there already exist cached values. The solution is to remove these, too:*/


	public abstract class Alt : IDisposable
	{
		public static Alt Change(string path)
		{
			return new ChangeAppConfig(path);
		}

		public abstract void Dispose();

		private class ChangeAppConfig : Alt
		{
			private readonly string oldConfig =
				AppDomain.CurrentDomain.GetData("APP_CONFIG_FILE").ToString();

			private bool disposedValue;

			public ChangeAppConfig(string path)
			{
				AppDomain.CurrentDomain.SetData("APP_CONFIG_FILE", path);
				ResetConfigMechanism();
			}

			public override void Dispose()
			{
				if (!disposedValue)
				{
					AppDomain.CurrentDomain.SetData("APP_CONFIG_FILE", oldConfig);
					ResetConfigMechanism();


					disposedValue = true;
				}
				GC.SuppressFinalize(this);
			}

			private static void ResetConfigMechanism()
			{
				typeof(ConfigurationManager)
					.GetField("s_initState", BindingFlags.NonPublic |
											 BindingFlags.Static)
					.SetValue(null, 0);

				typeof(ConfigurationManager)
					.GetField("s_configSystem", BindingFlags.NonPublic |
												BindingFlags.Static)
					.SetValue(null, null);

				typeof(ConfigurationManager)
					.Assembly.GetTypes()
					.Where(x => x.FullName ==
								"System.Configuration.ClientConfigPaths")
					.First()
					.GetField("s_current", BindingFlags.NonPublic |
										   BindingFlags.Static)
					.SetValue(null, null);
			}
		}
	}
	//Usage is like this:

	// the default app.config is used.
	//using(AppConfig.Change(tempFileName))
	//{
	//    // the app.config in tempFileName is used
	//}
	// the default app.config is used.
	//If you want to change the used app.config for the whole runtime of your application, simply put AppConfig.Change(tempFileName) without the using somewhere at the start of your application.*/

}

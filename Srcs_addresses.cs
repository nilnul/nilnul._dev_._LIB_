using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address;
using nilnul.fs.address_.shield.sortie_;
using nilnul.fs.address_.shields_;
using nilnul.fs.addresses_.disjoint_;

namespace nilnul.dev
{
	public class Srcs_addresses:
		_srcs_.AddressesA
		,
		SrcsI_addresses
	{



		public Srcs_addresses(EndMatters val) : base(val)
		{
		}

		public Srcs_addresses()
		{
		}

		static public Srcs_addresses FroAddresses(IEnumerable<string> folders) => new Srcs_addresses( new nilnul.fs.addresses_.disjoint_.EndMatters(folders))
		;
		static public Srcs_addresses FroAddresses(params string[] folders) => FroAddresses ((IEnumerable<string>)folders)
	;
		static public Srcs_addresses FroAddresses(StringCollection stringCollection) => FroAddresses(
			stringCollection.Cast<string>()
		);

		 public IEnumerable<nilnul.fs.AddressI> filterFolder() {

			return this.Where(x=> nilnul.fs.address.be_.Folder.Singleton.be(x) );
		}

		 public IEnumerable<nilnul.fs.folder_.Normal> fileteredFoldersDelinked() {

			return this.filterFolder().Select(x=> nilnul.fs.folder_.nonlink.coerce_._TgtX.Normal(x) );
		}


		 public IEnumerable<nilnul.fs.folder_.Normal> toDisjointNonlinks() {

			var links = fileteredFoldersDelinked();

			nilnul.fs.folders.be_.disjoint.VowOfSeq.Singleton.vow(links.Select(x=>x.en));

			return links;

		}

		public static Srcs_addresses OvCfg()
		{

			/// monitor the configuration
			///
#if DEBUG122222222

			/*
			 When you run the program in Visual Studio, app.config is copied into YourProgram.exe.config. Then the program reads its default values from there (it never accesses the original app.config). When it executes Setting.Default.Save(), the User setings get saved into a private XML file located within a hidden subfolder under the user's home folder (the exact location varies depending on the version of Windows). The next time you run the program, the User settings are read from this last XML file (while Application settings are still read from YourProgram.exe.config, which is not modified by the .Save()).
			 */
			//there can be three configuration files using the inbuilt (System.Configuration) support.In addition to the machine config: app.exe.config, user roaming, and user local.

			//To get the "global" configuration(exe.config):
			//ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
			//					.FilePath

			var path = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).FilePath;

			var file = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;

			var pathPerUserr = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming).FilePath;

			var pathPerLocal = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath;



			var map = new ExeConfigurationFileMap { ExeConfigFilename = "MyComponent.dll.config" };
			var path1 = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None).FilePath;

			/*
			 As pointed out by Schadensbegrenzer for web application you will need another code to load the config file:

Configuration config = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("~");


			ApplicationSettings (i.e. settings.settings) use PerUserRoamingAndLocal for user settings by default (as I remembered).

			My problem was that I called Reset() before Reload(). Actually my test case checks whether the objects are stored correctly, so it saves and reloads the settings. I was unaware of the fact, that Reset() "resets and saves on disk" - I was assuming it only resets in memory. I must only call Reload().

Since all test cases have their own directory, the settings have to be created (saved) within the test case.


			************for test

			The path scheme to these folder is of the kind:

Windows 10 path:

C:\Users\$USER$\AppData\Local\Microsoft_Corporation\UnitTestAdapter__Running__StrongName_{guid}\{number}
			 */

#endif
			return new Srcs_addresses(
			_srcs._CfgedX.Disjoint()
			);
		}
	




	}
}

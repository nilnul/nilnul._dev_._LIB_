using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.sln_.nonlink.div_.nonlink_._intent
{
	static public class _EnsureIniX
	{
		static public void Setup(string folderAddress, nilnul.win.prog_.Git git = null)
		{
			Trace.TraceInformation($@"ini-ing {folderAddress} as undoneIntent...");
			//Trace.Indent();
			var container = nilnul.fs.address_.Shield.Parse(
					folderAddress
				);
			var folder = new nilnul.fs.Folder(container);
			try
			{
				nilnul.fs.git._module.ini._EnsureX1.OfFolderAddress(folder.ToString());
				//Trace.Unindent();
				Trace.TraceInformation("ini-ed");
			}
			catch (Exception x)
			{
				//Trace.Unindent();
				Trace.TraceError($"exception:{x} when ini-ing {folderAddress}");
				return;
				//throw;
			}
		}
	}
}

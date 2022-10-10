using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.dev.sln.as_.dst.name;
namespace nilnul.dev.sln.name
{
	/// <summary>
	/// rename a.b(re.mark).c to a.b._c_
	/// </summary>
	/// <remarks>
	/// aka:innerize
	/// </remarks>
	/// <exception cref="">
	///		target folder exists;
	///		folder is in use.
	/// </exception>
	/// todo:
	static public class _InfixerX
	{
		static public void Exe(nilnul.fs.FolderI folder) {
			///parse the input
			///

			var tip = folder.address.en.stem.div.dirs.Last().denote.ToString();

			var compiled = new nilnul.dev.sln.as_.dst.name._infixer.Compile();
			compiled.exe(tip);

			if (compiled.beErr)
			{
				Trace.TraceError(compiled.errMsg);

			}
			else
			{
				if (compiled.parsed.tip.isNormalized())
				{

				
				}
				else
				{
					Trace.TraceInformation($"renaming folder: {folder}");
					//Trace.Indent();
					nilnul.fs.folder_.baseDir._RenameX.FolderInAddress(
						folder.ToString()
						,
						compiled.parsed.normalize().ToString()
						
					);
					//Trace.Unindent();


				}
				

			}

			//throw new NotImplementedException();

		}

		static public void Exe(string folder) {
			Exe( nilnul.fs.Folder.FroAddress(folder) );
		}
	}
}

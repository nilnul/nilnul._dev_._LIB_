using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_.spear;
using nilnul.obj.str;

namespace nilnul.dev.src.prj_.cs.built
{
	/// <summary>
	/// <see cref="	nameof(_config.IPrjRef)"/>.
	/// if the prj is recently build using a different config, then the built in this config is not the newest.
	/// </summary>
	static public class _OutsX
	{
	


		static public IEnumerable<(string,AssemblyName)> Specs_ofPrjNomina(string prjNomina)
		{


			var prjFile = nilnul.dev.src.sln.sub.synd.prj_.cs._meta._LocateX.SpearNulable_ofMain(prjNomina);

			var bin = System.IO.Path.Combine(
				prjFile.parent.ToString()
				,
				"bin"

			);
			var dirs = System.IO.Directory.EnumerateDirectories(bin);

			var dlls = dirs.Select(
				d => System.IO.Path.Combine(
					bin
					,
					d
					,
					$"{prjNomina}.dll"
				)
			);

			foreach (var item in dlls)
			{
if (
					nilnul.fs.address_.spear.BeX1.Be(
						nilnul.fs.address_.spear.be_.File.Singleton,item)
					)
					{
						var assemblyMeta = AssemblyName.GetAssemblyName(item);
						yield return (item, assemblyMeta);//.Version;

					}
			}
			

		}
		




	}
}

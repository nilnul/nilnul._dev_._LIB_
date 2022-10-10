using nilnul.fs.address_;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace nilnul.dev.prj_.cs.version
{
	/// <summary>
	/// change assmeblyInfo.cs such that version is not '*' generated.
	/// </summary>
	static public class _DefiniteX
	{
		static public void _OfFolder(
			string folder
		)
		{


			var file = System.IO.Path.Combine(
				folder,
				"Properties"
				,
				"AssemblyInfo.cs"
			);

			var allLines = System.IO.File.ReadAllLines(file);

			var changed = false;

			var changedLines = allLines.Select(
				l =>
				{
					if (changed)
					{
						return l;
					}

					var matches = Regex.Match(
						l
						,
						@"^\s*\[\s*assembly:\s*AssemblyVersion\s*\(\s*""(?<major>\d+)\.(?<minor>\d+)\.\*""\s*\)\s*\]\s*$"
					);

					if (matches.Success)
					{
						changed = true;

						return $@"[assembly: AssemblyVersion(""{matches.Groups["major"]}.{
							int.Parse( matches.Groups["minor"].Value)
							+1   //as we restart the growing of sequence, we need to ensure new ones are bigger.
						}"")]";  /*
						              * we have 3 options for (patch.revision):
						              *		-) 0.0
						              *			this one might be collapsed by some library,resulting some discrepancies.
						              *			but we need only the major and minor for package, the patch and revision are for dll only.
						              *		-) 0.1
						              *		-) 1.1
						              
						              */
					}
					return l;

				}
			).ToArray();

			if (changed)
			{
				System.IO.File.WriteAllLines(
					file,

					changedLines

				);
			}

		}
		static public void OfNomina(
			string prjNomina
		)
		{
			//string prjNomina = "nilnul._web_._LIB_";
			var prjFile = nilnul.dev.src.sln.sub.synd.prj_.cs._meta._LocateX.SpearNulable_ofMain(prjNomina) ?? throw new NullReferenceException($"{prjNomina}'s file unfound.");
			//var prjSynd = nilnul.dev.src.sln.sub.synd.prj_.cs._meta._LocateX.._meta._LocateX.SpearNulable_ofMain(prjNomina) ?? throw new NullReferenceException($"{prjNomina}'s file unfound.");

			var folder = prjFile.parent.ToString();

			_OfFolder(folder);



		}

		public static void OfFolder(ShieldI parent)
		{
			_OfFolder(parent.ToString());
		}
	}
}

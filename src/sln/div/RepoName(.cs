using nilnul.fs._address.dir.str_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln.div
{
	static public class _RepoNameX
	{
		public static IEnumerable<string> Ids(IEnumerable<fs._address.DirI> dirs)
		{
			return
				dirs.Select(
					d => fs.folder._repoName.dir.name_.idioms0Comments._ParseX.Parse(
						d.denote.ToString()
					).name
				).Select(
					t => nilnul.txt.convert_.trim_.White.Singleton.op(t)
				).Where(
					trimed => !string.IsNullOrEmpty(trimed)
				)
			;

		}

		static public IEnumerable< string> Ids(nilnul.fs._address.DivI container)
		{
			

			return Ids( container.dirs );
			

			//var dirs = nilnul.fs.address_.shield.co_.sup._DifX._ofSupSub(
			//		src, container
			//	).dirs.ToArray();
			//var parts = new List<string>();

		}

	}
	/// <summary>
	/// if the div is a gitWorkbase, autoname the repo
	/// </summary>
	/// <remarks>
	///		<see cref="nameof(nilnul.fs.folder.repoName_.ThrowIfNotInSrc)"/>
	/// </remarks>
	interface IRepoName
	{
	}

}

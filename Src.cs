using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.folder_.git_;

namespace nilnul.dev
{
	/// <summary>
	/// src is a movable "disk root"; so src must be a folder (or folderable, i.e, a folder, or an unoccupied address that can be createa), not a file, in order to be extensible(for example, create a cfg file or a backend repo objects holding dir).
	/// if the src is a file, the file is regarded as a pac(such as compressed .zip file) and can be extracted/decompressed as a folder. If the file is not a pac, it might be understood as a pac containing the file itself; or an empty folder with some tag.
	/// 
	///		as the root of a disk, a file must be in some src. so Src is a folder, and not a file.
	/// src can be a link; but we  can convert it into a nonlink src.
	/// src, in terms of git, shall be a plain folder. src itself is not managed by git, but src's directories are.
	/// </summary>
	/// <remarks>
	/// src contributes empty string to the naming of sub repo or other objects
	///		This is intended as a trivia case is always needed for non-intruding.
	///		src is not checked into repo4srcCtr, as no repo can be named empty. And also we may have a variety of src folder, each of which is intended for unqiue configurations.
	///			to mitigate the issue of not being able to repo control src docs(such as Directory.Build.props, ...), we can:
	///				1) either create a repo of empty name. for repo svr disallowing empty name, name a repo of special name equivalent to escaped empty string
	///				2) create a super sln, and put other slnS as divs under the super sln.
	/// </remarks>
	public interface ISrc {

	}
	/// <summary>
	/// slns. we can have more than one codebase; i.e., we have codebases.
	/// All your data should be put in one of the srcs; each src contains a collection of slns
	/// </summary>
	/// 

	public interface SrcI:ISrc {

		nilnul.fs.folder_.git_.None folder { get; }

	}
	public class Src : 
		
		nilnul.obj.Box<nilnul.fs.folder_.git_.None>
		,
		
		SrcI
	{
		public Src( nilnul.fs.folder_.git_.None none):base(none)
		{

		}
		public Src(FolderI val) : this( new fs.folder_.git_.None(val))
		{
		}

		public Src(string address):this( nilnul.fs.Folder.FroAddress(address))
		{

		}

		public None folder => this.boxed;
	}
}

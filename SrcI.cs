namespace nilnul.dev
{
	/// <summary>
	/// slns. we can have more than one codebase; i.e., we have codebases.
	/// All your data should be put in one of the srcs; each src contains a collection of slns
	/// </summary>
	/// 

	public interface SrcI:ISrc {

		nilnul.fs.folder_.git_.None folder { get; }

	}
}

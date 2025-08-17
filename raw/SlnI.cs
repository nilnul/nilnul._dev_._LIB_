namespace nilnul.dev
{
	/// <summary>
	/// a "Sln" is a folder ( unlinked preferred).
	/// It may be a repo (.git), for example, in case of "bare repo"
	/// </summary>
	public interface  SlnI
	{
		nilnul.fs.FolderI folder { get; }
	}
}

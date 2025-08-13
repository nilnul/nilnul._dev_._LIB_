namespace nilnul.dev.prj
{
	/// <summary>
	/// we can have multiple proj (such as .csproj) files in a prj folder.
	/// eg:
	///		we might need to build the same source code as a framework4.x library or a netstandard2.0 or a dotnet 5plus, using different metas in the same folder for the same source code;
	/// </summary>
	/// <remarks>
	/// If multiple .proj files are present, you must specify to msbuild.exe which one to use.
	/// A single file must be specified.
	/// </remarks>
	public interface IMetas { }
}

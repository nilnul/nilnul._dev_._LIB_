namespace nilnul.os.prog_.deV_.build_.ms._run._make.item.meta_
{
	///learn.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2015/msbuild/msbuild-well-known-item-metadata?view=vs-2015&redirectedfrom=MSDN
	///
	/// <summary>
	/// eg:
	/// If the folder:
	///		C:\MySolution\MyProject\Source\
	///		contains the file Program.cs, and if the project file contains this item:
	///		
	/// <ItemGroup>
	/// <MyItem Include="C:\**\Program.cs" />
	/// </ItemGroup>
	/// 
	/// then the value of %(MyItem.RecursiveDir) would be:
	///		MySolution\MyProject\Source\
	/// </summary>
	interface IRecursiveDir { }
}

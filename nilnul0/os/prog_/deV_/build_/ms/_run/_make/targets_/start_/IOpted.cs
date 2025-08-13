namespace nilnul.os.prog_.deV_.build_.ms._run._make.targets_
{
	/// <summary>
	/// targets are specified in the command line;
	/// If targets are specified in both the InitialTargets and DefaultTargets attributes and no target is specified on the command line, MSBuild runs the targets specified in the InitialTargets attribute followed by the targets specified in the DefaultTargets attribute.
	/// </summary>
	/// <remarks>
	/// If a default target is not defined in the project file, or if you do not want to use that default target, you can use the command line switch -target to specify a different target. The target or targets specified with the -target switch are run instead of the targets specified by the DefaultTargets attribute. Targets specified in the InitialTargets attribute always run first.
	///
	/// </remarks>
	interface IOpted { }
}

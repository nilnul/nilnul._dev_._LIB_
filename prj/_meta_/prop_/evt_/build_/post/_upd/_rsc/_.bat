echo ConfigurationName is $(ConfigurationName)

if $(ConfigurationName) == Release (
	"NuGet.exe" pack "$(ProjectPath)" -Prop Configuration=$(ConfigurationName) -Exclude **/*.tt -Version @(MajorMinor).$(nilnulPatchRevision)
	"NuGet.exe" push $(TargetName).@(MajorMinor).$(nilnulPatchRevision).nupkg -SkipDuplicate -Source local
	"NuGet.exe" push $(TargetName).@(MajorMinor).$(nilnulPatchRevision).nupkg -SkipDuplicate -Source my
) ELSE (
	rem Symbols for local debug before release and push
	
	if  $(ConfigurationName)==Symbol (
		"NuGet.exe" pack "$(ProjectPath)" -Symbols -Prop Configuration=$(ConfigurationName) -Exclude **/*.tt -Version @(MajorMinor).$(nilnulPatchRevision)
		"NuGet.exe" push $(TargetName).@(MajorMinor).$(nilnulPatchRevision).symbols.nupkg -SkipDuplicate -Source local
		"NuGet.exe" push $(TargetName).@(MajorMinor).$(nilnulPatchRevision).symbols.nupkg -SkipDuplicate -Source my
	)
	if  $(ConfigurationName)==Nuget (
		"NuGet.exe" pack "$(ProjectPath)"  -Prop Configuration=$(ConfigurationName) -Exclude **/*.tt -Version @(MajorMinor).$(nilnulPatchRevision)
		"NuGet.exe" push $(TargetName).@(MajorMinor).$(nilnulPatchRevision).nupkg -SkipDuplicate -Source nuget.org
		rem  need to set apikey for the nuget user: nilnul.
		rem set apikey for other user, then you will get invalid token error.
	)

)

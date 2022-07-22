echo ConfigurationName is $(ConfigurationName)

if $(ConfigurationName) == Release (
	"NuGet.exe" pack "$(ProjectPath)"  -Prop Configuration=$(ConfigurationName) -Exclude **/*.tt
	"NuGet.exe" push $(TargetName).@(VersionNumber).nupkg -Source local
	"NuGet.exe" push $(TargetName).@(VersionNumber).nupkg -Source my
) ELSE (
	rem Symbols for local debug before release and push
	rem Symbols is new. Symbols4Debug is legacy. (Debug is for slnWide debug. Symbols is for computerWide debug)


	if  $(ConfigurationName)==Symbols4Debug (

		"NuGet.exe" pack "$(ProjectPath)" -Symbols -Prop Configuration=$(ConfigurationName) -Exclude **/*.tt
		"NuGet.exe" push $(TargetName).@(VersionNumber).symbols.nupkg -Source local
		rem "NuGet.exe" push $(TargetName).@(VersionNumber).symbols.nupkg -Source my
	)
	if  $(ConfigurationName)==Symbols (

		"NuGet.exe" pack "$(ProjectPath)" -Symbols -Prop Configuration=$(ConfigurationName) -Exclude **/*.tt
		"NuGet.exe" push $(TargetName).@(VersionNumber).symbols.nupkg -Source local
		rem "NuGet.exe" push $(TargetName).@(VersionNumber).symbols.nupkg -Source my

	)
	if  $(ConfigurationName)==Symbol (
		"NuGet.exe" pack "$(ProjectPath)" -Symbols -Prop Configuration=$(ConfigurationName) -Exclude **/*.tt
		"NuGet.exe" push $(TargetName).@(VersionNumber).symbols.nupkg -Source local
		"NuGet.exe" push $(TargetName).@(VersionNumber).symbols.nupkg -Source my

	)
	if  $(ConfigurationName)==Nuget (
		"NuGet.exe" pack "$(ProjectPath)"  -Prop Configuration=$(ConfigurationName) -Exclude **/*.tt
		"NuGet.exe" push $(TargetName).@(VersionNumber).nupkg -Source nuget.org
		rem  need to set apikey for the nuget user: nilnul
	)
)

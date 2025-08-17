if $(ConfigurationName) == Release (
	"NuGet.exe" pack "$(ProjectPath)"  -Prop Configuration=$(ConfigurationName) -Exclude **/*.tt
	"NuGet.exe" push $(TargetName).@(VersionNumber).nupkg -Source local
	"NuGet.exe" push $(TargetName).@(VersionNumber).nupkg -Source my
) ELSE (

	setlocal
	set condition=0
	rem Symbols is new. Symbols4Debug is legacy

	if not $(ConfigurationName)==Symbols4Debug if not $(ConfigurationName)==Symbols set condition=1

	if condition==0 (

		"NuGet.exe" pack "$(ProjectPath)" -Symbols -Prop Configuration=$(ConfigurationName) -Exclude **/*.tt
		"NuGet.exe" push $(TargetName).@(VersionNumber).symbols.nupkg -Source local
		rem "NuGet.exe" push $(TargetName).@(VersionNumber).symbols.nupkg -Source my

	)
	endlocal
)

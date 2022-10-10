namespace nilnul.dev.prj_.cs._meta_
{
	/// <summary>
	/// A target is a named sequence of tasks.
	/// target using task.
	/// </summary>
	interface ITarget {

	}

	/*
	 
<PropertyGroup>
  <MyProperty>Name_Something</MyProperty>
</PropertyGroup>

<Target Name="RegexReplace">
  <RegexReplace Input="$(MyProperty)" Expression="_.*" Replacement="" Count="1">
    <Output ItemName ="PropertyNameRegex" TaskParameter="Output" />
  </RegexReplace>

  <Message Text="PropertyNameRegex: @(PropertyNameRegex)"/>
</Target>

stackoverflow.com/questions/3094496/msbuild-getting-property-substring-before-underscore-symbol
answered Jun 23, 2010 at 6:43
Julien Hoarau
;edited Oct 15, 2017 at 5:05
kkm

	 */

	
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj_.cs._meta_.item.function_
{
	/// <summary>
	/// 
	/// </summary>
	class IMetaish
	{
		/*
		 stackoverflow.com/questions/51110827/msbuild-property-function-contains-on-metadata
Jul 9, 2018 at 6:43
Michael Baker

WithMetadataValue which is an ItemFunction

https://msdn.microsoft.com/en-us/library/ee886422.aspx

<ItemGroup>  
    <TheItem Include="first">  
        <Plant>geranium</Plant>  
    </TheItem>  
    <TheItem Include="second">  
        <Plant>algae</Plant>  
    </TheItem>  
    <TheItem Include="third">  
        <Plant>geranium</Plant>  
    </TheItem>  
</ItemGroup>  

<Target Name="go">  
    <Message Text="MetaData:    @(TheItem->Metadata('Plant'))" />  
    <Message Text="HasMetadata: @(theItem->HasMetadata('Plant'))" />  
    <Message Text="WithMetadataValue: @(TheItem->WithMetadataValue('Plant', 'geranium'))" />  
    <Message Text=" " />  
    <Message Text="Count:   @(theItem->Count())" />  
    <Message Text="Reverse: @(theItem->Reverse())" />  
</Target>  

  <!--   
  Output:  
    MetaData:    geranium;algae;geranium  
    HasMetadata: first;second;third  
    WithMetadataValue: first;third  

    Count:   3  
    Reverse: third;second;first  
  -->  
*/
	}
}

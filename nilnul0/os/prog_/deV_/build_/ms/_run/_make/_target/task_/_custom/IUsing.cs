using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog_.deV_.build_.ms._run._make._target.task_._custom
{
	/*
   <UsingTask AssemblyFile="C:\CustomTasks\MyTask.dll" 
              TaskName="MyTask.MyTouch"/>
   <Target Name="TouchTheCsFiles" >
      <MyTouch Files= "@(CsSrcFiles)"/> 
   </Target>
</Project>


	It is interesting to note that all standard tasks are declared by <UsingTask> elements located in the Microsoft.Common.Tasks file. 
	 */
	internal class IUsing
	{

	}
}

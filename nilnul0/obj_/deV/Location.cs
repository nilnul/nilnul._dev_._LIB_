using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV
{
	/// <summary>
	/// where to put an object into the file system.
	/// </summary>
	class Location
	{
		/*
		 an object is stored at different phases of its lifecycl:
			1) procurement/buy/create
		eg:
			when to buy a lock
		this is put into [my].[Liveing].[buy_]
			2) build; provisioned; supplied.
				into a project that researches its inner workings.
		eg:
			for a electronic lock,
		at this stage, it's put into [nilnul].[Electronic]
		3) when archived, it's put into a project embodying its intention/usage/appliance/semantics
		eg:
		for an electronic lock,
		this might be put into [nilnul].[House]

		later stage will include reference to prior stages.
		Thus we can always find all the needed info at a final stage.
		 */
	}
}

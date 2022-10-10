using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln.prj_
{
	/// <summary>
	/// to use already available as much as possible; that is the reason why we are builting libraries by ourselves for us and others.
	/// but for a single component in a lib, we donot need to create an adapter prj; instead we create an adapter class in our self-made library.
	/// 
	/// </summary>
	/// <example>
	/// nilnul._img_._accord_ uses "Accord.Video.FFMpeg" for nilnul.img. 'cuz it's a 3rd party project, so we create an adapter project in our very own nilnul._img_ sln.
	/// And when Accord.Video.FFMpeg is archived, and there are issues with Accord.Video.FFMpeg when used in WebProject published to shared hosting, where c++ redistribution library is not available while Accord.Video.FFMpeg needs it, we can unplug Accord.Video.FFMPeg but keep nilnul._img_, possibly searching other 3rd party to carry on the job that Accord.Video.FFMpeg does.
	/// </example>
	interface IAdapter
	{
	}
}

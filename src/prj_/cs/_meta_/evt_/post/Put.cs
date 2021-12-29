using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.dev.prj_.cs.evt_.post
{
	/// <summary>
	/// edit the project file, and comment out the settings that introduces ".snk"
	/// </summary>
	///

	[Obsolete("see nilnul.dev.pac")]
	static public class _PutX
	{
		static public void Vod(
			string prjFile
		)
		{
			var xml = XDocument.Load(prjFile);

			

			var el1=xml.Descendants("PostBuildEvent");

			if (el1.Any())
			{
				el1.First().Value = nilnul.dev.src.prj_.cs.evt_.post._put.Resource1.content;

			}
			else
			{

			}



			xml.Save(prjFile);
			

			

		}
		

		

	}
}

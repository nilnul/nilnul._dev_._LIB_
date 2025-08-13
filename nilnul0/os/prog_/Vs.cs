using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.win.prog_
{
	/*
	 
	 */
	public class VisualStudio
	{

		public const string Dnt = @"Microsoft Visual Studio";

		public static nilnul.fs._address.Document Denotation =   nilnul.fs._address.DenotationX.OvDnts(
nilnul.win.Programs.DEFAULT_86_INSTALL_DST_86
			,
Dnt
			);
		public static nilnul.fs._address.Document Denotation2022 =   nilnul.fs._address.DenotationX.OvDnts(
nilnul.win.Programs.DEFAULT_64_INSTALL_DESTINATION
			,
Dnt
			);



		public static nilnul.fs.address_.ShieldI shield = new nilnul.fs.address_.Shield(
			nilnul.Win.Vol
			,
			Denotation
		);
		public static nilnul.fs.address_.ShieldI Shield2022 = new nilnul.fs.address_.Shield(
			nilnul.Win.Vol
			,
			Denotation2022
		);


		public static nilnul.fs.address_.ShieldI yr2019Community = nilnul.fs.address_.shield_.baseDiv_._DivInDivisionX.BaseDiv(shield, "2019/Community");
		public static nilnul.fs.address_.ShieldI Yr2022Community = nilnul.fs.address_.shield_.baseDiv_._DivInDivisionX.BaseDiv(Shield2022, "2022/Community");

	}
}

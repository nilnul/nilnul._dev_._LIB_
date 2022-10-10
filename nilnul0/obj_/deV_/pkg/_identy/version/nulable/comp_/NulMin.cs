using nilnul.obj_.deV_.pkg._identity.version_;
using NuGet.Versioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV_.pkg._identity.version.nulable.comp_
{
	

	
	public class NulMin :
		nilnul.obj.nulable.comp_.nulMin_.ComparerDefault<
			nilnul.obj_.deV_.pkg._identity.IVersion,
			version.Comparer
		>
		,
		IComparer<nilnul.obj_.deV_.pkg._identity.IVersion>

	
	
		

	{


		static public NulMin Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<NulMin>.Instance;
			}
		}

		
	}

	public class NulMin4abstract :
		nilnul.obj.nulable.comp_.nulMin_.ComparerDefault<
			nilnul.obj_.deV_.pkg._identity.VersionA,
			version.Comparer
		>
		,
		IComparer<nilnul.obj_.deV_.pkg._identity.VersionA>


	
	
		

	{


		static public NulMin4abstract Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<NulMin4abstract>.Instance;
			}
		}

		
	}

}

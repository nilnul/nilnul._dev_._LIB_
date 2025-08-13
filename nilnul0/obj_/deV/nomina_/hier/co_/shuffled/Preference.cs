namespace nilnul.obj_.deV._identy.nomina_.hier.co_.shuffled
{
	/// <summary>
	/// for two shuffled <see cref="Hierarchy"/>, one is prefered. eg:
	///		a_.b_.c_
	///		can be changed to:
	///		a_.c_.b_
	///		, if the latter is preferred.
	///	the preference relation is axiomatised  acyclic. So by recurrence, we can <see cref="hier.op_.Canonize"/> to a single primary one.
	/// </summary>
	/// <remarks>
	/// from general to more specific.
	/// ,eg:
	///		task.slate_.recur_.daily_.shanghai_.Google
	///		,that's cuz daily is more general than timezone:Shanghai, and google is one of such service, less scaled than Shanghai.
	/// </remarks>
	/// 
	internal class Preference
	{
		/// stipulation:
		/// 
		///		axiomatize that some is preferred
		///
		///
		/// 
		///	infoGain:
		///		eg:
		///		
		///			for <see cref="	nilnul.dev.bak"/>
		///			==================================---------------------------
		///			,	for sln.directory_.delvable_.unpartic.Bak, there are two path:
		///			
		///				, whether it's intended or not. then for not intended, we need to determine whether it's worktop, and for intended, we don't need to;
		///					, here we need to consider the probability: if worktop is mostly intended, then this approach is favorable, as intended0no determination is cheap;
		///					
		///			 or:
		///				 whether it's worktop. if it's worktop, we don't need to determine whether it's intended, if it's not, we need to;.
		///
		/// 
		///		in an extreme case, if one tier always run, and the other is dependent on the categroy of the formaer one, then the always-on one should be put first.
		///			=================================--------------------------------
		/// 
		///
		/// computational cheap:
		///		we also need to consider the resources price.
		///
		///  statistics as the feed back to adjust the code exec path?
		/// todo: research ? 

	}


}

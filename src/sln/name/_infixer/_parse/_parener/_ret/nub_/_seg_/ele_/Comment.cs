using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.dev.sln.as_.dst.name._infixer._lex;

namespace nilnul.dev.sln.as_.dst.name._infixer._parse._parener._ret.nub_._seg_.ele_
{


	

	public interface CommentI : EleI,_comment.ContentI
	{
		


	}
	public abstract class CommentA:CommentI
	{


		


	}

	/// <summary>
	/// production rule:
	///		( dweltTxt? (comment dweltTxt?)* )|^z
	/// </summary>
	public class Comment:CommentI
	{
		//left paren

		public _comment_.content_.Txt leadingDweltTxtNulable;



		public List<Tuple<CommentI,string> > tail=new List<Tuple<CommentI, string>>(
		);



		//right border
		public _lex.word_.RightParen rightBorderNulable;   //nullable



	}







}

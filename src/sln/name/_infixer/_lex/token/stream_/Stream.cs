﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_.bitExpr.compiler_._binaryTree_._lex.token.stream_
{
	public class FroStr:nilnul.lang._lex.token.stream.StrAsStream<nilnul.lang_.bitExpr.compiler_._binaryTree_._lex.TokenI>
	{
		public FroStr(IEnumerable<nilnul.lang_.bitExpr.compiler_._binaryTree_._lex.TokenI> str):base(str)
		{

		}
	}
}

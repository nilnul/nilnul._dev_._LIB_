using nilnul.dev.sln.as_.dst.name._infixer._parener_;
using nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._lex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.as_.dst.name._infixer
{
	public class Compile
	{

		public parener._dot_._parse.symbol_.Start parsed;

		public string errMsg {
			get {
				if (_err==null)
				{
					return "";
				}
				return $"undone: {_undone} \r\n\r\n err:{_err}";
			}
		}

		public bool beErr { get {
				return _err != null;
			} }

		public string _undone;
		public string _err;
		public void exe(string x) {
			exe(new nilnul.fs._address.Doc(x));
		}
		public void exe(nilnul.fs._address.Doc doc) {
			_exe(doc.ToString());
		}
		public void _exe(string x) {
			//var parener = new _parener_.Parser();
			//parener.parse(x);

			//var r = new parener._dot_.Parse(parener.content);

			//r.parse();
			//var x1=r.parsed;

			var l = new nilnul.dev.sln.as_.dst.name._infixer.parener._dot_.Lex(x);


			var words = new obj.slider_.Enumer<WordI>(l);

			parener._dot_._parse.symbol_.Start r;

			try
			{
				parsed= parener._dot_._ParseX.Parse(words);//._parse.symbol_.star;

			}
			catch (Exception excep)
			{

				_undone = string.Join("", words.tilNul());
				_err = excep.ToString();

				//throw;
			}

			//.parse();
		}
	}
}

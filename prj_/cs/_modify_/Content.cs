using nilnul.fs.address_.spear_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.dev.prj_.cs._modify_
{
	public class Content
	{
		

		private XDocument _xdoc;

		public XDocument xdoc
		{
			get { return _xdoc; }
		}

	

		private bool _changed;

		public bool changed
		{
			get { return _changed; }
			set { _changed = value; }
		}

		public void changedTouch(in bool x) {
			nilnul.bit.op_.unary_.act_._TouchedX.Touched(
				ref _changed
				,
				in x
			);
		}


		public Content(
			XDocument prj
		)
		{

			this._xdoc = prj;
		}




		public void changedTouch()
		{
			nilnul.bit.op_.unary_.act_._TouchedX.Touched(
	ref _changed
	,true
);

		}

	}
}

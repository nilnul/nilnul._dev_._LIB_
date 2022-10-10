using nilnul.fs.address_.spear_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.dev.prj_.cs
{
	public class Modify
	{

		public nilnul.fs.address_.spear_.based_.Child1 prj
		{
			get { return  nilnul.fs.address_.spear_.based_.Child1.Parse(prjAddress); }
		}

		public string prjAddress
		{
			get { return _content.path; }
			
		}

		private nilnul.xml.edit.Save _content;

		public nilnul.xml.edit.Save content
		{
			get { return _content; }
			private set { _content = value; }
		}



		public XDocument xdoc
		{
			get { return _content.xdoc; }
		}

	

		public bool changed
		{
			get { return _content.dirty; }
		}

		public void changedTouch(in bool x) {
			_content.touch(in x);
		}
		public Modify(
			string prj
		)
		{
			this._content =  xml.edit.Save.Load5file( 
				prj
			);
		}


		public Modify(
			nilnul.fs.address_.spear_.based_.Child1 prj
		):this(
			prj.ToString()
		)
		{
			
		}


		public Modify(ParentDoc prjFile)
			:
			this(
				prjFile.ToString()
			)
		{
		}

		private Modify()
		{
		}

		public Modify(XDocument xml, bool v, string prjFile)
			
		{
			this._content = nilnul.xml.edit.Save.Of(xml, v, prjFile);
		}


		public void save() {
			
				_content.save(
					
				);
			
		}
		public void touch(bool v)
		{
				_content.touch(v);
		
		}

		public void touch()
		{
			_content.touch();

		}

		public static Modify _AssumeValid(string prjFile, XDocument xml)
		{
			return new Modify(

			 xml ,false, prjFile);
			
		}
	}
}

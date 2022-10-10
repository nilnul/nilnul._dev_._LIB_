using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev._design.sys_
{
	/// <summary>
	/// for example:
	///		computation unit and storage is designed to using NAND gate only, such that design and manufacture is easy and robust(some bad blocks can be ignored), allowing more compact layout.
	///			but we need to make sure each NAND gate can be controlled independently, otherwise it might be rendered little use as one NAND gate is dependent on another, resulting less states, hence less storage/computation power.
	/// </summary>
	class Homogenous
	{
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj.sub_
{
    /// <summary>
    /// we don't allow subprj inside a prj, to reduce the complexity.
    /// But each dir of a prj can be regarded a module.
    /// And a module can contain a submodule, which is the descendant of a module.
    /// </summary>
    internal class IModule
    {
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV.nomina.op_
{
    /// <summary>
    /// depth first. This helps us taxonomize our concepts.
    /// </summary>
    /// <remarks>
    /// the infoPath would become long. But we can at some stage( in another module) move a concept out, and restart it at a lower tier.
    /// eg:
    ///     <see cref="nilnul.fs._address._route.division_._div._dir.IDnt"/>
    ///     can be refooted as: <see cref="nilnul.fs._address.Dnt"/>
    ///     ;;<see cref="IPromote"/>
    ///     ;; often this is done into another module or submodule.
    /// </remarks>
    internal class IExtend
    {
    }
}

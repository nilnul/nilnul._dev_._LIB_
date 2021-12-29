using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Linq.Expressions;
using System.Collections;
using System;

namespace nilnul.dev.srcs_.cfged
{

    public static class _DefaultX
    {


        public static IEnumerable<string> Defaulted
        {
            get
            {

                if (nilnul.obj.str_.seq.be_._NoneX.None(_CfgedX.Txts))
                {
                    //fall back to srcDirS
                    return Properties.Settings.Default.srcDirS.Cast<string>().Select(
                        d => System.IO.Path.Combine(
                            nilnul.dev.src_._parented._parent._CfgX.Address()
                            ,
                            d
                        )
                    );
                }
                return _CfgedX.Txts;
            }
        }


        public static Srcs3 GetSrcs() => new Srcs3(
            nilnul.fs.address_.shields_.disjoint_._AddressesX.ToDisjoint(Defaulted)
        );

        [Obsolete("", true)]

        public static Srcs3 Srcs;

        [Obsolete("", true)]
        static public void Refresh()
        {
            _DefaultX.Srcs = GetSrcs();
        }

        static _DefaultX()
        {
            //Refresh();
        }





    }
}

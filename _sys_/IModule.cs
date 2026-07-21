using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev._sys_
{
    ///Module（模块）机制。in asp.net, IHttpModule并不直接生成响应内容，而是在请求抵达Handler之前或离开Handler之后，进行“过滤”或“安检”。比如身份验证模块（FormsAuthentication）会在请求抵达你的Default.aspx之前，先检查用户有没有登录票证；日志模块会在请求结束后记录本次访问的耗时。所有的Module构成了一个“管道（Pipeline）”，请求像水流一样依次经过每个Module的阀门。这种AOP（面向切面编程） 的思想，使得我们能够以非入侵的方式为系统添加横切关注点（Cross-cutting concerns），这是代码整洁之道的重要体现。
    ///
    /// <summary>
    /// 
    /// </summary>
    /// eg:
    ///     
    internal class IModule
    {
    }
}

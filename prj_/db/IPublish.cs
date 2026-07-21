using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj_.db
{
    /// <summary>
    /// 
    /// syntax check, schema compare, pac2server for execution.
    /// </summary>
    ///  架构对比（Schema Compare） 机制，自动检测工程定义与目标数据库之间的差异，并生成仅包含变更部分的增量部署脚本（ALTER语句），最终由VS发送至服务器执行。发布过程默认采用增量更新而非删表重建，避免了数据丢失的风险。
    internal class IPublish
    {
    }
}

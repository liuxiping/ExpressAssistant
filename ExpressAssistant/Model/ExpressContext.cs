using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressAssistant.Model
{
    /// <summary>
    /// 快递相关信息
    /// </summary>
    public class ExpressContext
    {

        /// <summary>
        /// 序号
        /// </summary>
        public string Num { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        public string SiteName { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        public string ExpressNum { get; set; }
    }
}

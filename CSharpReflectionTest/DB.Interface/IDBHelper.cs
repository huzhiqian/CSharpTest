using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DB.Interface
{
    /// <summary>
    /// 数据库接口
    /// </summary>
   public interface IDBHelper
    {

        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <returns></returns>
         bool LinkDB();

        /// <summary>
        /// 查询数据库
        /// </summary>
        void Query();
    }
}

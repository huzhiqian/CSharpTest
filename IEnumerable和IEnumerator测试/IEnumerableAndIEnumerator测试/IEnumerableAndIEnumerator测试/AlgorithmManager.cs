using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：AlgorithmManager
//命名空间：IEnumerableAndIEnumerator测试
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/6/14 19:02:39
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace IEnumerableAndIEnumerator测试
{
    /// <summary>
    /// 算法管理器
    /// </summary>
  public  class AlgorithmManager:IEnumerable
    {
        private Algorithm[] algorithms = new Algorithm[10];
        private int current = 0;
        #region 构造函数

        public AlgorithmManager()
        {
            
        }

   
           

        public void Add(Algorithm alg)
        {
            algorithms[current] = alg;
            current++;
        }

        public IEnumerator GetEnumerator()
        {
            return new AlgorithmEnumerator(algorithms);
        }

        #endregion


        #region 属性

        /// <summary>
        /// 创建索引器
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public Algorithm this[int idx]
        {
            get { return GetItem(idx); }
            set {
                if (idx >= 0 && idx < current)
                {
                    algorithms[idx] = value;
                }
                else
                    throw new ArgumentOutOfRangeException("索引超出范围");
            }
        }

        #endregion

        #region 公共方法

        public Algorithm GetItem(int index)
        {
            if (index >= 0 && index < current)
            {
                return algorithms[index];
            }
            else
                throw new ArgumentOutOfRangeException("索引超出范围");
        }

        #endregion

        #region 私有方法



        #endregion

        #region 委托



        #endregion

        #region 事件



        #endregion
    }
}

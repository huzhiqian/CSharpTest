using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：AlgorithmEnumerator
//命名空间：IEnumerableAndIEnumerator测试
//CLR版本：4.0.30319.42000
//内容：
//功能：迭代器
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/6/14 19:12:16
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace IEnumerableAndIEnumerator测试
{
    //迭代器类
   public class AlgorithmEnumerator:IEnumerator
    {
        private Algorithm[] algorithms;
        private int current = -1;
        #region 构造函数

        public AlgorithmEnumerator(Algorithm[] algs)
        {
            this.algorithms = algs;
            current = -1;//初始化迭代器指向。因为迭代器会先调用MoveNext
        }

        public object Current
        {
            get { return CurrentAlgorithm(); }
        }



        public bool MoveNext()
        {
            current++;
            if (current < algorithms.Length && algorithms[current] != null)
                return true;
            return false;
        }

        public void Reset()
        {
            current = -1; 
        }

        #endregion


        #region 属性



        #endregion

        #region 公共方法



        #endregion

        #region 私有方法

        private object CurrentAlgorithm()
        {
            if (current < 0 || current >= algorithms.Length)
            {
                return null;
            }
            else
            {
                return algorithms[current];
            }
        }

        #endregion

        #region 委托



        #endregion

        #region 事件



        #endregion
    }
}

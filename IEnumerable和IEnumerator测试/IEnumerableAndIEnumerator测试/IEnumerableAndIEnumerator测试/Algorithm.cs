using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：Algorithm
//命名空间：IEnumerableAndIEnumerator测试
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/6/12 22:04:22
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace IEnumerableAndIEnumerator测试
{
   public class Algorithm
    {
        private string name = string.Empty;
        private int id = 0;

        #region 构造函数

        public Algorithm(string _name,int _id)
        {
            name = _name;
            id = _id;
        }

        #endregion


        #region 属性

        public string Name {
            get { return name; }
            set {
                name = value;
            }
        }

        public int ID {
            get { return id; }
            set {
                id= value;
            }
        }
        #endregion

        #region 公共方法



        #endregion

        #region 私有方法



        #endregion

        #region 委托



        #endregion

        #region 事件



        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPatternTest
{
    /// <summary>
    /// 保存图片接口
    /// </summary>
   public interface ISaveImage
    {

        void Save(string path);

    }
}

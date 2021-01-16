using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPatternTest
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                //最基础的保存图片功能
                ISaveImage saveImage = new SaveImage();
                saveImage.Save("1233");

                Console.WriteLine("******************************");
                //现在客户需要将图片保存到数据库中
                SaveImageToDB imageToDB = new SaveImageToDB(saveImage);
                imageToDB.Save("123");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw ex;
            }
            Console.ReadLine();
        }
    }
}

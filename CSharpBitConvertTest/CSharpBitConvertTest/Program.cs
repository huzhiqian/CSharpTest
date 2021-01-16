using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBitConvertTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int ivalue = 17463114;
            double dValue = 55.65;

            try
            {
                byte[] convertBytes = BitConverter.GetBytes(ivalue);
                byte[] cDoubleByte = BitConverter.GetBytes(dValue);

                Console.WriteLine("****************转化成字符串******************");
                string istr = BitConverter.ToString(convertBytes,0,convertBytes.Length);
                Console.WriteLine($"整型_字符数据：{istr}");

                string dstr = BitConverter.ToString(cDoubleByte,0, cDoubleByte.Length);
                Console.WriteLine($"浮点_字符数据：{dstr}");

                Console.WriteLine("***************还原数据*********************");

                Console.WriteLine($"整型还原数据：{BitConverter.ToInt32(convertBytes,0)}");
                Console.WriteLine($"浮点还原数据：{BitConverter.ToDouble(cDoubleByte,0)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }
    }
}

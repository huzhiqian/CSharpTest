using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/// <summary>
/// 通过反射获取类中的所有属性的值
/// </summary>
namespace RefectionGetPropertiesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CTest testObj = new CTest();

            try
            {
                testObj.SetAllPropertiesValue(testObj);

                testObj.ResetAllPropertiesValue(testObj);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }
    }
}

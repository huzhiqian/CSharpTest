using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using TestDll;
using TestDllInterface;


namespace GetAssemblyFromClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TestDll.Class1 class1 = new TestDll.Class1();
                IClass myIClass = class1 as IClass; //转换成接口
                Type t = myIClass.GetType();
                Assembly assembly = Assembly.GetAssembly(t);
                Console.WriteLine(assembly.Location) ;//获取Dll文件位置
                Type[] types= assembly.GetExportedTypes();
                Type class2Type = null;
                foreach (var item in types)
                {
                    Console.WriteLine(item.Name);
                    if (item.Name == "Class2") {//获取Class2类型实例
                        class2Type = item;
                    }
                }
                if (class2Type != null) {
                    object obj = assembly.CreateInstance(class2Type.FullName);//创建Class2对象
                    if (obj != null)
                    {
                        //Console.WriteLine("123");
                        //调用Class2中公共方法
                       MethodInfo[] methodInfos= class2Type.GetMethods();
                        foreach (var item in methodInfos)
                        {
                            if (item.Name == "Action") {
                                item.Invoke(obj, null);
                            }
                        }
                    }
                }
               

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString()) ;
            }
            Console.ReadLine();
        }
    }
}

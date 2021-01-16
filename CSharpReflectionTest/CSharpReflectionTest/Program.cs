using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DB.Interface;
using DB.MySqlServer;
using System.Reflection;



/// <summary>
/// C#反射测试程序
/// </summary>
namespace CSharpReflectionTest
{
    /// <summary>
    /// 反射，是.net framework提供问metadata(元数据)的一个类库，可以获取dll文件中
    ///     的信息并使用它们
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                #region Common
                {
                    Console.WriteLine("****************Common_Function***************");
                    IDBHelper dBHelper = new DB.MySqlServer.SqlServerHelper();
                    dBHelper.LinkDB();
                    dBHelper.Query();
                }


                #endregion


                #region Reflection
                {
                    Console.WriteLine("*****************Refection_Function********************");
                    Assembly assembly = Assembly.Load("DB.MySqlServer");//从当前路径下加载，不带dll后缀
                    //Assembly assembly2 = Assembly.LoadFile(
                    //    @"C:\Users\Administrator\Desktop\CSharpReflectionTest\" +
                    //    @"DB.MySqlServer\bin\Debug\DB.MySqlServer.dll");    //从指定文件路径加载dll文件
                    //Assembly assembly3 = Assembly.LoadFrom("DB.MySqlServer.dll");//从当前路径下加载带dll后缀


                    /****************************查看反射信息********************************/
                    //获取模块名称
                    foreach (var item in assembly.GetModules())
                    {
                        Console.WriteLine($"模块名称：{item.Name}");
                    }

                    //获取类型名称
                    foreach (var item in assembly.GetTypes())
                    {
                        Console.WriteLine($"类型名称:{item.Name}");
                    }

                    foreach (var item in assembly.GetCustomAttributes(true))
                    {
                        Console.WriteLine($"特性：{item.ToString()}");
                    }
                    /**************************************************************************/


                    //使用反射创建对象并执行其中方法
                    Type SqlServerType = assembly.GetType("DB.MySqlServer.SqlServerHelper");//获取类型
                    object mySqlServerHelper = Activator.CreateInstance(SqlServerType);//创建对象
                    IDBHelper myDBHelper = mySqlServerHelper as IDBHelper;//获取运行时类型
                    myDBHelper.LinkDB();
                    myDBHelper.Query();

                }

                #endregion

                #region SimpleFactory
                {
                    Console.WriteLine("****************SimpleFactory_Function******************");
                    SimpleFactory simpleFactory = new SimpleFactory();
                    IDBHelper dBHelper = simpleFactory.CreatcInstance();
                    dBHelper.LinkDB();
                    dBHelper.Query();
                }

                #endregion

                #region 多构造函数、破坏单列、创建泛型
                {
                    Console.WriteLine("********************多构造函数、破坏单列、创建泛型*********************");
                    Assembly assembly = Assembly.Load("DB.MySqlServer");
                    Type type = assembly.GetType("DB.MySqlServer.SqlServerHelper");
                    foreach (var item in type.GetConstructors())
                    {
                        Console.WriteLine($"构造函数名称：{item.Name}");
                    }
                    object objTest = Activator.CreateInstance(type);//调用无参构造函数
                    object objTest2 = Activator.CreateInstance(type, 123);//调用int型构造函数
                    object objTest3 = Activator.CreateInstance(type, "aaaa");//调用string型构造函数


                    object objTest4 = Activator.CreateInstance(type, new object[] { 8558 });  //调用int型构造函数
                    object objTest5 = Activator.CreateInstance(type, new object[] { "bbbb" });//调用string型构造函数

                    Type singleType = assembly.GetType("DB.MySqlServer.Singleton");

                    //破坏单列，多次构造私有函数
                    object oSingleton1 = Activator.CreateInstance(singleType, true);
                    object oSingleton2 = Activator.CreateInstance(singleType, true);
                    object oSingleton3 = Activator.CreateInstance(singleType, true);
                    object oSingleton4 = Activator.CreateInstance(singleType, true);

                    //构造泛型类
                    Type genericType = assembly.GetType("DB.MySqlServer.GenericTest`3");    //`：占位符，3：表示有三个泛型参数
                    Type typeNew = genericType.MakeGenericType(typeof(int), typeof(string), typeof(double));//给定具体的泛型类型
                    //创建泛型类对象
                    object oGeneric = Activator.CreateInstance(typeNew);

                    DB.MySqlServer.GenericTest<int, string, double> genericTest = oGeneric as GenericTest<int, string, double>;
                    genericTest.Show(1, "123", 12.01);

                }

                #endregion

                #region 反射调用方法、静态方法、重载方法

                {
                    Console.WriteLine("*****************反射调用方法、静态方法、重载方法************************");
                    Assembly assembly = Assembly.Load("DB.MySqlServer");
                    Type type = assembly.GetType("DB.MySqlServer.SqlServerHelper");
                    object obj = Activator.CreateInstance(type);
                    //枚举所有方法
                    foreach (var item in type.GetMembers())
                    {
                        Console.WriteLine($"方法名称：{item.Name}");
                    }

                    //调用实例方法方法
                    MethodInfo methodInfo = type.GetMethod("Query");
                    methodInfo.Invoke(obj, null);

                    //调用静态方法
                    MethodInfo staticMethod = type.GetMethod("Staticmethod");
                    staticMethod.Invoke(null, null);

                    //调用重载方法
                    Assembly assm = Assembly.Load("DB.MySqlServer");
                    Type myType = assm.GetType("DB.MySqlServer.GenericTest`3");
                    Type myTypeNew = myType.MakeGenericType(typeof(string), typeof(string), typeof(float));
                    object GenericObj = Activator.CreateInstance(myTypeNew);


                    MethodInfo methodInfo_Test = myTypeNew.GetMethod("Test", new Type[] { });
                    methodInfo_Test.Invoke(GenericObj, new object[] { });

                    MethodInfo methodInfo_Test1 = myTypeNew.GetMethod("Test", new Type[] { typeof(int) });
                    methodInfo_Test1.Invoke(GenericObj, new object[] { 123 });

                    MethodInfo methodInfo_Test2 = myTypeNew.GetMethod("Test", new Type[] { typeof(string) });
                    methodInfo_Test2.Invoke(GenericObj, new object[] { "stringtype" });

                    MethodInfo methodInfo_Test3 = myTypeNew.GetMethod("Test", new Type[] { typeof(double) });
                    methodInfo_Test3.Invoke(GenericObj, new object[] { 12.01 });
                }


                #endregion

                #region 反射调用泛型方法
                {
                    Console.WriteLine("*********************反射调用泛型方法********************");
                    Assembly assembly = Assembly.Load("DB.MySqlServer");            //加载Dll文件
                    Type type = assembly.GetType("DB.MySqlServer.GenericTest`3");   //获取类型
                    Type typeNew = type.MakeGenericType(typeof(int), typeof(string), typeof(double)); //获取泛型类型
                    //创建对象
                    object genericObj = Activator.CreateInstance(typeNew);

                    //获取泛型方法信息
                    MethodInfo methodInfo = typeNew.GetMethod("Show2");
                    //定义泛型方法
                    MethodInfo methodInfoNew = methodInfo.MakeGenericMethod(typeof(string), typeof(double), typeof(int));
                    //调用泛型方法
                    methodInfoNew.Invoke(genericObj, new object[] { "test", 12.2, 5 });


                }
                #endregion

                #region 反射操作属性字段

                {
                    Console.WriteLine("*************************反射操作字段和属性****************************");
                    Assembly assembly = Assembly.Load("DB.MySqlServer");
                    Type type = assembly.GetType("DB.MySqlServer.Model");
                    //创建实例对象
                    object oModel = Activator.CreateInstance(type);

                    //打印公共字段
                    foreach (var item in type.GetFields())
                    {
                        Console.WriteLine($"字段名称：{item.Name},字段值：{item.GetValue(oModel)}");
                    }

                    //打印公共属性
                    foreach (var item in type.GetProperties())
                    {
                        Console.WriteLine($"属性名称：{item.Name},属性值：{item.GetValue(oModel, null)}");
                    }

                    //操作字段和属性
                    Console.WriteLine("//////////////操作字段和属性//////////////");
                    foreach (var item in type.GetFields())
                    {
                        switch (item.Name)
                        {
                            case "iTestValue":
                                item.SetValue(oModel, 333);
                                break;
                            case "sTestValue":
                                item.SetValue(oModel, "2333");
                                break;
                            case "dTestValue":
                                item.SetValue(oModel, 332.1);
                                break;
                            default:
                                break;
                        }
                    }

                    foreach (var item in type.GetProperties())
                    {
                        switch (item.Name)
                        {
                            case "ID":
                                item.SetValue(oModel, 2231, null);
                                break;
                            case "Name":
                                item.SetValue(oModel, "胡志乾", null);
                                break;
                            default:
                                break;
                        }
                    }

                    //打印公共字段
                    foreach (var item in type.GetFields())
                    {
                        Console.WriteLine($"字段名称：{item.Name},字段值：{item.GetValue(oModel)}");
                    }

                    //打印公共属性
                    foreach (var item in type.GetProperties())
                    {
                        Console.WriteLine($"属性名称：{item.Name},属性值：{item.GetValue(oModel, null)}");
                    }

                }


                #endregion

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
            Console.ReadLine();
        }
    }
}

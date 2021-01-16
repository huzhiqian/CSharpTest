using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Tuple<int, int, int, string>> dataList = new List<Tuple<int, int, int, string>>();

            dataList.Add(new Tuple<int, int, int, string>(8, 1, 3, "h"));
            dataList.Add(new Tuple<int, int, int, string>(11, 2, 2, "k"));
            dataList.Add(new Tuple<int, int, int, string>(1, 0, 0, "a"));
            dataList.Add(new Tuple<int, int, int, string>(5, 1, 0, "e"));
            dataList.Add(new Tuple<int, int, int, string>(16, 3, 3, "p"));
            dataList.Add(new Tuple<int, int, int, string>(2, 0, 1, "b"));
            dataList.Add(new Tuple<int, int, int, string>(13, 3, 0, "m"));
            dataList.Add(new Tuple<int, int, int, string>(4, 0, 3, "d"));
            dataList.Add(new Tuple<int, int, int, string>(9, 2, 0, "i"));
            dataList.Add(new Tuple<int, int, int, string>(3, 0, 2, "c"));
            dataList.Add(new Tuple<int, int, int, string>(6, 1, 1, "f"));
            dataList.Add(new Tuple<int, int, int, string>(7, 1, 2, "g"));
            dataList.Add(new Tuple<int, int, int, string>(14, 3, 1, "n"));
            dataList.Add(new Tuple<int, int, int, string>(12, 2, 3, "l"));
            dataList.Add(new Tuple<int, int, int, string>(15, 3, 2, "o"));
            dataList.Add(new Tuple<int, int, int, string>(10, 2, 1, "j"));

            try
            {
                //排序
                dataList.Sort((A, B) =>
                {
                    return -B.Item3.CompareTo(A.Item3);
                });
                dataList.Sort((A, B) =>
                {
                   return -B.Item2.CompareTo(A.Item2);
                });


                foreach (var item in dataList)
                {
                    Console.WriteLine($"ID：{item.Item1},   Row:{item.Item2},   Col:{item.Item3},   Value:{item.Item4}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.ReadLine();

        }
    }
}
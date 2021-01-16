using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableAndIEnumerator测试
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AlgorithmManager algManager = new AlgorithmManager();
                //
                Algorithm alg1 = new Algorithm("Algorithm1",1);
                Algorithm alg2 = new Algorithm("Algorithm2", 2);
                Algorithm alg3 = new Algorithm("Algorithm3", 3);
                Algorithm alg4 = new Algorithm("Algorithm4", 4);

                algManager.Add(alg1);
                algManager.Add(alg2);
                algManager.Add(alg3);
                algManager.Add(alg4);

                foreach (Algorithm item in algManager)
                {
                    Console.WriteLine($"AlgorithmName:{item.Name},AlgorithmID:{item.ID}.");
                }

                //在没有创建索引器之前，下面这句话是会报错的，无法直接像list那样索引内部算法对象
                //Console.WriteLine($"{algManager[0] }");

                Console.WriteLine(algManager[0].Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }
    }
}

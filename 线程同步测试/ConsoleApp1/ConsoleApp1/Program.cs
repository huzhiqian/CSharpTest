using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static System.Threading.Mutex myMutex = new System.Threading.Mutex(false);
        static Action<string> method;
        static void Main(string[] args)
        {
            try
            {
                int val = 99;
                for (int i = 0; i < 99; i++)
                {
                
                    myMutex.WaitOne(-1,true);
                    val--;
                    System.Threading.Tasks.Task task = new System.Threading.Tasks.Task((paraObj)=> 
                    {
                        object[] para= (object[])paraObj;
                        Console.WriteLine($"{para[0]},{para[1]}");
                    } ,new object[] { i,val});
                    task.Start();
                    myMutex.ReleaseMutex();
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

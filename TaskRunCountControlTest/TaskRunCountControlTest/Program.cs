using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Schedulers;
using System.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.IO;
using System.Security.AccessControl;

namespace TaskRunCountControlTest
{
    class Program
    {

        static List<int> numberList = Enumerable.Range(5, 10).ToList(); //生成整数序列

       static Bitmap bitmap = new Bitmap(@"C:\Users\Administrator\Desktop\Test.jpg");
        static void Main(string[] args)
        {

            try
            {
                // LimitTaskDemo();
                for (int i = 0; i < 100; i++)
                {
                    Stopwatch sw = new Stopwatch();
                    sw.Restart();
                    string filepath_1 = string.Format(@"C:\Users\Administrator\Desktop\Image\{0}.bmp",i+"_1");
                    bitmap.Save(filepath_1, ImageFormat.Bmp);
                    sw.Stop();
                    Console.WriteLine("Time_Save:{0}",sw.ElapsedMilliseconds.ToString());
                    sw.Restart();
                    int bufferSize = bitmap.Width * bitmap.Height;
                    string filepath_2= string.Format(@"C:\Users\Administrator\Desktop\Image\{0}.bmp", i + "_2");
                    using (FileStream fs = new FileStream(filepath_2, FileMode.Create, FileSystemRights.FullControl, FileShare.ReadWrite, bufferSize, FileOptions.None))
                    {
                        bitmap.Save(fs, ImageFormat.Bmp);
                        sw.Stop();
                        Console.WriteLine("Time_FS_Save:{0}", sw.ElapsedMilliseconds.ToString());
                    }
                    //FileStream fs = new FileStream(filepath_1, FileMode.Create, FileSystemRights.FullControl, FileShare.ReadWrite, bufferSize, FileOptions.None);
                   
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw ex;
            }
            Console.ReadLine();
        }

        static void LimitTaskDemo()
        {
            var scheduler = new LimitedConcurrencyLevelTaskScheduler(5);
           
            for (int i = 0; i < numberList.Count; i++)
            {
                var number = numberList[i];
                DoTask(number, scheduler);
            }
            Console.WriteLine("Main Finish!");
        }

        static void DoTask(int number, TaskScheduler taskScheduler)
        {
            Action<object> act = obj =>
             {
                 var sleepTime = Rand(5) + 1;
                 //Thread.Sleep(sleepTime * 1000);
                 Thread.Sleep(5000);
                 Console.WriteLine($"Task id:{Task.CurrentId},Time:{DateTime.Now}," +
                     $"dealNumber:{obj},SleepTime{sleepTime}");

                 if (Rand() == 0)   //模拟Expection
                 {
                     Console.WriteLine($"Expection Number {obj}");
                 }
             };
            Task.Factory.StartNew(act, number, CancellationToken.None, TaskCreationOptions.None,
                taskScheduler).ContinueWith((t, obj) =>
                {
                    //继续执行任务
                    if (t.Status == TaskStatus.RanToCompletion)
                    {
                        //DoTask(number, taskScheduler);
                        //Console.WriteLine($"Value:{obj}");
                    }
                }, number);
         

        }

        private static int Rand(int maxNumber = 5)
        {
            return Math.Abs(Guid.NewGuid().GetHashCode()) % maxNumber;
        }
    }
}

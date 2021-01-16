using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CopySpeedTest
{
    class Program
    {
        static Stopwatch sw1 = new Stopwatch();
        static Stopwatch sw2 = new Stopwatch();
        static void Main(string[] args)
        {
            
            Bitmap srcImage = new Bitmap("test.bmp");
            long mode1_time = 0;
            long mode2_time = 0;
            const int copyCount = 500;
            try
            {
                for (int j = 0; j < copyCount; j++)
                {
                    long t1, t2;
                    t1= CopyMode1(srcImage);
                    t2= CopyMode2(srcImage);
                    mode1_time += t1;
                    mode2_time += t2;
                    Console.WriteLine($"{t1} - {t2}");
                }
                Console.WriteLine($"Mode2拷贝耗时：{mode2_time / copyCount} ms");
                Console.WriteLine($"Mode1拷贝耗时：{mode1_time / copyCount} ms");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }

        static long CopyMode1(Bitmap srcImage)
        {
            //int t0 = System.Environment.TickCount;
            sw1.Restart();

            var rect = new Rectangle(0, 0, srcImage.Width, srcImage.Height);
            var bmpData = srcImage.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadOnly,
                            srcImage.PixelFormat);
            int step = bmpData.Stride;  //获取扫描宽度
            int rowBytes = srcImage.Width * Image.GetPixelFormatSize(srcImage.PixelFormat) / 8;
            int imgBytesCount = rowBytes * srcImage.Height;
            byte[] imgBytes = new byte[imgBytesCount];

            IntPtr iptr = bmpData.Scan0;    //获取图像字节数据首地址
            for (int i = 0; i < srcImage.Height; i++)
            {
                System.Runtime.InteropServices.Marshal.Copy(iptr, imgBytes, i * rowBytes ,rowBytes);
                iptr += step;
            }

            srcImage.UnlockBits(bmpData);
            //t0 = System.Environment.TickCount - t0;
            sw1.Stop();
            //Console.WriteLine($"Mode1拷贝耗时：{t0} ms");
            return sw1.ElapsedMilliseconds;
        }

        static long CopyMode2(Bitmap srcImage)
        {
            sw2.Restart();
            var rect = new Rectangle(0, 0, srcImage.Width, srcImage.Height);
            var bmpData = srcImage.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadOnly,
                            srcImage.PixelFormat);
            //int step = bmpData.Stride;  //获取扫描宽度
            int rowBytes = srcImage.Width * Image.GetPixelFormatSize(srcImage.PixelFormat) / 8;
            int imgBytesCount = rowBytes * srcImage.Height;
            byte[] imgBytes = new byte[imgBytesCount];

            IntPtr iptr = bmpData.Scan0;    //获取图像字节数据首地址

            System.Runtime.InteropServices.Marshal.Copy(iptr, imgBytes, 0, imgBytes.Length);

            srcImage.UnlockBits(bmpData);
            //t0 = System.Environment.TickCount - t0;
            sw2.Stop();
            //Console.WriteLine($"Mode2拷贝耗时：{t0} ms");
            return sw2.ElapsedMilliseconds;
        }
    }
}

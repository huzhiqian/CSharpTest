using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;

namespace GetNetworkInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("**************获取本地计算机网卡信息**************");
                //获取或有网口对象
                NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
                Console.WriteLine($"当前计算进上共有{adapters.Length}个网口设备");
                int index = 0;
                foreach (var item in adapters)
                {
                    index++;
                    Console.WriteLine($"-----------第{index}个设备------------");

                    Console.WriteLine($"网口名称：{item.Name}");
                    Console.WriteLine($"网口ID：{item.Id}");
                    Console.WriteLine($"网口型号：{item.NetworkInterfaceType}");
                    Console.WriteLine($"网口速度：{item.Speed}");
                    Console.WriteLine($"网络连接状态:{item.OperationalStatus}");
                    Console.WriteLine($"MAC地址：{item.GetPhysicalAddress()}");
           

                    //获取IpInterfaceProperties
                    IPInterfaceProperties iPInterfaceProperties = item.GetIPProperties();

                    IPAddressCollection iPAddresses = iPInterfaceProperties.DnsAddresses;
                    if (iPAddresses.Count > 0)
                    {
                        foreach (IPAddress dns in iPAddresses)
                        {
                            Console.WriteLine($"DNS服务器ip地址：{dns}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"DNS服务器ip地址");
                    }


                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw ex;
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}

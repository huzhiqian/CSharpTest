using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace 加密与解密测试
{
    class Program
    {
      static  string encryptKey = "chuangchi";//加密与解密秘钥
       static string passward = "hzq033060853";   //密码
        static void Main(string[] args)
        {

            try
            {
                var encryptString = Encrypt(passward,encryptKey);
                Console.WriteLine($"加密后的数据：{encryptString}");
                var decryptString = Decrypt(encryptString,encryptKey);
                Console.WriteLine($"解密后的数据：{decryptString}");
             }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }

        /// <summary>
        /// 通过DES加密数据
        /// </summary>
        /// <param name="targetValue">需要加密的目标数据</param>
        /// <param name="key">公共秘钥</param>
        /// <returns>返回加密好的数据</returns>
        static string Encrypt(string targetValue,string key)
        {
            if (string.IsNullOrEmpty(targetValue))
            {
                return string.Empty;
            }
            var des = new DESCryptoServiceProvider();//实例化加解密对象
            byte[] inputByteArray = Encoding.Default.GetBytes(targetValue);
            //设置DES初始化向量
            des.IV = Encoding.Default.GetBytes(key.Substring(0,8));
            //设置DES秘钥
            des.Key = Encoding.Default.GetBytes(key.Substring(0,8));
            //创建内存流
            var ms = new MemoryStream();
            //使用内存流创建加密流
            CryptoStream encStream = new CryptoStream(ms,des.CreateEncryptor(),CryptoStreamMode.Write);
            encStream.Write(inputByteArray,0,inputByteArray.Length);
            encStream.FlushFinalBlock();

            var resultString = new StringBuilder();
            foreach (var item in ms.ToArray())
            {
                resultString.AppendFormat("{0:X2}",item);
            }

            encStream.Close();
            ms.Close();
            des.Dispose();
            return resultString.ToString();
        }

        /// <summary>
        /// 通过DES机密数据
        /// </summary>
        /// <param name="targetVal">需要解密的数据</param>
        /// <param name="key">公共秘钥</param>
        /// <returns>返回解密后的数据</returns>
        static string Decrypt(string targetVal,string key)
        {
            if (string.IsNullOrEmpty(targetVal))
            {
                return string.Empty;
            }

            var des = new DESCryptoServiceProvider();//实例化加解密对象
            int len = targetVal.Length / 2;
            byte[] inputByteArray = new byte[len];
            for (int i = 0; i < len; i++)
            {
                byte val = Convert.ToByte(targetVal.Substring(i*2,2),16);
                inputByteArray[i] = val;
            }

            //byte[] inputByteArray = Encoding.Default.GetBytes(targetVal);
            //设置DES初始化向量
            des.IV = Encoding.Default.GetBytes(key.Substring(0, 8));
            //设置DES秘钥
            des.Key = Encoding.Default.GetBytes(key.Substring(0, 8));
            //创建内存流
            var ms = new MemoryStream();
            //使用内存流创建加密流
            CryptoStream encStream = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            encStream.Write(inputByteArray,0,inputByteArray.Length);
            encStream.FlushFinalBlock();
            string resultString = Encoding.Default.GetString(ms.ToArray()); ;

            //close
            encStream.Close();
            ms.Close();
            des.Dispose();
            return resultString;
        }
    }
}
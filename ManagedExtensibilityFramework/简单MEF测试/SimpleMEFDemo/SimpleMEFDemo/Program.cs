using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SimpleMEFDemo
{
    class Program
    {
        [Import]
        public IWorkService work { get; set; }

        static void Main(string[] args)
        {
            Program pro = new Program();
            pro.Compose();
            if (pro.work != null)
            {
                pro.work.WorkName = "工程师";
                Console.WriteLine(pro.work.GetWorkName());

                //
                pro.work.DoWork();
            }
            Console.ReadLine();
        }

        private void Compose()
        {
            // MEF提供三种方式发现部件
            // 1:AssemblyCatalog 在当前程序集发现部件。
            // 2:DirectoryCatalog 在指定的目录发现部件。
            // 3:DeploymentCatalog 在指定的XAP文件中发现部件（用于silverlight）
            //
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly()); //创建目录
            CompositionContainer container = new CompositionContainer(catalog); //创建容器
            container.ComposeParts(this);         //组建

        }
    }
}

# <center>***C# 测试程序***</center> 
---


`1: 2018-11-17 添加自定义序列化测试Demo,位置：%ROOT%\C#练习程序\序列化\CustomSerializationTest`  

`2: 2018-12-23 添加反序列化与反序列化Demo, 主要测试反序列化过程中各个对象反序列化过程，详见测试文件夹中ReadMe.md文件 位置：%ROOT%\C#练习程序\序列化\I:\C#练习程序\序列化\SerializeTest2`  

`3:2019-1-9 添加了接口测试Demo,主要验证接口使用方法。位置：%ROOT%\C#练习程序\接口测试`  

`4:2019-2-21 添加反射获取和修改类中的属性测试Demo。位置：%ROOT%\C#练习程序\RefectionGetPropertiesTest`  

`5:2019-3-28 添加环形队列测试Demo。位置：%ROOT%\C#练习程序\环形队列`  
  
`6:2019-4-30 添加TreeView控件测试代码，为后面讲XML文件转换成TreeView形式做准备。位置：%ROOT%\C#练习程序\TreeViewTest`  

`7:2019-5-9 添加XML文件操作测试类。 位置：%Root%\C#练习程序\XML\XMLFileOperatorTest`

`8:2019-5-10 添加MEF(托管可扩展框架)测试程序。位置：%Root%\C#练习程序\ManagedExtensibilityFramework\简单MEF测试`   

`9:2019-5-16 添加MEF测试Demo,主要测试在类中动态加载DLL文件，详见ManagedExtensibilityFramework文件夹中的ReadMe文件。 位置：%Root%\C#练习程序\ManagedExtensibilityFramework\MEFTestDemo`    

`10:2019-6-21 添加Log4Net测试程序，开始测试并学习Log4Net日志系统怎么用，并将在以后的C#程序中注入Log4Net日志系统。位置：%Root%\C#练习程序\Log4Net测试程序`  

`11:2019-7-3 添加AppConfig测试程序，深入研究App.Config文件的特性，为以后程序的可配置做准备。在以前的项目中app.config文件中只能用appSettings和ConectionSettings两个节，我们想在app.config中赋予更多的自定义节，使app.config文件更加灵活。目前只知道ConfigurationSection可以实现自定义的节，具体怎么实现接下将具体测试。位置：%Root%\C#练习程序\AppConfig测试程序`   

`12：2019-7-20 添加ConfigTest测试，这个测试主要目的是将软件的配置和参数都从原来的ini文件中移到XML文件中，在XML文件中可以分层，结构清晰相对于ini文件要好，但是XML文件在多个线程同时操作上可能存在问题，所以需要些这么一个测试代码测试一下。位置：%Root%\C#练习程序\ConbfigTest`

`13: 2019-9-8 添加排序测试，在list中的对象可以直接调用sort方法排序，位置：%Root%\行列排序测试\ConsoleApp1`

`14:2019-9-29 添加重绘Button控件的测试，将button绘制成圆形。位置：%Root%\RoundButtonTestProj`

`15 2020-2-13 添加Labda表达式测试，在看到List.ToDictionary():[  public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector);]突然有点不太理解了，所以重新复习了一下`

`16 2020-2-20 添加ConfigerTest，主要测试ConmmonModules中ConfigerHelper类的功能`

`17 2020-2-25 添加TCPClientTest,主要测试CommonModuls中AsyncTCPClient功能，位置：Root%\TCPClientTest\AsyncTCPClientTest`  

`18 2020-2-26 添加TCPServerTest，主要测试新的异步服务器（AsyncTCPServer）功能，位置：Root%\TCPServerTest\AsyncTCPServerTest`    

`19 2020-3-1 添加XMLHelperTest，测试CommonModuls中的XMLHelper功能，位置:Root%\XML\XMLHelperTest`

`20 2020-3-2 添加PropertyGridTest，PropertyGrid是.net提供的控件，该控件功能是类似于VS窗体项目中控件属性窗口。接下来将测试该控件的使用方法并将其用于所有的功能类中，以便于用户轻松的更改软件属性。`  
 
`21 2020-4-1 添加EventInfo类测试，该类是System.Reflection中的一个成员类，在编写反射Cognex源码时发现该类可以获取对象中的所有事件以及使用其内部方法AddEventHandler方法动态绑定事件，所以测试一下其具体有哪些功能。位置：Root%\EventInfo测试`

`22 2020-5-30 添加无边框界面测试代码，项目上有一个需求需要弹出一个框并且在没有操作之前必须要显示在最前端，但是.net中的MessageBox没法ShowDialog，只能自己写一个，网上查了一下大神的代码，用Form做了一个无边框的Form和无边框的MessageBox.位置：Root%\无边框界面测试\NoneBorderWndTest`

`23 2020-6-5 添加线程同步测试，多个相机在触发后，由于算法不同所有结束时间不一样，但又要将所以后结果拿到后向PLC发送结果，所以必须等待所有线程都完成，该测试就是验证AutoResetEvent同步线程策略，AutoResetEvent的waitOne(2000)方法在2秒内收到Set信号后返回True,2秒内没有收到Set信号返回False,同时会卡住线程。 位置：%Root%\线程同步测试\ThreadSynchronizationTest`

`24 2020-6-12 添加IEnumerable与IEnumerator两个接口测试，主要搞清楚这两个接口是怎么用的，位置：Root%\IEnumerable和IEnumerator测试`

`25 2020-6-21 添加保存图像测试，新的保存图像的类使用了C++与C#联合的方法，C++写保存图像的核心部分，C#写参数控制部分，新的保存图像的性能比原来高2~4倍，位置：Root%\SaveImageTest`

`26 2020-7-6 添加软件设计模式测试，在该测试中将分阶段，系统的测试和学习所有软件设计模式，位置：Root%\软件设计模式`

`27 2020-7-17 添加控件数据绑定测试，主要测试Winform控件中的DataBinding属性的用法，DataBinding可以绑定数据库数据也可以绑定实体类中的数据，这里主要测试后者。位置：Root%\控件数据绑定测试`

`28 2020-7-23 添加ListView测试，主要测试ListView能不能作为新的显示日志信息的控件用，测试结果是ListView可以满足新的日志显示控件的需求。位置：Root%\ListViewTest`

`29 2020-8-10 添加DataGridView单元格类型（ColumnType）测试，.net为我们提供了一些单元格类型，如DataGridViewTextBox等，这里主要测试用户能不能自定义扩展类型，结论:理论上用户可以任意扩展类型，也能将任意自定义控件放入到DataGridView的单元格中去。位置：Root%\DataGridView单元格类型扩展`	  

`30 2020-9-30 添加GetAssemblyFromClassTest测试，该测试主要测试通过一个Dll文件中的一个类获取该Dll的反射对象，以及获取该Dll文件中的其他类信息等。位置：Root%\GetAssemblyFromClassTest`





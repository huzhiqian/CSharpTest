#<center>***ReadMe***</center>

------
##添加记录

`[1] 2019-7-12: 添加AppConfig_test1测试代码，主要在熟悉一下App.config文件的用法，读取App.config文件中的AppSettings和connectionStrings这两项内的数据可以直接利用ConfigurationManager来读取，也可以用读取XML文件的方式来读取`

`[2] 2019-7-17: 添加AppConfig_test2测试你代码，主要测试在app.config文件中添加自定义节是否能够读取得到，以及自定义节怎么配置等。测试结果是：可以读取自定义节，自定节对象需要继承ConfigurationSection类。详见测试代码。接下来将为自定义节读取类（对象）建立一个manager对象，统一管理读取appSettings、ConnectionStrings以及自定义节。`

`[3] 2019-7-18: 添加AppConfig_Test3测试代码，在AppConfig_Test2基础上添加了一个ConfigManager类，该类用来将读取App.config文件中的appSettings和connectionsStrings与自定义节统一管理起来`

 

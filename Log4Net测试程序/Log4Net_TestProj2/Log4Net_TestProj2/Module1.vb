Imports System.IO
Imports log4net


Module Module1

    Sub Main()
        Try
            Dim fi As New System.IO.FileInfo("Log4Net.config")
            log4net.Config.XmlConfigurator.Configure(fi)   ''配置log4net

            Dim myLogger As ILog = log4net.LogManager.GetLogger("Logger_Error")


            myLogger.Error("123", New Exception("error"))

        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
        Console.ReadLine()
    End Sub

End Module

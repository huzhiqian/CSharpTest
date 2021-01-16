Module Module1

    Sub Main()
        Try
            Console.WriteLine("****************定义并运行原始对象**************************")
            Dim myImageProcess As New CImageProcessing(My.Application.Info.DirectoryPath & "\ToolBlock.vpp")
            myImageProcess.Run()

            Console.WriteLine("*****************定义原始对象的浅拷贝副本，并运行**************")
            Dim shallowObj As CImageProcessing = TryCast(myImageProcess.Clone(), CImageProcessing)
            shallowObj.SetPara("shallowObj")
            shallowObj.Run()

            Console.WriteLine("=================原始对象再运行=====================")
            myImageProcess.Run()

            Console.WriteLine("*****************定义原始对象的深拷贝副本，并运行**************")
            Dim deepObj As CImageProcessing = TryCast(myImageProcess.DeepClone(), CImageProcessing)
            deepObj.SetPara("deepObj")
            deepObj.Run()

            Console.WriteLine("=================原始对象再运行=====================")
            myImageProcess.Run()
        Catch ex As Exception

            Console.WriteLine(ex.ToString())
            Throw ex
        End Try
        Console.ReadLine()
    End Sub

End Module

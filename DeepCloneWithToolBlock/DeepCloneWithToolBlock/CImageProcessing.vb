Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports Cognex.VisionPro
Imports Cognex.VisionPro.ToolBlock


''' <summary>
''' 图像处理类
''' </summary>
<Serializable>
Public Class CImageProcessing
    Implements ICloneable, IDisposable

    Private myToolBlock As CogToolBlock

    ''' <summary>
    ''' 构造函数
    ''' </summary>
    Public Sub New(tbPath As String)
        Try
            LoadObject(tbPath)
        Catch ex As Exception
            Console.WriteLine("算法文件加载失败")
        End Try

    End Sub


#Region "属性"


#End Region

#Region "方法"

    ''' <summary>
    ''' 加载算法文件
    ''' </summary>
    ''' <param name="path"></param>
    Private Sub LoadObject(path As String)
        Try
            myToolBlock = TryCast(Cognex.VisionPro.CogSerializer.LoadObjectFromFile(path), CogToolBlock)
        Catch ex As Cognex.VisionPro.Exceptions.CogException
            Throw ex
        End Try
        myToolBlock.Inputs("Input").Value = "123"

    End Sub

    Public Sub SetPara(para As String)
        If myToolBlock IsNot Nothing Then
            myToolBlock.Inputs("Input").Value = para
        End If
    End Sub

    ''' <summary>
    ''' 运行
    ''' </summary>
    Public Sub Run()
        Console.WriteLine($"TB开始运行:{Now.ToString("yyyy-MM-dd hh:mm:ss.fff")}")
        myToolBlock.Run()
        Console.WriteLine($"TB运行完成:{Now.ToString("yyyy-MM-dd hh:mm:ss.fff")}")
    End Sub
    ''' <summary>
    ''' 浅拷贝
    ''' </summary>
    ''' <returns></returns>
    Public Function Clone() As Object Implements ICloneable.Clone
        Return Me.MemberwiseClone()
    End Function

    ''' <summary>
    ''' 深度拷贝
    ''' </summary>
    ''' <returns></returns>
    Public Function DeepClone() As Object
        Using objectStream As Stream = New MemoryStream
            Dim myFormatter As IFormatter = New BinaryFormatter
            myFormatter.Serialize(objectStream, Me)
            objectStream.Seek(0, SeekOrigin.Begin)
            Return myFormatter.Deserialize(objectStream)
        End Using
    End Function
#End Region



#Region "IDisposable Support"
    Private disposedValue As Boolean ' 要检测冗余调用

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: 释放托管状态(托管对象)。
                If myToolBlock IsNot Nothing Then
                    myToolBlock.Dispose()
                End If
            End If

            ' TODO: 释放未托管资源(未托管对象)并在以下内容中替代 Finalize()。
            ' TODO: 将大型字段设置为 null。
        End If
        disposedValue = True
    End Sub

    ' TODO: 仅当以上 Dispose(disposing As Boolean)拥有用于释放未托管资源的代码时才替代 Finalize()。
    'Protected Overrides Sub Finalize()
    '    ' 请勿更改此代码。将清理代码放入以上 Dispose(disposing As Boolean)中。
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' Visual Basic 添加此代码以正确实现可释放模式。
    Public Sub Dispose() Implements IDisposable.Dispose
        ' 请勿更改此代码。将清理代码放入以上 Dispose(disposing As Boolean)中。
        Dispose(True)
        ' TODO: 如果在以上内容中替代了 Finalize()，则取消注释以下行。
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class

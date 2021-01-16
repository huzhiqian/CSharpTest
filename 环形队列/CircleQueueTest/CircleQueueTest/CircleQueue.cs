using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：CircleQueue
//命名空间：CircleQueueTest
//CLR版本：4.0.30319.42000
//内容：环形队列
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2019/3/28 9:28:29
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************
public class CircleQueue<T>:IDisposable
{
    private T[] queue;
    private int length;
    private int capacity;
    private int head;
    private int tail;
    #region 构造函数

    public CircleQueue(int _capacity)
    {
        this.capacity = _capacity;
        this.head = 0;
        this.tail = 0;
        this.length = 0;
        this.queue = new T[this.capacity];
    }

    #endregion


    #region 属性
    /// <summary>
    /// 获取队列长度
    /// </summary>
    public int Length
    {
        get { return this.length; }
    }

    /// <summary>
    /// 获取对头指向数据
    /// </summary>
    public int Head
    {
        get { return head; }
    }

    /// <summary>
    /// 获取对尾指向数据
    /// </summary>
    public int Tail
    {
        get { return tail; }
    }

    #endregion

    #region 公共方法

    /// <summary>
    /// 清空队列
    /// </summary>
    public void Clear()
    {
        head = 0;
        tail = 0;
        length = 0;
    }

    /// <summary>
    /// 检测队列是否为空，空返回True,反之为False
    /// </summary>
    /// <returns></returns>
    public bool IsEmpty()
    {
        return length == 0;
    }

    /// <summary>
    /// 检查队列是否已满，队列满返回True,反之返回False
    /// </summary>
    /// <returns></returns>
    public bool IsFull
    {
        get { return length == capacity; }
    }

    /// <summary>
    /// 元素入队
    /// </summary>
    /// <param name="node">入队元素</param>
    /// <returns></returns>
    public bool EnQueue(T node)
    {
        lock (queue)
        {
            if (IsFull)
            {
                //队列尾向前移动，对头向后移动
                tail = (++tail) % capacity;
                head = (++head) % capacity;
                queue[tail] = node;
                return true;
            }
            else
            {
                queue[tail] = node;
                tail = (++tail) % capacity;
                length++;
                return true;
            }
        }

    }

    /// <summary>
    /// 元素出队
    /// </summary>
    /// <returns></returns>
    public T DeQueue()
    {
        lock (queue)
        {
            T element = default(T);
            if (!IsEmpty())
            {
                element = queue[head];
                head = (++head) % capacity;
                length--;
            }
            return element;
        }
    }

    /// <summary>
    /// 遍历队列
    /// </summary>
    public void TravelQueue()
    {
        for (int i = head; i < head + length; i++)
        {
            Console.WriteLine(queue[i%capacity]);
            Console.WriteLine($"前面还有{i-head}个元素");
        }
    }
    #endregion

    #region 私有方法



    #endregion

    #region IDisposable Support
    private bool disposedValue = false; // 要检测冗余调用

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // TODO: 释放托管状态(托管对象)。
                queue = null;
            }

            // TODO: 释放未托管的资源(未托管的对象)并在以下内容中替代终结器。
            // TODO: 将大型字段设置为 null。

            disposedValue = true;
        }
    }

    // TODO: 仅当以上 Dispose(bool disposing) 拥有用于释放未托管资源的代码时才替代终结器。
    // ~CircleQueue() {
    //   // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
    //   Dispose(false);
    // }

    // 添加此代码以正确实现可处置模式。
    public void Dispose()
    {
        // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
        Dispose(true);
        // TODO: 如果在以上内容中替代了终结器，则取消注释以下行。
        GC.SuppressFinalize(this);
    }
    #endregion

    #region 委托



    #endregion

    #region 事件



    #endregion
}

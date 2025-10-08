using System;
using System.Runtime.InteropServices;
using System.Threading;
class ThreadLifecycleDemo
{     static void Main()
    {
        Thread thread = new Thread(ThreadMethod);
        Console.WriteLine( thread.ThreadState);
        thread.Start();
        Console.WriteLine(  thread.ThreadState);
        thread.Join();
        Console.WriteLine(thread.ThreadState);
    
    }
    static void ThreadMethod()
    {
        Console.WriteLine(" Thread state: " + Thread.CurrentThread.ThreadState);
        Console.WriteLine(thread.ThreadState);
        Thread.Sleep(2000);
    }
}

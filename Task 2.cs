using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Thread foregroundThread = new Thread(ForegroundTask);
        foregroundThread.IsBackground = false; 
        foregroundThread.Start();

      
        Thread backgroundThread = new Thread(BackgroundTask);
        backgroundThread.IsBackground = true;
        backgroundThread.Start();

        Console.WriteLine("Main thread finished execution.\n");
    }

   
    static void ForegroundTask()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"[Foreground] Critical Task - Iteration {i}");
            Thread.Sleep(500); 
        }

        Console.WriteLine("[Foreground] Critical Task Completed.\n");
    }


    static void BackgroundTask()
    {
        int i = 1;
        while (true)
        {
            Console.WriteLine($"[Background] Non-Critical Task - Iteration {i++}");
            Thread.Sleep(1000); 
        }
    }
}

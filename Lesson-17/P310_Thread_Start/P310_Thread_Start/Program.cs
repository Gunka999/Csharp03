using System;
using System.Threading;

namespace P310_Thread_Start
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread threadLoopA = new Thread(LoopA);
            Thread threadLoopB = new Thread(LoopB);

            //threadLoopA.IsBackground = true;
            //threadLoopB.IsBackground = true;

            threadLoopA.Start();
            threadLoopB.Start();

            //Thread.Sleep(1000);
        }

        static void LoopA()
        {
            Thread.Sleep(1000);

            for (int i = 0; i < 1000; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Loop A: {i}");
            }

        }

        static void LoopB()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Loop B: {i}");
            }
        }
    }
}

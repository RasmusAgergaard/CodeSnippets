using System;
using System.Diagnostics;
using System.Threading;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1
            var threadOne = new Thread(Work1);
            var threadTwo = new Thread(Work2);
            threadOne.Start();
            threadTwo.Start();

            //Example 2
            var threadOne = new Thread(MethodJoin);
            threadOne.Start();
            threadOne.Join();
            Console.WriteLine("Work Completed");

            //Example 3
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var threadOne = new Thread(ProcessSleep);
            threadOne.Start();
            threadOne.Join();

            stopwatch.Stop();
            var elapsedTime = stopwatch.Elapsed;

            var elapsedTimeString = String.Format("{0:00}:{1:00}:{2:00}", elapsedTime.Hours, elapsedTime.Minutes, elapsedTime.Seconds);

            Console.WriteLine($"Total time: {elapsedTimeString}");
            Console.WriteLine("Work completed!");
        }

        static void ProcessSleep()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Work in progress");
                Thread.Sleep(1000);
            }
        }

        static void MethodJoin()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Work in progress...");
            }
        }

        static void Work1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Work1 is called {i}");
            }
        }

        static void Work2()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Work2 is called {i}");
            }
        }
    }
}

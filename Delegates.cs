using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates
{
    class Program
    {
        //Delegate
        public delegate void WorkPerformedHandler(int hours, string workType);

        static void Main(string[] args)
        {
            //Delegate instance
            WorkPerformedHandler delegate1 = new WorkPerformedHandler(WorkedPerformed1);
            WorkPerformedHandler delegate2 = new WorkPerformedHandler(WorkedPerformed2);

            //Add to the invocation list
            delegate1 += delegate2;

            //Invoking delegate instance 1 and 2
            delegate1(8, "Hard work");
        }

        //Handler 1
        static void WorkedPerformed1(int hours, string workType)
        {
            Console.WriteLine($"WorkedPerformed1 called ({hours} / {workType})");
        }

        //Handler 2
        static void WorkedPerformed2(int hours, string workType)
        {
            Console.WriteLine($"WorkedPerformed2 called ({hours} / {workType})");

        }
    }
}
using System;

namespace DisposeAndFinalize
{
    public class MyClass : IDisposable
    {
        //Constructor
        public MyClass()
        {
            //Initialization
        }

        //Finalize (aka Destructor) 
        ~MyClass()
        {
            Dispose();
        }

        public void Dispose()
        {
            //write code to release unmanaged resources
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

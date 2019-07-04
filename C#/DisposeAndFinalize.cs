using System;

namespace DisposeAndFinalize
{
    //Class that implements the IDisposable interface
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
            //Example: Bitmap loaded into memory, and removed again with Dispose()
            var bitmap = new Bitmap(@"C:\Code\king.png");
            bitmap.Dispose();
        }
    }
}

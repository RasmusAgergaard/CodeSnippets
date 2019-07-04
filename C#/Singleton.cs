using System;

namespace SingletonExample
{   
    //Thread Safety Singleton
    public sealed class Singleton
    {
        //This implementation is thread-safe.
        //In the following code, the thread is locked on a shared object and checks whether an instance has been created or not.
        //This takes care of the memory barrier issue and ensures that only one thread will create an instance.
        //For example: Since only one thread can be in that part of the code at a time, by the time the second thread enters it, the first thread will have created the instance, so the expression will evaluate to false.
        //The biggest problem with this is performance; performance suffers since a lock is required every time an instance is requested.

        //Common characteristics of a Singleton Pattern - A single constructor, that is private and parameterless
        private Singleton()
        {
            var random = new Random();
            Id = random.Next(999);
        }

        private static readonly object padlock = new object();
        private static Singleton instance = null;
        public int Id { get; set; }

        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }

                    return instance;
                }
            }
        }
    }


    //Thread Safety Singleton using Double Check Locking
    public sealed class Singleton2
    {
        //The double checked pattern is used to avoid obtaining the lock every time the code is executed. 
        //If the call are not happening together then the first condition will fail and the code execution will not execute the locking thus saving resources.

        private Singleton2()
        {

        }

        private static readonly object padlock = new object();
        private static Singleton2 instance = null;

        public static Singleton2 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton2();
                        }
                    }
                }

                return instance;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var singleton = new Singleton();                  //Cannot be instantiated

            Console.WriteLine(Singleton.Instance.Id);           //The instance can be accessed like this
        }
    }
}

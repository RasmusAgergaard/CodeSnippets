using System;

namespace Delegates3
{
    public class MethodClass
    {
        public void Method1(string message)
        {
            Console.Write("Method1 called - ");
        }
        public void Method2(string message)
        {
            Console.Write("Method2 called - ");
        }
    }

    class Program
    {
        //Declares a delegate that can encapsulate a method that takes a string as an argument and returns void
        public delegate void Del(string message);

        // Create a method for a delegate
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        //Example method uses the Del type as a parameter
        public static void MethodWithCallback(int param1, int param2, Del callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }

        static void Main(string[] args)
        {
            //Instantiate the delegate
            Del handler = DelegateMethod;

            //Call the delegate
            handler("Hello Bill");                              //Output: Hello Bill

            MethodWithCallback(1, 2, handler);                  //Output: The number is: 3

            //Multicasting example
            var methodClass = new MethodClass();
            Del del1 = methodClass.Method1;
            Del del2 = methodClass.Method2;
            Del del3 = DelegateMethod;

            Del allMethodsDelegate = del1 + del2 + del3;
            //Your can also use += d3

            //When allMethodsDelegate is invoked, all three methods are called in order
            allMethodsDelegate("Hello Phill");                  //Output: Method1 called - Method2 called - Hello Phill

            //Remove Method1 from the invocation list
            allMethodsDelegate -= del1;

            allMethodsDelegate("Hello Phill");                  //Output: Method2 called - Hello Phill
        }
    }
}

using System;
using System.IO;

namespace TryCatchExample
{
    public class ProcessFile
    {
        public void RunProcess()
        {
            try
            {
                using (StreamReader streamReader = File.OpenText("data.txt"))
                {
                    Console.WriteLine($"The first line of the file is {streamReader.ReadLine()}");
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"The file was not found: {e}");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine($"The directory was not found: {e}");
            }
            catch (IOException e)
            {
                Console.WriteLine($"The could not be open: {e}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // ********** Example 1 ********** //
            object testObject = null;

            try
            {
                int testNumber = (int)testObject;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine($"Exception caught:");
                Console.WriteLine(e.GetType().FullName);
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
            }

            Console.WriteLine("\n\n");


            // ********** Example 2 ********** //
            var processFile = new ProcessFile();

            processFile.RunProcess(); //FileNotFoundException caught
        }
    }
}

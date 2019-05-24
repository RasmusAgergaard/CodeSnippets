using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var openWith = new Dictionary<string, string>();

            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch (ArgumentException)
            {

                Console.WriteLine("An element with Key = 'txt' already exists");        //Output: An element with Key = 'txt' already exists
            }

            Console.WriteLine(openWith["txt"]);                                         //Output: notepad.exe

            //If the key exists, the value is changed
            openWith["rtf"] = "winword.exe";

            //If the key does not exists, a new key/value pair is added
            openWith["doc"] = "winword.exe";

            // ContainsKey can be used to test keys before inserting them
            if (!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hypertrm.exe");
            }

            // When you use foreach to enumerate dictionary elements, the elements are retrieved as KeyValuePair objects.
            foreach (KeyValuePair<string, string> item in openWith)
            {
                Console.WriteLine($"Key: {item.Key} - Value: {item.Value}");            //Output: Key: txt - Value: notepad.exe
            }                                                                           // ... and the rest of the key/value pairs

            //Extract values/keys alone
            Dictionary<string, string>.ValueCollection valueColl = openWith.Values;
            Dictionary<string, string>.KeyCollection keyColl = openWith.Keys;

            //Run though the new collection
            foreach (string value in valueColl)
            {
                Console.WriteLine(value);
            }

            //Remove an element
            openWith.Remove("doc");

            if (!openWith.ContainsKey("doc"))
            {
                Console.WriteLine("Key 'doc' is not found");                            //Output: Key 'doc' is not found
            }
        }
    }
}

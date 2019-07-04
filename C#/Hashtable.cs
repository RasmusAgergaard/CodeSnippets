using System;
using System.Collections;

namespace HashtableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable openWith = new Hashtable();

            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");
            Console.WriteLine($"Extension 'rtf' opens with {openWith["rtf"]}");         //Output: Extension 'rtf' opens with wordpad.exe

            openWith["rtf"] = "winword.exe";
            Console.WriteLine($"Extension 'rtf' opens with {openWith["rtf"]}");         //Output: Extension 'rtf' opens with winword.exe

            //If a key does not exist, setting the default Item property for that key adds a new key/value pair
            openWith["doc"] = "winword.exe";
            Console.WriteLine($"Extension 'doc' opens with {openWith["doc"]}");         //Output: Extension 'doc' opens with winword.exe

            if (!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hypertrm.exe");
                Console.WriteLine($"Value added for key 'ht': {openWith["ht"]}");       //Output: Value added for key 'ht': hypertrm.exe
            }

            foreach (DictionaryEntry item in openWith)
            {
                Console.WriteLine($"Key: {item.Key} - Value: {item.Value}");            //Output: Key: bmp - Value: paint.exe
            }                                                                           //        Key: dib - Value: paint.exe
                                                                                        //        Key: txt - Value: notepad.exe
                                                                                        //        Key: ht - Value: hypertrm.exe
                                                                                        //        Key: rtf - Value: winword.exe
                                                                                        //        Key: doc - Value: winword.exe
            openWith.Remove("txt");
            if (!openWith.ContainsKey("txt"))
            {
                Console.WriteLine($"Key 'txt' not found");                                    //Output: Key 'txt' not found
            }
        }
    }
}

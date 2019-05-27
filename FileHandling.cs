using System;
using System.IO;

namespace FileHandlingExample
{
    public class FileWriter
    {
        private string _path;

        public string FileName { get; set; }
        public string FileContent { get; set; }

        public void GetDataFromUser()
        {
            Console.WriteLine("Enter filename");
            FileName = Console.ReadLine();
            Console.WriteLine("Enter content");
            FileContent = Console.ReadLine();
        }

        public void WriteContentToFile()
        {
            _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//" + FileName + ".txt";

            var fileStream = new FileStream(_path, FileMode.Append, FileAccess.Write);
            var streamWriter = new StreamWriter(fileStream);

            streamWriter.WriteLine(FileContent);
            streamWriter.Flush();
            streamWriter.Close();
            fileStream.Close();

            Console.WriteLine($"Content saved to file {FileName}.txt");
            Console.WriteLine("");
        }

        public void PrintContentOfFile()
        {
            _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//" + FileName + ".txt";

            var fileStream = new FileStream(_path, FileMode.Open, FileAccess.Read);
            var streamWriter = new StreamReader(fileStream);

            Console.WriteLine($"Current content:");
            streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
            var tempStr = streamWriter.ReadLine();

            while (tempStr != null)
            {
                Console.WriteLine(tempStr);
                tempStr = streamWriter.ReadLine();
            }

            streamWriter.Close();
            fileStream.Close();
            
            Console.WriteLine("\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var fileWriter = new FileWriter();

            while (true)
            {
                fileWriter.GetDataFromUser();
                fileWriter.WriteContentToFile();
                fileWriter.PrintContentOfFile();
            }
        }
    }
}

using System;
using System.IO;
using System.Xml.Serialization;

namespace SerializationExample
{
    public class Book
    {
        public Book()
        {
            //The class must have a public constructor without parameters
        }

        public Book(string title, int rating, int numberOfPages, bool recomended)
        {
            Title = title;
            Rating = rating;
            NumberOfPages = numberOfPages;
            Recomended = recomended;
        }

        public string Title { get; set; }
        public int Rating { get; set; }
        public int NumberOfPages { get; set; }
        public bool Recomended { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // ************ Write to file ************ //
            var book = new Book("Bill Gates", 8, 452, true);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof (Book));

            var fileName = "SerializationExample.xml";
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//" + fileName;
            FileStream file = File.Create(path);

            xmlSerializer.Serialize(file, book);
            file.Close();

            Console.WriteLine($"'{fileName}' saved at: {path}");


            // ************ Read from file ************ //
            var newBook = new Book();

            StreamReader file2 = new StreamReader(path);

            newBook = (Book)xmlSerializer.Deserialize(file2);
            file.Close();

            Console.WriteLine($"File read from {path}");
            Console.WriteLine($"{newBook.Title}");
        }
    }
}

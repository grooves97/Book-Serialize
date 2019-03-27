using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace HWBook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> firstBooks = new List<Book>
            {
               new Book { Name = "Программирования C# 5.0 и платформа .NET 4.5", Author = "Эндрю Троелсен", Price = 1950, Year = 2016 },
               new Book { Name = "Шантарам", Author = "Грегори Дэвид Робертс", Price = 5000, Year = 2003 },
               new Book { Name = "Властелин колец", Author = "Джон Рональд Руэл Толкин", Price = 3000, Year = 1954 },
            };

            List<Book> secondBooks = new List<Book>();

            var serializer = new BinaryFormatter();

            using (var stream = File.Create("BooksData.bin"))
            {
                serializer.Serialize(stream, firstBooks);
            }

            using (var stream = File.OpenRead("BooksData.bin"))
            {
                secondBooks = serializer.Deserialize(stream) as List<Book>;
            }

            foreach (var book in secondBooks)
            {
                foreach (var property in book.GetType().GetRuntimeProperties())
                {
                    foreach (var attribute in property.GetCustomAttributes())
                    {
                        Console.Write(((MyAttribute)attribute).Name + property.GetValue(book));
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

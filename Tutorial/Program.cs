using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colorful;
using Console = Colorful.Console;

namespace Tutorial
{
    class Program
    {
    
        static void Main(string[] args)
        {





            var books = new List<Book>();

            var book = new Book
            {
                Name = "King of Island",
                PageCount = 234
            };

            books.Add(book);

            var lviv = new Book
            {
                Name = "Lviv",
                PageCount = 123
            };




            var imagesContainer = new List<Figure>();

            var circle = new Figure
            {
                FigureType = FigureType.Circle,
                Color = Color.Brown
            };

            var square = new Figure
            {
                FigureType = FigureType.Square,
                Color = Color.Aqua
            };

            imagesContainer.Add(square);
            imagesContainer.Add(circle);



            var processorTestResults = new List<TestResults>();
            var coreI7 = new TestResults
            {
                Processor = "CoreI 7",
                Rating = 113
            };

            var ryzen7 = new TestResults
            {
                Processor = "Ryzen7",
                Rating = 131
            };

            processorTestResults.Add(coreI7);

            //******************************************************

            BookShelf bookShelf = new BookShelf();
            bookShelf.AddBook(book);
            bookShelf.AddBook(lviv);

            bookShelf.RemoveBook("King of Island2");
           var k = bookShelf.GetBook("King of Island");
            bool isPresent = bookShelf.IsBookPresent("Lviv");


            var booShelf2 = new BookShelf();
            booShelf2.AddBook(lviv);
            bool isPresent2 = booShelf2.IsBookPresent("Lviv");
            CheckShelfs();


            
               


            void CheckShelfs()
            {
                if (isPresent)
                {
                    Console.WriteLine($"We have book {book.Name} in First shelf", Color.LawnGreen);
                }
                else
                {
                    Console.WriteLine("Don't have in First shelf", Color.Crimson);
                }


                if (isPresent2)
                {
                    Console.WriteLine($"We have book {book.Name} in Second shelf", Color.LawnGreen);
                }
                else
                {
                    Console.WriteLine("Don't have in Second shelf", Color.Crimson);
                }
            }

            


            Console.ReadLine();
        }

        

















    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            var firstBook = new Book();
            firstBook.setTitle("Clean Code");
            var secondBook = new Book();
            secondBook.setTitle("Harry Potter");
            var thirdBook = new Book();
            thirdBook.setTitle("Harry Potter 2");

            var library = new List<Book>();
            library.Add(firstBook);
            library.Add(secondBook);
            library.Add(thirdBook);


            try
            {
                var bookIndex = int.Parse(Console.ReadLine());
                Console.WriteLine(library[bookIndex].getTitle());
                //print library(bookIndextitle 
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format not accepted !" + e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("You have entered a number out of the excepted range!" + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("You have entered incorrect value!" + e.Message);
            }
            
            
        }
    }
}

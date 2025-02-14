using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

          
            store.AddBook(new Book("1984", "Джордж Оруел", 45));
            store.AddBook(new Book("Тайната градина", "Франчес Ходжсън Бърнет", 60));
            store.AddBook(new Book("Малки жени", "Луиза Мей Алкът", 40));
            store.AddBook(new Book("Убиецът на зловещи сънища", "Стюарт Мърдок", 55));

           
            Console.WriteLine("Всички книги в магазина:");
            store.PrintAllBooks();

         
            Console.WriteLine("\nОбщата стойност на всички книги: " + store.CalculateTotalPrice() + " лв.");

        
            store.ApplyDiscountForExpensiveBooks();

            Console.WriteLine("\nКниги след прилагане на отстъпка:");
            store.PrintAllBooks();

         
            Console.WriteLine("\nТърсене на книги на автора 'Джордж Оруел':");
            var booksByOrwell = store.SearchByAuthor("Джордж Оруел");
            foreach (var book in booksByOrwell)
            {
                Console.WriteLine(book);
            }

          
            Console.WriteLine("\nПремахване на книга с заглавие '1984'.");
            if (store.RemoveBook("1984"))
            {
                Console.WriteLine("Книгата беше успешно премахната.");
            }
            else
            {
                Console.WriteLine("Книгата не беше намерена.");
            }

         
            Console.WriteLine("\nНалични книги след премахване:");
            store.PrintAllBooks();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Store
    {
        private List<Book> books;

        public Store()
        {
            books = new List<Book>();
        }

   
        public void AddBook(Book book)
        {
            books.Add(book);
        }

   
        public bool RemoveBook(string title)
        {
            var book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                books.Remove(book);
                return true;
            }
            return false;
        }

     
        public List<Book> SearchByAuthor(string author)
        {
            return books.FindAll(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase));
        }

  
        public void PrintAllBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Няма налични книги в магазина.");
                return;
            }
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }

      
        public decimal CalculateTotalPrice()
        {
            decimal total = 0;
            foreach (var book in books)
            {
                total += book.Price;
            }
            return total;
        }

      
        public void ApplyDiscountForExpensiveBooks()
        {
            foreach (var book in books)
            {
                if (book.Price > 50)
                {
                    book.Price *= 0.90m; 
                }
            }
        }
    }
}

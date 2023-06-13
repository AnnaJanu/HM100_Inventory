using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100HM_Inventory
{
    internal class Inventory
    {
        public Inventory() { }
        private List<Book> _books;

        public void AddBook(Book book)
        { _books.Add(book); }

        public void RemoveBook(Book book)
        { bool wasRemoved = _books.Remove(book);
            if (wasRemoved)
            {
                Console.WriteLine("Book has been removed");
            }
            else { Console.WriteLine("Book was not found"); }
        }
    }
}

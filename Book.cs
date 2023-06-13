using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100HM_Inventory
{
    internal class Book
    {
        public string Author { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public short YearOfPublication { get; private set; }
        public bool IsBestseller { get; private set; }

        public Book (string author, string title, string description, short yearOfPublication, bool isBestseller)
        {
            Author = author;
            Title = title;
            Description = description;
            YearOfPublication = yearOfPublication;
            IsBestseller = isBestseller;
        }
    }
}

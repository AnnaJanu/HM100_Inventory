using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100HM_Inventory
{
    internal class Fiction : Book
    {
        public string Language { get; private set; }
        public EnumFictionGenre Genre { get; private set; }
        public Fiction(string author, string title, string description, short yearOfPublication, bool isBestseller, string language, EnumFictionGenre genre) : base(author, title, description, yearOfPublication, isBestseller) 
        {
            Language = language;
            Genre = genre;
        }
    }
}

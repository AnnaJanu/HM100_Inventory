using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100HM_Inventory
{
    internal class Dictionary : Book
    {
        public string Language1 { get; private set; }
        public string Language2 { get; private set;}
        public Dictionary (string author, string title, string description, short yearOfPublication, bool isBestseller, string language1, string language2) : base (author, title, description, yearOfPublication, isBestseller)
        {
            language1 = Language1;
            language2 = Language2;
        }
    }
}

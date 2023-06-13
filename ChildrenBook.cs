using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100HM_Inventory
{
    internal class ChildrenBook : Book
    {
        public ChildrenBook(string author, string title, string description, short yearOfPublication, bool isBestseller) : base(author, title, description, yearOfPublication, isBestseller)
        { }
    }
}

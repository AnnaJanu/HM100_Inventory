using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100HM_Inventory
{
    internal class PopularScience : Book
    {
        public string Language { get; private set; }
        public EnumPopScienceBranch ScienceBranch { get; private set; }
        public PopularScience(string author, string title, string description, short yearOfPublication, bool isBestseller, string language, EnumPopScienceBranch scienceBranch) : base(author, title, description, yearOfPublication, isBestseller) 
        {
            Language = language;
            ScienceBranch = scienceBranch;
        }
    }
}

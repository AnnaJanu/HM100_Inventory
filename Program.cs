namespace _100HM_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChildrenBook book1 = new ChildrenBook("Astrid Lindgren", "Pippi Longstocking", "-", 2015, true);
            Dictionary book2 = new Dictionary("Irena Sosare", "English-Latvian dictionary", "-", 1993, false, "English", "Latvian");
            Fiction book3 = new Fiction("George Orwell", "1984", "-", 2020, true, "Latvian", EnumFictionGenre.ScienceFiction);
            PopularScience book4 = new PopularScience("Mary Beard", "SPQR", "-", 2016, true, "Englis", EnumPopScienceBranch.History);

            Inventory inventory1 = new Inventory();

            inventory1.AddBook(book1);
            inventory1.AddBook(book2);
            inventory1.AddBook(book3);
            inventory1.AddBook(book4);
        }
    }
}
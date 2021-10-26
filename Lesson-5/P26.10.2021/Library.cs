using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18._10._2021

{
    public class Library
    {
        public List<BOOK> BOOKs = new List<BOOK>();

        public List<BOOK> FindAllBooksByName(string names)
        {
            List<BOOK> allBook = new List<BOOK>(); ;
            foreach (var item in BOOKs)
            {
                if (item.name == names)
                {
                    allBook.Add(item);
                }
            }
            return allBook;

        }
        public void FindAllBooksByName2(string names)
        {
            foreach (var item in BOOKs)
            {
                if (item.name == names)
                {
                    Console.WriteLine(item.name+ " "+item.Author);
                }
            }

        }

    }
}

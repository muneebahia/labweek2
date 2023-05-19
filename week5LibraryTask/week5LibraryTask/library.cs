using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5LibraryTask
{
    public class library
    {
        public List<string> nameofChapter = new List<string>();
        public string Author;
        public int Pages;
        public int BookMarks;
        public int Price;
        public bool isAvailable;

        public library(string Author, int Pages, int BookMarks, int Price, bool isAvailable)
        {
            this.Author = Author;
            this.Pages = Pages;
            this.BookMarks = BookMarks;
            this.Price = Price;
            this.isAvailable = isAvailable;

        }
        public library()
        {

        }
        public void addinlist(string name)
        {
            nameofChapter.Add(name);
        }
      public string checkChapterNo(int chapterNo)
        {
           string chpName= nameofChapter[chapterNo - 1];
            return chpName;
        }

    }
}
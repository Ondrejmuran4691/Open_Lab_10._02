using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._02
{
    class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private string releaseDate;
        public string atitle;
        public int apages;
        public string acategory;
        public string aauthor;
        public string areleaseDate;
    



        public void itle()
        { 
            title = atitle;
            atitle = title;
        }
        public void ages() 
        { 
            pages = apages;
            apages = pages;
        }
        public void ategory() 
        { 
            category = acategory;
            acategory = category;
        }
        public void uthor() 
        {
            author = aauthor;
            aauthor = author;
        }
        public void eleaseDate() 
        { 
            releaseDate = areleaseDate;
            areleaseDate = releaseDate;
        }
        public void writeall() 
        {

            Console.WriteLine(atitle);
            Console.WriteLine(apages);
            Console.WriteLine(acategory);
            Console.WriteLine(aauthor);
            Console.WriteLine(areleaseDate);
        }
    }
}

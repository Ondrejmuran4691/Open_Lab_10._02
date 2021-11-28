using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._02
{
    class Book
    {
        private int pages;
        private string category;
        private string author;
        private int releaseDate;
        private string title;
        public string atitle;
        public int apages;
        public string acategory;
        public string aauthor;
        public int areleaseDate;




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

            Console.WriteLine(title);
            Console.WriteLine(pages);
            Console.WriteLine(category);
            Console.WriteLine(author);
            Console.WriteLine(releaseDate);
        }
    }
}

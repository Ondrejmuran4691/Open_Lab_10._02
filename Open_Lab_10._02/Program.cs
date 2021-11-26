


using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._02
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR._title = "LOTR";
            LOTR._author = "J. R. R. Tolkien";
            LOTR._category = "Fantasy";
            LOTR._pages = 9250;
            LOTR._releaseDate = "29 July 1954";
            


            Console.WriteLine(LOTR._title);

        }
    }
}

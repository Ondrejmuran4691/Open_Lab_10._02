


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
            LOTR.atitle = "LOTR";
            LOTR.aauthor = "J. R. R. Tolkien";
            LOTR.acategory = "Fantasy";
            LOTR.apages = 9250;
            LOTR.areleaseDate = 1954;
            LOTR.itle();
            LOTR.uthor();
            LOTR.ategory();
            LOTR.ages();
            LOTR.eleaseDate();

            LOTR.writeall();




        }
    }
}

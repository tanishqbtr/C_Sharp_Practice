using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    class Book
    {
        public string Title;
        public string Author;
        public int pages;
        private int rating;
        public static int Count = 0;
        public Book()
        {
            Console.WriteLine("New Object Created");
            Count++;

        }
        public Book(string t1, string a1, int p1, int r1=0)
        {
            this.Title = t1;
            this.Author = a1;
            this.pages = p1;
            this.Rating = r1;
            Count++;
        }
        public bool isLong()
        {
            if (pages <= 500)
                return false;
            else
                return true;
        }

        //Getters and Setters
        public int Rating
        {
            get { return rating; }
            set
            {
                if (value == 1 || value == 2 || value == 3 || value == 4 || value == 5)
                    rating = value;
                else
                    rating = 0;
            }
        }
    }
}

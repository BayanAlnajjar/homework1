using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.myclass
{
    public class Book : IBorrowable
    {
        public int Id { get; set; }
        public string Title
        {
            get
            {
                return Title;
            }
            set
            {
                if (Title == null)
                {
                    Console.WriteLine("Title is not valid");
                }
                else
                {
                    Title = value;
                }
            }
        }
        public string Author { get; set; }
        public int Year { get; set; }
        public decimal Price
        {
            get
            {
                return Price;
            }
            set
            {
                if (value >= 0)
                { Price = value; }
                else { Console.WriteLine("Price cannot be negative"); }
            }


        }
        public bool IsAvailable { get; set; }

        public bool Borrow()
        {
            if (IsAvailable == true)
            {
                IsAvailable = false;
                return true;
            }

            else return false;
        }

        public bool Return()
        {
            if (IsAvailable == false)
            {
                IsAvailable = true;
                return true;
            }

            else return false;
        }
        public override string ToString()
        {
            return $"ID : {Id} ," +
                $" Title : {Title}," +
                $" Author {Author} ," +
                $" Year: {Year}," +
                $" Price :{Price}," +
                $" Available:{IsAvailable}";
        }
    }

}

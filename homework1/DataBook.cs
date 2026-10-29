using Logic.myclass;
using System;
using System.Collections.Generic;
using System.Text;

namespace homework1
{
    public class DataBook
    {
        public static List<Book> GetBooks()
        {
            List<Book> b = new List<Book>();
            b.Add(new Book { Id = 1, Title = "C++", Author = "Bayan", Year = 2006, Price = 500, IsAvailable = true });
            b.Add(new Book { Id = 2, Title = "C#", Author = "Nour", Year = 2009, Price = 50.5M, IsAvailable = true });
            b.Add(new Book { Id = 3, Title = "java", Author = "Hasan", Year = 2016, Price = 120, IsAvailable = true });
            b.Add(new Book { Id = 4, Title = "html", Author = "Reem", Year = 2011, Price = 110, IsAvailable = true });
            b.Add(new Book { Id = 5, Title = "javaScript", Author = "Nada", Year = 2005, Price = 150.8M, IsAvailable = true });
            b.Add(new Book { Id = 6, Title = "python", Author = "Ahmad", Year = 2010, Price = 1200, IsAvailable = true });
            b.Add(new Book { Id = 7, Title = "pro1", Author = "Amin", Year = 2026, Price = 510, IsAvailable = true });
            b.Add(new Book { Id = 8, Title = "pro2", Author = "Khaled", Year = 2014, Price = 215, IsAvailable = true });
            b.Add(new Book { Id = 9, Title = "sql", Author = "Malak", Year = 2023, Price = 300, IsAvailable = true });
            b.Add(new Book { Id = 10, Title = "electrony", Author = "Aya", Year = 2025, Price = 500, IsAvailable = true });
            b.Add(new Book { Id = 11, Title = "math", Author = "Amr", Year = 1996, Price = 400, IsAvailable = true });
            b.Add(new Book { Id = 12, Title = "logic", Author = "Bilal", Year = 2001, Price = 600, IsAvailable = true });

            return b;


        }

    }


}
   


using Logic.myclass;
using System;
using System.Collections.Generic;
using System.Text;

namespace homework1
{
    public class LBook
    {
        public static void L(List<Book> books)
        {
            Console.WriteLine("\n available Books:");
            var avBooks = books.Where(b => b.IsAvailable == true).OrderByDescending(b => b.Year);
            foreach (var book in avBooks) { Console.WriteLine(book); }

            Console.WriteLine("\n  Author Books :");
            var ab = books.Where(b => b.Author == "Bayan");
            foreach (var book in ab) { Console.WriteLine(book); }

            Console.WriteLine("Titles");
            var titeles = books.Select(b => b.Title);
            foreach (var title in titeles) { Console.WriteLine(title); }

            Console.WriteLine("Prices ");
            decimal avg = books.Average(b => b.Price);
            decimal max = books.Max(b => b.Price);
            Console.WriteLine($"Avarage Price :{avg}");
            Console.WriteLine($"max Price :{max}");

            Console.WriteLine("all books for an author");
            var Group = books.GroupBy(b => b.Author);
            foreach (var group in Group) { Console.WriteLine($"books is{Group}"); }

            Console.WriteLine("Are there books greater than 100?");
            bool p = books.Any(b => b.Price >= 100);
            Console.WriteLine(p);

            Console.WriteLine("Skip and Take");
            var s = books.OrderByDescending(b => b.Year).Skip(1).Take(3);
            foreach (var book in s) { Console.WriteLine(book); }
        }
    }
}

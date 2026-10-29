using Logic.myclass;

namespace homework1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var books = DataBook.GetBooks();
            int c = 0;
            while (c != 4 && c < 5)
            {
                Console.WriteLine("\n MY LIBRARY MENU:\n");
                Console.WriteLine("1. Display all the books");
                Console.WriteLine("2.Borrow a book");
                Console.WriteLine("3.Return a book");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Enter a number");
                c = int.Parse(Console.ReadLine());

                switch (c)
                {
                    case 1:
                        foreach (Book book in books)
                        {
                            Console.WriteLine(book.ToString());
                        }
                        break;

                    case 2:
                        Console.Write("Enter book ID to borrow: ");

                        int borrowId = int.Parse(Console.ReadLine());

                        Book borrowBook = null;

                        foreach (Book book in books)
                        {
                            if (book.Id == borrowId)
                            {
                                borrowBook = book;
                                break;
                            }
                        }

                        if (borrowBook == null)
                        {
                            Console.WriteLine("Book not found.");
                        }
                        else if (borrowBook.Borrow())
                        {
                            Console.WriteLine("Book borrowed successfully.");
                        }
                        else
                        {
                            Console.WriteLine("The book is already borrowed.");
                        }

                        break;
                    case3:
                        Console.WriteLine("Enter BookId to Return");
                        int ReturnId = int.Parse(Console.ReadLine());
                        Book returnBook = null;
                        foreach (Book book in books)
                        {
                            if (book.Id == ReturnId)
                            {
                                returnBook = book;
                                break;
                            }

                        }
                        if (returnBook == null)
                        {
                            Console.WriteLine("Book not found");
                        }
                        else if (returnBook.Return())
                        {
                            Console.WriteLine("Book returned");
                        }
                        else
                        {
                            Console.WriteLine("Book is available");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Bye Bye");
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            }
            Console.WriteLine("MY Linq part");
            var LBook = new LBook();
            Console.WriteLine(LBook.L);













        }
    }

}

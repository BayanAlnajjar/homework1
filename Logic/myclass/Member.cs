using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.myclass
{
    public class Member : Person
    {
        public int id { get; set; }
        public string Name { get; set; }
        public List<Book> BorrowedBooks;
        public override string GetRole()
        {
            return "Member";
        }
        public override string ToString()
        {
            return $"member ID: {id},Name : {Name}";
        }

    }
}

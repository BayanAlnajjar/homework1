using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.myclass
{
    public class Librarian : Person
    {
        public override string GetRole()
        {
            return "Librarian ";
        }
        public override string ToString()
        {
            return " I am Librarian";
        }
    }

}

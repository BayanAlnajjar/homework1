using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.myclass
{
    public abstract class Person
    {
        public abstract string GetRole();
        public override string ToString()
        {
            return $"Role : {GetRole()}";
        }

    }

}

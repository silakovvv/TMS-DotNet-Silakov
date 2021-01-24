using System;
using System.Collections.Generic;
using System.Text;

namespace Silakov.Homework8
{
    class PersonException : Exception
    {
        public PersonException(string message) : base(message)
        { }
    }
}

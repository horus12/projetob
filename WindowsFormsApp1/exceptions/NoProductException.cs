using System;

namespace WindowsFormsApp1.exceptions
{
    public class NoProductException : Exception
    {
        public NoProductException(string message) : base(message) {} 
        public NoProductException(string message, Exception inner) : base(message, inner) {} 
    }
}

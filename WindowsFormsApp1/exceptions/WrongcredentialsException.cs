using System;

namespace WindowsFormsApp1.exceptions
{
    public class WrongcredentialsException : Exception
    {
        public WrongcredentialsException()
        {
        }

        public WrongcredentialsException(string message) : base(message)
        {
        }

        public WrongcredentialsException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
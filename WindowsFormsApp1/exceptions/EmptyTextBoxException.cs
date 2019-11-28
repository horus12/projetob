using System;

namespace WindowsFormsApp1.exceptions
{
    public class EmptyTextBoxException : Exception
    {
        public EmptyTextBoxException(string message) : base(message) {} 
        public EmptyTextBoxException(string message, Exception inner) : base(message, inner) {} 
    }
}

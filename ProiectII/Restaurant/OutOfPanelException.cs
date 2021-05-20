using System;

namespace ProiectII.Restaurant
{
    class OutOfPanelException : Exception
    {
        public OutOfPanelException(string message) : base(message)
        {

        }
    }
}

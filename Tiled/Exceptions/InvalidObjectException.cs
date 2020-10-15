using System;

namespace Hel.Tiled.Exceptions
{
    public class InvalidObjectException : Exception
    {
        public InvalidObjectException(string msg) : base(msg) {}

        public InvalidObjectException() {}

    }
}
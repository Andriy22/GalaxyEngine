using System;

namespace Application.Common.Exceptions
{
    public class AlreadyExistsException : Exception
    {
        public AlreadyExistsException(string name)
            : base($"Entity with name \"{name}\" already exists.") { }
    }
}

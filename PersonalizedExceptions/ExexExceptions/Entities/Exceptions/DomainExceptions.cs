using System;

namespace ExexExceptions.Entities.Exceptions
{
    public class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base(message){}
    }
}
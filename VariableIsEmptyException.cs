using System;

namespace GeGeek
{
    public class VariableIsEmptyException : ApplicationException
    {
        public VariableIsEmptyException(string msg) : base(msg)
        {
        }

        public VariableIsEmptyException()
        {
        }
    }
}
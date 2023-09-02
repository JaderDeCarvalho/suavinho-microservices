using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suavinho.Cellar.Commons.CellarExceptions
{
    public class IncorrectParamsException : CellarException
    {
        public IncorrectParamsException()
        {
        }

        public IncorrectParamsException(string? message)
            : base(message)
        {
        }

        public IncorrectParamsException(string? message, Exception? innerException)
            : base(message, innerException)
        {
        }
    }
}

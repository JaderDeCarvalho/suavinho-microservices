using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suavinho.Cellar.Commons.CellarExceptions
{
    public class CellarException : Exception
    {
        public CellarException()
        {
        }

        public CellarException(string? message)
            : base(message)
        {
        }

        public CellarException(string? message, Exception? innerException)
            : base(message, innerException)
        {
        }
    }
}

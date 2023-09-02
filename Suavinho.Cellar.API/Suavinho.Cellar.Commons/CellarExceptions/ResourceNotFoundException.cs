using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suavinho.Cellar.Commons.CellarExceptions
{
    public class ResourceNotFoundException : CellarException
    {
        public ResourceNotFoundException()
        {
        }

        public ResourceNotFoundException(string? message)
            : base(message)
        {
        }

        public ResourceNotFoundException(string? message, Exception? innerException)
            : base(message, innerException)
        {
        }
    }
}

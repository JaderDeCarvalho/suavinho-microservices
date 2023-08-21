using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suavinho.Cellar.Domain.Entity
{
    public class CellarWine
    {
        public int Id { get; set; }
        public Wine Wine { get; set; }
        public Cellar Cellar { get; set; }
        public int Quantity { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suavinho.Cellar.Domain.Entity
{
    public partial class CellarWine
    {
        public virtual int CellarId { get; set; }
        public virtual int WineId { get; set; }

        public virtual Cellar Cellar { get; set; }
        public virtual Wine Wine { get; set; }
    }
}

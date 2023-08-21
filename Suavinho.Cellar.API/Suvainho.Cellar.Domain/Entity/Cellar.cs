using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suavinho.Cellar.Domain.Entity
{
    public partial class Cellar
    {
        public virtual int Id { get; set; }

        [Required]
        public virtual string Name { get; set; }

        public virtual ICollection<CellarWine> CellarWine { get; set; }

    }
}

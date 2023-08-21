using Suavinho.Cellar.Commons.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suavinho.Cellar.Domain.Entity
{
    public partial class Wine
    {
        public virtual int Id { get; set; }

        [Required]
        public virtual string Name { get; set; }

        [Required]
        public virtual WineType Type { get; set; }
        
        public virtual int AlcoholContent { get; set; }

        public virtual int Vintage { get; set; }

        public virtual string Grapes { get; set; }

        public virtual bool IsBarrelAged { get; set; }

        [Required]
        public virtual int Quantity { get; set; }

        public virtual ICollection<CellarWine> CellarWine { get; set; }
    }
}

using Suavinho.Cellar.Commons.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suavinho.Cellar.Domain.Entity
{
    public class Wine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public WineType Type { get; set; }
        public int AlcoholContent { get; set; }
        public int Vintage { get; set; }
        public string Grapes { get; set; }
        public bool IsBarrelAged { get; set; }
    }
}

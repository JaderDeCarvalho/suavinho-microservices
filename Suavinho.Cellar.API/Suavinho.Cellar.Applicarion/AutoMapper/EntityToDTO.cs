using AutoMapper;
using Suavinho.Cellar.Application.DTO;
using CellarEntity = Suavinho.Cellar.Domain.Entity.Cellar;
using WineEntity = Suavinho.Cellar.Domain.Entity.Wine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suavinho.Cellar.Application.AutoMapper
{
    public class EntityToDTO : Profile
    {
        public EntityToDTO()
        {
            CreateMap<CellarEntity, CellarDTO>()
                .ForMember(x => x.Wines, y => y.MapFrom(w => w.CellarWine.Select(z => z.Wine)));

            CreateMap<WineEntity, WineDTO>()
                .ForMember(x => x.Cellars, y => y.MapFrom(w => w.CellarWine.Select(z => z.Cellar)));
        }
    }
}

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
    public class DTOToEntity : Profile
    {
        public DTOToEntity()
        {
            CreateMap<CellarDTO, CellarEntity>();
            CreateMap<WineDTO, WineEntity>();
        }
    }
}

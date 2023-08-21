using AutoMapper;
using Suavinho.Cellar.Application.Contracts.Inbound;
using Suavinho.Cellar.Application.DTO;
using CellarEntity = Suavinho.Cellar.Domain.Entity.Cellar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Suavinho.Cellar.Application.Contracts.Outbound;

namespace Suavinho.Cellar.Application.Services
{
    public class CellarService : ICellarService
    {
        private ICellarRepository _cellarRepository { get; }
        private IMapper _mapper { get; }

        public CellarService(ICellarRepository cellarRepository, IMapper mapper)
        {
            _cellarRepository = cellarRepository;
            _mapper = mapper;
        }

        public IEnumerable<CellarDTO> GetAll()
        {
            var cellarDtos = _mapper.Map<List<CellarDTO>>(_cellarRepository.GetAll());
            return cellarDtos;
        }

        public CellarDTO GetCellar(int cellarId)
        {
            var cellarDto = _mapper.Map<CellarDTO>(_cellarRepository.GetCellar(cellarId));
            return cellarDto;
        }

        public void CreateCellar(CellarDTO cellarDto)
        {
            _cellarRepository.CreateCellar(_mapper.Map<CellarEntity>(cellarDto));
        }

        public void UpdateCellar(CellarDTO cellarDto)
        {
            _cellarRepository.UpdateCellar(_mapper.Map<CellarEntity>(cellarDto));
        }

        public void DeleteCellar(int cellarId)
        {
            _cellarRepository.DeleteCellar(cellarId);
        }
    }
}

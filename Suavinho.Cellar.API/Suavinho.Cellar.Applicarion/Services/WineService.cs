using AutoMapper;
using Suavinho.Cellar.Applicarion.Contracts.Inbound;
using Suavinho.Cellar.Application.Contracts.Outbound;
using Suavinho.Cellar.Application.DTO;
using Suavinho.Cellar.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suavinho.Cellar.Applicarion.Services
{
    public class WineService : IWineService
    {
        private IWineRepository _wineRepository { get; }
        private IMapper _mapper { get; }

        public WineService(IWineRepository wineRepository, IMapper mapper)
        {
            _wineRepository = wineRepository;
            _mapper = mapper;
        }
        public IEnumerable<WineDTO> GetAll(int cellarId)
        {
            var wineDtos = _mapper.Map<List<WineDTO>>(_wineRepository.GetAll(cellarId));
            return wineDtos;
        }

        public WineDTO GetWine(int cellarId, int wineId)
        {
            var wineDto = _mapper.Map<WineDTO>(_wineRepository.GetWine(cellarId, wineId));
            return wineDto;
        }

        public void CreateWine(WineDTO wineDto, int cellarId)
        {
            _wineRepository.CreateWine(_mapper.Map<Wine>(wineDto), cellarId);
        }

        public void UpdateWine(WineDTO wineDto, int cellarId, int wineId)
        {
            _wineRepository.UpdateWine(_mapper.Map<Wine>(wineDto), cellarId, wineId);
        }

        public void DeleteCellar(bool isDeleteAll, int cellarId, int wineId)
        {
            _wineRepository.DeleteWine(isDeleteAll, cellarId, wineId);
        }
    }
}

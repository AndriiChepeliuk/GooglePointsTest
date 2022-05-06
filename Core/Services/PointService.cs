using AutoMapper;
using Core.DTO.PointDTO;
using Core.Entities.PointEntity;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class PointService : IPointService
    {
        private readonly IRepository<Point> _pointRepository;
        private readonly IMapper _mapper;

        public PointService(IRepository<Point> repository, IMapper mapper)
        {
            _pointRepository = repository;
            _mapper = mapper;
        }

        public async Task AddPoint(PointCreationDTO pointCreationDTO)
        {
            var userPoint = _mapper.Map<Point>(pointCreationDTO);
            await _pointRepository.InsertAsync(userPoint);
            await _pointRepository.SaveChangesAsync();
        }
    }
}

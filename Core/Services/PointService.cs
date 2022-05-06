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

        public PointService(IRepository<Point> repository)
        {
            _pointRepository = repository;
        }

        public async Task<PointCreationDTO> AddPoint(PointCreationDTO pointCreationDTO)
        {
            return await _pointRepository.InsertAsync(pointCreationDTO);
        }
    }
}

using AutoMapper;
using Core.DTO.PointDTO;
using Core.Entities.PointEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mappers
{
    public class CarMapper : Profile
    {
        public CarMapper()
        {
            CreateMap<PointCreationDTO, Point>();
        }
    }
}

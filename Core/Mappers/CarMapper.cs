using AutoMapper;
using Core.DTO.PointDTO;
using Core.Entities.PointEntity;

namespace Core.Mappers
{
    public class CarMapper : Profile
    {
        public CarMapper()
        {
            CreateMap<PointCreationDTO, Point>();
            CreateMap<Point, PointCreationDTO>();
        }
    }
}

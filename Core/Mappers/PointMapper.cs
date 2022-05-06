using AutoMapper;
using Core.DTO.PointDTO;
using Core.Entities.PointEntity;

namespace Core.Mappers
{
    public class PointMapper : Profile
    {
        public PointMapper()
        {
            CreateMap<PointCreationDTO, Point>();
            CreateMap<Point, PointCreationDTO>();
        }
    }
}

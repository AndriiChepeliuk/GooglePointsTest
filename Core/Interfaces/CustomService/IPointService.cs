using Core.DTO.PointDTO;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IPointService
    {
        Task AddPoint(PointCreationDTO pointCreationDTO);
    }
}

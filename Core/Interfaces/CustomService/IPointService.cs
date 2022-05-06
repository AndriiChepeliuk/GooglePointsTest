using Core.DTO.PointDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IPointService
    {
        Task AddPoint(PointCreationDTO pointCreationDTO);
    }
}

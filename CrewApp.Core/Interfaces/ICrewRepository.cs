using CrewApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrewApp.Domain.Interfaces
{
    public interface ICrewRepository
    {
        Task<IEnumerable<CrewEntity>> GetCrews();

        Task<CrewEntity> GetCrewsById(Guid id);
        Task<CrewEntity> AddCrew(CrewEntity entity);
        Task<CrewEntity> UpdateCrew(Guid crewId, CrewEntity entity);
        Task<bool> DeleteCrew(Guid crewId);

    }
}

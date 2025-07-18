using CrewApp.Domain.Entities;
using CrewApp.Domain.Interfaces;
using CrewApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CrewApp.Infrastructure.Repositories
{
    public class CrewRepository(AppDbContext dbContext) : ICrewRepository
    {
        public async Task<IEnumerable<CrewEntity>> GetCrews()
        {
            return await dbContext.Crews.ToListAsync();
        }

        public async Task<CrewEntity> GetCrewsById(Guid id)
        {
            return await dbContext.Crews.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<CrewEntity> AddCrew(CrewEntity entity)
        {
            entity.Id = Guid.NewGuid();
            dbContext.Crews.Add(entity);
            await  dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CrewEntity> UpdateCrew(Guid crewId,CrewEntity entity)
        {
            var crew = await dbContext.Crews.FirstOrDefaultAsync(x => x.Id == crewId);

            if (crew is not null) {
            
                crew.Name=entity.Name;
                crew.Email=entity.Email;
                crew.Phone=entity.Phone;
                
                await dbContext.SaveChangesAsync();
                return entity;
            }
            
            return entity;
        }

        public async Task<bool> DeleteCrew(Guid crewId)
        {

            var crew = await dbContext.Crews.FirstOrDefaultAsync(x => x.Id == crewId);

            if (crew is not null)
            {
                dbContext.Crews.Remove(crew);
                return await dbContext.SaveChangesAsync() > 0;
            }

            return false;
        }

    }
}

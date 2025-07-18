using CrewApp.Domain.Entities;
using CrewApp.Domain.Interfaces;
using MediatR;

namespace CrewApp.Application.Commands
{
    public record AddCrewCommand (CrewEntity Crew): IRequest<CrewEntity>;
    
    public class AddCrewCommandHanler(ICrewRepository crewRepository)
        : IRequestHandler<AddCrewCommand, CrewEntity>
    {
        public async Task<CrewEntity> Handle(AddCrewCommand request, CancellationToken cancellationToken)
        {
            return await crewRepository.AddCrew(request.Crew);
        }
    }
}

using CrewApp.Domain.Entities;
using CrewApp.Domain.Interfaces;
using MediatR;

namespace CrewApp.Application.Commands
{
    public record UpdateCrewCommand(Guid Id, CrewEntity Crew) : IRequest<CrewEntity>;

    public class UpdateCrewCommandHandler(ICrewRepository crewRepository)
        : IRequestHandler<UpdateCrewCommand, CrewEntity>
    {
        public async Task<CrewEntity> Handle(UpdateCrewCommand request, CancellationToken cancellationToken)
        {
           return await crewRepository.UpdateCrew(request.Id, request.Crew);  
        }
    }
}

using CrewApp.Domain.Interfaces;
using MediatR;

namespace CrewApp.Application.Commands
{
    public record DeleteCrewCommand(Guid Id) :IRequest<bool>;

    public class DeleteCrewCommandHandler(ICrewRepository crewRepository)
        : IRequestHandler<DeleteCrewCommand, bool>
    {
        public async Task<bool> Handle(DeleteCrewCommand request, CancellationToken cancellationToken)
        {
            return await crewRepository.DeleteCrew(request.Id);
        }
    }
}

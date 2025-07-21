using CrewApp.Domain.Entities;
using CrewApp.Domain.Interfaces;
using MediatR;

namespace CrewApp.Application.Queries
{
    public record GetCrewByIdQuery(Guid Id): IRequest<CrewEntity>;

    public class GetCrewByIdQueryHandler(ICrewRepository crewRepository)
        : IRequestHandler<GetCrewByIdQuery, CrewEntity>
    {
        public async Task<CrewEntity> Handle(GetCrewByIdQuery request, CancellationToken cancellationToken)
        {
            return await crewRepository.GetCrewsById(request.Id);
        }
    }
}

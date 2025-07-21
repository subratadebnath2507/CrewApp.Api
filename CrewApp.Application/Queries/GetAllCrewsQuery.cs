using CrewApp.Domain.Entities;
using CrewApp.Domain.Interfaces;
using MediatR;

namespace CrewApp.Application.Queries
{
    public record GetAllCrewsQuery : IRequest<IEnumerable<CrewEntity>>;

    public class GetAllCrewsQueryHandler(ICrewRepository crewRepository)
        : IRequestHandler<GetAllCrewsQuery,IEnumerable<CrewEntity>>
    {
        public async Task<IEnumerable<CrewEntity>> Handle(GetAllCrewsQuery request, CancellationToken cancellationToken)
        {
            return await crewRepository.GetCrews();
        }

    }
}

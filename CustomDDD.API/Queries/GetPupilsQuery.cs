using CustomDDD.Infrastructure.Dtos;
using MediatR;

namespace CustomDDD.API.Queries
{
    public record GetPupilsQuery : IRequest<IEnumerable<PupilDto>>;
}

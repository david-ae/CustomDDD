using CustomDDD.Infrastructure.Dtos;
using MediatR;

namespace CustomDDD.Application.Queries
{
    public record GetPupilsQuery : IRequest<IEnumerable<PupilDto>>;
}

using MediatR;

namespace CustomDDD.API.Queries
{
    public record GetPupilsQuery : IRequest<IEnumerable<Pupil>>;
}

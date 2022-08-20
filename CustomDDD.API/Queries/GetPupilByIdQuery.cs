using CustomDDD.Infrastructure.Dtos;
using MediatR;

namespace CustomDDD.API.Queries
{
    public record GetPupilByIdQuery(int Id) : IRequest<PupilDto>;
}

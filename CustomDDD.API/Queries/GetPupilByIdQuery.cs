using CustomDDD.Infrastructure.Dtos;
using MediatR;

namespace CustomDDD.Application.Queries
{
    public record GetPupilByIdQuery(int Id) : IRequest<PupilDto>;
}

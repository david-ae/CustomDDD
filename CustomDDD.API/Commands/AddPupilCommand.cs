using CustomDDD.Infrastructure.Dtos;
using MediatR;

namespace CustomDDD.API.Commands
{
    public record AddPupilCommand(PupilDto pupil) : IRequest<PupilDto>;
}

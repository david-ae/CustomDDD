using CustomDDD.Infrastructure.Dtos;
using MediatR;

namespace CustomDDD.Application.Commands
{
    public record AddPupilCommand(PupilDto pupil) : IRequest<PupilDto>;
}

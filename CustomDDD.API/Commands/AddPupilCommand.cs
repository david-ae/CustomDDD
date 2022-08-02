using MediatR;

namespace CustomDDD.API.Commands
{
    public record AddPupilCommand(Pupil pupil) : IRequest<Pupil>;
}

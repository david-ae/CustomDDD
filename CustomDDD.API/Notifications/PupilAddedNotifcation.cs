using CustomDDD.Domain.Entities;
using MediatR;

namespace CustomDDD.Application.Notifications
{
    public record PupilAddedNotifcation(Pupil pupil) : INotification;
}

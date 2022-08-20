using Domain;
using MediatR;

namespace CustomDDD.API.Notifications
{
    public record PupilAddedNotifcation(Pupil pupil) : INotification;
}

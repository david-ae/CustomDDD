using CustomDDD.Application.Notifications;
using MediatR;

namespace CustomDDD.Application.Handlers
{
    public class EmailHandler : INotificationHandler<PupilAddedNotifcation>
    {
        private readonly FakePupilStore _fakePupilStore;
        public EmailHandler(FakePupilStore fakePupilStore) => _fakePupilStore = fakePupilStore;
        public async Task Handle(PupilAddedNotifcation notification, CancellationToken cancellationToken)
        {
            // await _fakePupilStore.EventOccurred(notification.pupil, "Email Sent");
            await Task.CompletedTask;
        }
    }
}

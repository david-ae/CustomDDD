using CustomDDD.API.Notifications;
using MediatR;

namespace CustomDDD.API.Handlers
{
    public class CacheInvalidationHandler : INotificationHandler<PupilAddedNotifcation>
    {
        private readonly FakePupilStore _fakePupilStore;
        public CacheInvalidationHandler(FakePupilStore fakePupilStore) => _fakePupilStore = fakePupilStore;
        public async Task Handle(PupilAddedNotifcation notification, CancellationToken cancellationToken)
        {
            // await _fakePupilStore.EventOccurred(notification.pupil, "Cache Invalidated");
            await Task.CompletedTask;
        }
    }
}

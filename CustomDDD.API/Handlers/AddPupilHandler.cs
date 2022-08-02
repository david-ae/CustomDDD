using CustomDDD.API.Commands;
using MediatR;

namespace CustomDDD.API.Handlers
{
    public class AddPupilHandler : IRequestHandler<AddPupilCommand, Pupil>
    {
        private readonly FakePupilStore _fakePupilStore;

        public AddPupilHandler(FakePupilStore fakePupilStore) => _fakePupilStore = fakePupilStore;
        public async Task<Pupil> Handle(AddPupilCommand request, CancellationToken cancellationToken)
        {
            await _fakePupilStore.AddPupil(request.pupil);
            return request.pupil;
        }
    }
}

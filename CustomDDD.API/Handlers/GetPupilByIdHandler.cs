using CustomDDD.API.Queries;
using MediatR;

namespace CustomDDD.API.Handlers
{
    public class GetPupilByIdHandler : IRequestHandler<GetPupilByIdQuery, Pupil>
    {
        private readonly FakePupilStore _fakePupilStore;

        public GetPupilByIdHandler(FakePupilStore fakePupilStore) => _fakePupilStore = fakePupilStore;
        public async Task<Pupil> Handle(GetPupilByIdQuery request, CancellationToken cancellationToken)
        {
            return await _fakePupilStore.GetPupilById(request.Id);
        }
    }
}

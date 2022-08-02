using CustomDDD.API.Queries;
using MediatR;

namespace CustomDDD.API.Handlers
{
    public class GetPupilsHandler : IRequestHandler<GetPupilsQuery, IEnumerable<Pupil>>
    {
        private readonly FakePupilStore _fakePupilStore;

        public GetPupilsHandler(FakePupilStore fakePupilStore) => _fakePupilStore = fakePupilStore;
        public async Task<IEnumerable<Pupil>> Handle(GetPupilsQuery request, CancellationToken cancellationToken)
        {
            return await _fakePupilStore.GetAllPupils();
        }
    }
}

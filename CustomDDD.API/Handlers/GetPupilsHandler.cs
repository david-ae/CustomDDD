using AutoMapper;
using CustomDDD.API.Queries;
using CustomDDD.Infrastructure.Dtos;
using MediatR;

namespace CustomDDD.API.Handlers
{
    public class GetPupilsHandler : IRequestHandler<GetPupilsQuery, IEnumerable<PupilDto>>
    {
        private readonly FakePupilStore _fakePupilStore;
        private readonly IMapper _mapper;

        public GetPupilsHandler(FakePupilStore fakePupilStore, IMapper mapper)
        {
            _fakePupilStore = fakePupilStore;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PupilDto>> Handle(GetPupilsQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<IEnumerable<PupilDto>>
                (await _fakePupilStore.GetAllPupils());
        }
    }
}

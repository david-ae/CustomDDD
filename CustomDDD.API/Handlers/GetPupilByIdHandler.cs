using AutoMapper;
using CustomDDD.API.Queries;
using CustomDDD.Infrastructure.Dtos;
using Domain;
using MediatR;

namespace CustomDDD.API.Handlers
{
    public class GetPupilByIdHandler : IRequestHandler<GetPupilByIdQuery, PupilDto>
    {
        private readonly FakePupilStore _fakePupilStore;
        private readonly IMapper _mapper;

        public GetPupilByIdHandler(FakePupilStore fakePupilStore, IMapper mapper)
        {
            _fakePupilStore = fakePupilStore;
            _mapper = mapper;
        }
        public async Task<PupilDto> Handle(GetPupilByIdQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<PupilDto>(await _fakePupilStore.GetPupilById(request.Id));
        }
    }
}

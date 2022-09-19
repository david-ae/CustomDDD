using AutoMapper;
using CustomDDD.Application.Queries;
using CustomDDD.Infrastructure.Dtos;
using CustomDDD.Domain;
using MediatR;

namespace CustomDDD.Application.Handlers
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

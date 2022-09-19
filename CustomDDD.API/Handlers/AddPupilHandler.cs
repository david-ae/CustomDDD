using AutoMapper;
using CustomDDD.Application.Commands;
using CustomDDD.Domain.Entities;
using CustomDDD.Infrastructure.Dtos;
using MediatR;

namespace CustomDDD.Application.Handlers
{
    public class AddPupilHandler : IRequestHandler<AddPupilCommand, PupilDto>
    {
        private readonly FakePupilStore _fakePupilStore;
        private readonly IMapper _mapper;

        public AddPupilHandler(FakePupilStore fakePupilStore, IMapper mapper) 
        {
            _fakePupilStore = fakePupilStore;
            _mapper = mapper;
        }
        
        public async Task<PupilDto> Handle(AddPupilCommand request, CancellationToken cancellationToken)
        {
            var newPupil = this._mapper.Map<Pupil>(request.pupil);
            
            await _fakePupilStore.AddPupil(newPupil);
            return request.pupil;
        }
    }
}

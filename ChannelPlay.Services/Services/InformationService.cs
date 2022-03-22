using AutoMapper;
using ChannelPlay.Entities.Entities;
using ChannelPlay.Repository.Interfaces;
using ChannelPlay.Services.Interfaces;
using ChannelPlay.Services.ViewModels;

namespace ChannelPlay.Services.Services
{
    public class InformationService : IInformationService
    {
        private readonly IInformationRepository _informationRepository;
        private IMapper _mapper;
        public InformationService(IInformationRepository informationRepository, IMapper mapper)
        {
            _informationRepository = informationRepository;
            _mapper = mapper;
        }
        public bool CreateInformation(InformationVM information)
        {
            
        }

        public IEnumerable<InformationVM> GetAllInformation()
        {
            return _mapper.Map<IEnumerable<InformationVM>>(_informationRepository.GetAllInformation());
        }

        public IEnumerable<InformationVM> GetChannelInformation(int channelID)
        {
            return _mapper.Map<IEnumerable<InformationVM>>(_informationRepository.GetChannelInformation(channelID));
        }
    }
}

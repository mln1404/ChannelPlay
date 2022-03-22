using AutoMapper;
using ChannelPlay.Entities.Entities;
using ChannelPlay.Repository.Interfaces;
using ChannelPlay.Services.Interfaces;

namespace ChannelPlay.Services.Services
{
    public class ChannelService : IChannelService
    {
        private readonly IChannelRepository _channelRepository;
        private IMapper _mapper;
        public ChannelService(IChannelRepository channelRepository, IMapper mapper)
        {
            _channelRepository = channelRepository;
            _mapper = mapper;
        }

        public void AssignInformation(TblChannel oldChannelInfo, int[] newInfoIDs)
        {
            IEnumerable<int> oldInfoIDs = oldChannelInfo.Informations
                                .SkipWhile(x => newInfoIDs.Contains(x.ID)).Select(x => x.ID);
            _channelRepository.AssignInformation(oldChannelInfo.ID, oldInfoIDs, newInfoIDs);
        }

        public void CreateChannel(TblChannel channel)
        {
            _channelRepository.CreateChannel(channel);
        }

        public TblChannel Get(int ID)
        {
            return _channelRepository.Get(ID);
        }

        public IEnumerable<TblChannel> GetAll()
        {
            return _channelRepository.GetAll();
        }
    }
}

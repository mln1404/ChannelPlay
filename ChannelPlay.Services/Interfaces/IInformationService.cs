using ChannelPlay.Services.ViewModels;

namespace ChannelPlay.Services.Interfaces
{
    public interface IInformationService
    {
        IEnumerable<InformationVM> GetChannelInformation(int channelID);
        bool CreateInformation(InformationVM information);
        IEnumerable<InformationVM> GetAllInformation();
    }
}

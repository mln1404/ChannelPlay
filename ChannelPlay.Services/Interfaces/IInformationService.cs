using ChannelPlay.Services.ViewModels;

namespace ChannelPlay.Services.Interfaces
{
    public interface IInformationService
    {
        IEnumerable<InformationVM> GetChannelInformation(int channelID, DateTime? from, DateTime? to);
        void CreateInformation(InformationVM information);
        IEnumerable<InformationVM> GetAllInformation();
    }
}

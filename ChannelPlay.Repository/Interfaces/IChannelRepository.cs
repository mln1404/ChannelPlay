using ChannelPlay.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelPlay.Repository.Interfaces
{
    public interface IChannelRepository
    {
        IEnumerable<TblChannel> GetAll();
        TblChannel Get(int ID);
        void CreateChannel(TblChannel channel);
        void AssignInformation(int channelID, IEnumerable<int> removeInformationIDs, int[] addInformationIDs);
    }
}

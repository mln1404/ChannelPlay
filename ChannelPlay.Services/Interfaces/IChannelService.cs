using ChannelPlay.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelPlay.Services.Interfaces
{
    public interface IChannelService
    {
        IEnumerable<TblChannel> GetAll();
        TblChannel Get(int ID);
        void CreateChannel(TblChannel channel);
        void AssignInformation(TblChannel oldChannelInfo, int[] newInfoIDs);
    }
}

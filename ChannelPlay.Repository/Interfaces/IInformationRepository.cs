﻿using ChannelPlay.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelPlay.Repository.Interfaces
{
    public interface IInformationRepository
    {
        IEnumerable<TblInformation> GetChannelInformation(int channelID, DateTime? from, DateTime? to);
        void CreateInformation(TblInformation information);
        IEnumerable<TblInformation> GetAllInformation();
    }
}

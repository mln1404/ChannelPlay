using AutoMapper;
using ChannelPlay.Entities.Entities;
using ChannelPlay.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelPlay.Services
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config => {
                config.CreateMap<InformationVM, TblInformation>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}

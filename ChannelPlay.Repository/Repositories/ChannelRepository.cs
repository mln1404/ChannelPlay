using ChannelPlay.Entities.Entities;
using ChannelPlay.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelPlay.Repository.Repositories
{
    public class ChannelRepository : IChannelRepository
    {

        private readonly DataContext _context;
        public ChannelRepository(DataContext context)
        {
            _context = context;
        }

        public async void AssignInformation(int channelID, IEnumerable<int> removeInformationIDs, int[] addInformationIDs)
        {
            using (var tx = _context.Database.BeginTransaction())
            {
                try
                {
                    string removeIDs = string.Join(",", removeInformationIDs);
                    var task1 = _context.Database.ExecuteSqlRawAsync($"UPDATE TblInformation SET ChannelID = NULL WHERE ID IN ({removeIDs})");

                    string addIDs = string.Join(",", addInformationIDs);
                    var task2 = _context.Database.ExecuteSqlRawAsync($"UPDATE TblInformation SET ChannelID = {channelID} WHERE ID IN ({addIDs})");

                    await task1;
                    await task2;
                    tx.Commit();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        public void CreateChannel(TblChannel channel)
        {
            try
            {
                _context.TblChannel.Add(channel);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public TblChannel Get(int ID)
        {
            return _context.TblChannel.FirstOrDefault(c => c.ID == ID);
        }

        public IEnumerable<TblChannel> GetAll()
        {
            return _context.TblChannel.AsEnumerable();
        }
    }
}

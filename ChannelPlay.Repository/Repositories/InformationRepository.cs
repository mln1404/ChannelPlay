using ChannelPlay.Entities.Entities;
using ChannelPlay.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelPlay.Repository.Repositories
{
    public class InformationRepository : IInformationRepository
    {
        private readonly DataContext _context;
        public InformationRepository(DataContext context)
        {
            _context = context;
        }

        public void CreateInformation(TblInformation information)
        {
            try
            {
                _context.TblInformation.Add(information);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IEnumerable<TblInformation> GetAllInformation()
        {
            return _context.TblInformation.AsEnumerable();
        }

        public IEnumerable<TblInformation> GetChannelInformation(int channelID)
        {
            return _context.TblInformation.Where(i => i.ChannelID == channelID).AsEnumerable();
        }
        
    }
}

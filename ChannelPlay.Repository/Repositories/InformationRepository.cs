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

        public IEnumerable<TblInformation> GetChannelInformation(int channelID, DateTime? from, DateTime? to)
        {
            string query = $"SELECT * FROM TblInformation WHERE ChannelID = {channelID} AND (ActiveFrom IS NOT NULL OR ActiveTo IS NOT NULL)";
            if (from.HasValue)
                query += $" AND (ActiveFrom IS NULL OR ActiveFrom >= '{from.Value}')";
            if (to.HasValue)
                query += $" AND (ActiveTo IS NULL OR ActiveTo <= '{to.Value}')";
            // Preferring to go Raw since SQL injection won't happen because the parameters are dates and an integer. Makes the query more flexible and efficient also.
            return _context.TblInformation.FromSqlRaw(query).AsEnumerable();
        }
        
    }
}

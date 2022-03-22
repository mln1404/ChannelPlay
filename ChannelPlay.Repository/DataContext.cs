using ChannelPlay.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelPlay.Repository
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DbContext> options) : base(options)
        {

        }
        public DbSet<TblChannel> TblChannel { get; set; }
        public DbSet<TblInformation> TblInformation { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblInformation>().ToTable("TblInformation");
            modelBuilder.Entity<TblChannel>().ToTable("TblChannel");
        }
    }
}

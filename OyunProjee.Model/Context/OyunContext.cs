using Microsoft.EntityFrameworkCore;
using OyunProjee.Model.Entities;
using OyunProjee.Model.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunProjee.Model.Context
{
    public class OyunContext: DbContext
    {
        public OyunContext(DbContextOptions<OyunContext> options):base(options)
        {
            
        }
        public DbSet<Oyun> Oyuns { get; set; }
        public DbSet<Karakter> Karakters{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OyunMaps());
            modelBuilder.ApplyConfiguration(new KarakterMap());
        }
    }
}

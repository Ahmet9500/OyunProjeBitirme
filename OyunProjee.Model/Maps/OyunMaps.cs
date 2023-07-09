using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OyunProjee.Core.Map;
using OyunProjee.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunProjee.Model.Maps
{
   public class OyunMaps : OyunProjeeMap<Oyun>
    {
        public override void Configure(EntityTypeBuilder<Oyun> builder)
        {
            builder.Property(x => x.OyunAdı).IsRequired().HasMaxLength(50);
            builder.Property(x=>x.KurulusTarihi).IsRequired(false).HasMaxLength(50);
            builder.Property(x=>x.Türü).IsRequired().HasMaxLength(50);
            builder.Property(x=>x.Fiyat).IsRequired().HasMaxLength(50);
        }
    }
}

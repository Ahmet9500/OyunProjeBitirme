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
    public class KarakterMap : OyunProjeeMap<Karakter>
    {
        public override void Configure(EntityTypeBuilder<Karakter> builder)
        {
            builder.Property(x => x.OyunAdı).IsRequired().HasMaxLength(50);
            builder.Property(x=>x.OyuncuAdı).IsRequired().HasMaxLength(50);
            builder.Property(x=>x.Vurus).IsRequired().HasMaxLength(50);
            builder.Property(x=>x.Gucu).IsRequired().HasMaxLength(50);
            builder.Property(x => x.FızıkselOzellik).IsRequired().HasMaxLength(50);

        }
    }
}

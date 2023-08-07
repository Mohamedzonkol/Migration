using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Migrations.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations.Data.Config
{
    public class OfficeConfig : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.OfficeName).HasColumnType("VARCHAR")
                    .HasMaxLength(255).
                    IsRequired();
            builder.Property(x => x.OfficeLocation).HasColumnType("VARCHAR")
                   .HasMaxLength(50).
                   IsRequired();
            builder.ToTable("Offices");
          //builder.HasData(load_Ofiicess());
        }
      
    }
}

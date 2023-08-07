using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Migrations.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Migrations.Data.Config
{
    public class ScheduleConfig : IEntityTypeConfiguration<Schedule>

    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Title).HasColumnType("VARCHAR")
               .HasMaxLength(255)
                .IsRequired();
            builder.ToTable("Schedules");
     //     builder.HasData(load_Schedule());
        }

    }
}

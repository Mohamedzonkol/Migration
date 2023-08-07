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
    public class SectionConfig : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.SectioNname).HasColumnType("VARCHAR")
                    .HasMaxLength(255).
                    IsRequired();


            builder.OwnsOne(x => x.TimeSlot, ts =>
            {
                ts.Property(p => p.StartTime).HasColumnType("time").HasColumnName("StartTime");
                ts.Property(p => p.EndTime).HasColumnType("time").HasColumnName("EndTime");
            });
            builder.HasOne(x => x.Courses)
                .WithMany(x => x.Sections)
                .HasForeignKey(x => x.CourseId)
                .IsRequired();
            builder.HasOne(x => x.Instructors)
               .WithMany(x => x.Sections)
               .HasForeignKey(x => x.InstructorId)
               .IsRequired(false);
            builder.HasOne(x => x.Schedules)
               .WithMany(x => x.Sections)
               .HasForeignKey(x => x.ScheduleId)
               .IsRequired();
            builder.HasMany(x => x.Students)
               .WithMany(x => x.Sections)
               .UsingEntity<Enrollment>();




            builder.ToTable("Sections");

          //     builder.HasData(LoadSections());
        }

        

    }
}

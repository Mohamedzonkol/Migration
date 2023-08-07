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
    public class CourseConfig : IEntityTypeConfiguration<Course>

    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Name).HasColumnType("VARCHAR")
                    .HasMaxLength(255).
                    IsRequired();
            builder.Property(x => x.Prise).HasPrecision(15, 2).IsRequired();
            builder.ToTable("Courses");
            
        //  builder.HasData(load_courses());

        }

       
    }
}

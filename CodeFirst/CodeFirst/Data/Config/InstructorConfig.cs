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
    public class InstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Name).HasColumnType("VARCHAR")
                    .HasMaxLength(255).
                    IsRequired();


            builder.HasOne(x => x.Offices)
                .WithOne(x => x.Instructors)
                .HasForeignKey<Instructor>(x => x.OfficeId)
                .IsRequired(false);
            builder.ToTable("Instructors");
//          builder.HasData(load_Instructors());


        }
       
    }
}

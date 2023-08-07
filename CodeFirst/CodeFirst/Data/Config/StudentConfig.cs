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
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedNever();
            builder.Property(x => x.Name).HasColumnType("VARCHAR")
                .HasMaxLength(255).IsRequired();
            builder.UseTptMappingStrategy();
            builder.ToTable("Students");
        //  builder.HasData(LoadStudents());
        }

   
        }
    }


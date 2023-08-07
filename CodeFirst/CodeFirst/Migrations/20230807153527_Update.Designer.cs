﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Migrationss.Data;

#nullable disable

namespace CodeFirst.Migrations
{
    [DbContext(typeof(AppDbcontext))]
    [Migration("20230807153527_Update")]
    partial class Update
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Migrations.Entites.Course", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<decimal>("Prise")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)");

                    b.HasKey("Id");

                    b.ToTable("Courses", (string)null);
                });

            modelBuilder.Entity("Migrations.Entites.Enrollment", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "SectionId");

                    b.HasIndex("SectionId");

                    b.ToTable("Enrollments", (string)null);
                });

            modelBuilder.Entity("Migrations.Entites.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId")
                        .IsUnique();

                    b.ToTable("Instructors", (string)null);
                });

            modelBuilder.Entity("Migrations.Entites.Office", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("OfficeLocation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("OfficeName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Offices", (string)null);
                });

            modelBuilder.Entity("Migrations.Entites.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("FRI")
                        .HasColumnType("bit");

                    b.Property<bool>("MON")
                        .HasColumnType("bit");

                    b.Property<bool>("SAT")
                        .HasColumnType("bit");

                    b.Property<bool>("SUN")
                        .HasColumnType("bit");

                    b.Property<bool>("THU")
                        .HasColumnType("bit");

                    b.Property<bool>("TUE")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<bool>("WED")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Schedules", (string)null);
                });

            modelBuilder.Entity("Migrations.Entites.Section", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<string>("SectioNname")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstructorId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Sections", (string)null);
                });

            modelBuilder.Entity("Migrations.Entites.Student", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Students", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Migrations.Entites.Coobrate", b =>
                {
                    b.HasBaseType("Migrations.Entites.Student");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Coobrates");
                });

            modelBuilder.Entity("Migrations.Entites.Individual", b =>
                {
                    b.HasBaseType("Migrations.Entites.Student");

                    b.Property<bool>("IsIntern")
                        .HasColumnType("bit");

                    b.Property<string>("University")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearOfGraduation")
                        .HasColumnType("int");

                    b.ToTable("Individuals");
                });

            modelBuilder.Entity("Migrations.Entites.Enrollment", b =>
                {
                    b.HasOne("Migrations.Entites.Section", "Sections")
                        .WithMany()
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Migrations.Entites.Student", "Students")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sections");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Migrations.Entites.Instructor", b =>
                {
                    b.HasOne("Migrations.Entites.Office", "Offices")
                        .WithOne("Instructors")
                        .HasForeignKey("Migrations.Entites.Instructor", "OfficeId");

                    b.Navigation("Offices");
                });

            modelBuilder.Entity("Migrations.Entites.Section", b =>
                {
                    b.HasOne("Migrations.Entites.Course", "Courses")
                        .WithMany("Sections")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Migrations.Entites.Instructor", "Instructors")
                        .WithMany("Sections")
                        .HasForeignKey("InstructorId");

                    b.HasOne("Migrations.Entites.Schedule", "Schedules")
                        .WithMany("Sections")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Migrations.Entites.TimeSlot", "TimeSlot", b1 =>
                        {
                            b1.Property<int>("SectionId")
                                .HasColumnType("int");

                            b1.Property<TimeSpan>("EndTime")
                                .HasColumnType("time")
                                .HasColumnName("EndTime");

                            b1.Property<TimeSpan>("StartTime")
                                .HasColumnType("time")
                                .HasColumnName("StartTime");

                            b1.HasKey("SectionId");

                            b1.ToTable("Sections");

                            b1.WithOwner()
                                .HasForeignKey("SectionId");
                        });

                    b.Navigation("Courses");

                    b.Navigation("Instructors");

                    b.Navigation("Schedules");

                    b.Navigation("TimeSlot");
                });

            modelBuilder.Entity("Migrations.Entites.Coobrate", b =>
                {
                    b.HasOne("Migrations.Entites.Student", null)
                        .WithOne()
                        .HasForeignKey("Migrations.Entites.Coobrate", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Migrations.Entites.Individual", b =>
                {
                    b.HasOne("Migrations.Entites.Student", null)
                        .WithOne()
                        .HasForeignKey("Migrations.Entites.Individual", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Migrations.Entites.Course", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("Migrations.Entites.Instructor", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("Migrations.Entites.Office", b =>
                {
                    b.Navigation("Instructors");
                });

            modelBuilder.Entity("Migrations.Entites.Schedule", b =>
                {
                    b.Navigation("Sections");
                });
#pragma warning restore 612, 618
        }
    }
}

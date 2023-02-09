﻿// <auto-generated />
using System;
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(MusicSchoolContext))]
    [Migration("20230205220120_v2")]
    partial class v2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("DataAccess.Entities.Classroom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Classrooms");
                });

            modelBuilder.Entity("DataAccess.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("DataAccess.Entities.Instrument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StockAmount")
                        .HasColumnType("int");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Instruments");
                });

            modelBuilder.Entity("DataAccess.Entities.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsOnline")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("DataAccess.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("DataAccess.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ParentName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ParentSurname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TakenLessonCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("DataAccess.Entities.StudentContact", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("StudentId");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("StudentContacts");
                });

            modelBuilder.Entity("DataAccess.Entities.StudentTeacherLessonClassroom", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("TeacherId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("LessonId")
                        .HasColumnType("int")
                        .HasColumnOrder(3);

                    b.Property<int>("ClassroomId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.HasKey("StudentId", "TeacherId", "LessonId", "ClassroomId");

                    b.HasIndex("ClassroomId");

                    b.HasIndex("LessonId");

                    b.HasIndex("TeacherId");

                    b.ToTable("StudentTeacherLessonClassrooms");
                });

            modelBuilder.Entity("DataAccess.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<int>("InstrumentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("InstrumentId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("DataAccess.Entities.TeacherContact", b =>
                {
                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.HasKey("TeacherId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("TeacherContacts");
                });

            modelBuilder.Entity("DataAccess.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataAccess.Entities.City", b =>
                {
                    b.HasOne("DataAccess.Entities.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("DataAccess.Entities.StudentContact", b =>
                {
                    b.HasOne("DataAccess.Entities.City", "City")
                        .WithMany("StudentContacts")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("DataAccess.Entities.Country", "Country")
                        .WithMany("StudentContacts")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("DataAccess.Entities.Student", "Student")
                        .WithOne("StudentContact")
                        .HasForeignKey("DataAccess.Entities.StudentContact", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Country");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("DataAccess.Entities.StudentTeacherLessonClassroom", b =>
                {
                    b.HasOne("DataAccess.Entities.Classroom", "Classroom")
                        .WithMany("STLCs")
                        .HasForeignKey("ClassroomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.Lesson", "Lesson")
                        .WithMany("STLCs")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.Student", "Student")
                        .WithMany("STLCs")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.Teacher", "Teacher")
                        .WithMany("STLCs")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classroom");

                    b.Navigation("Lesson");

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("DataAccess.Entities.Teacher", b =>
                {
                    b.HasOne("DataAccess.Entities.Instrument", "Instrument")
                        .WithMany("Teachers")
                        .HasForeignKey("InstrumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instrument");
                });

            modelBuilder.Entity("DataAccess.Entities.TeacherContact", b =>
                {
                    b.HasOne("DataAccess.Entities.Teacher", "Teacher")
                        .WithOne("TeacherContact")
                        .HasForeignKey("DataAccess.Entities.TeacherContact", "TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("DataAccess.Entities.User", b =>
                {
                    b.HasOne("DataAccess.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("DataAccess.Entities.City", b =>
                {
                    b.Navigation("StudentContacts");
                });

            modelBuilder.Entity("DataAccess.Entities.Classroom", b =>
                {
                    b.Navigation("STLCs");
                });

            modelBuilder.Entity("DataAccess.Entities.Country", b =>
                {
                    b.Navigation("Cities");

                    b.Navigation("StudentContacts");
                });

            modelBuilder.Entity("DataAccess.Entities.Instrument", b =>
                {
                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("DataAccess.Entities.Lesson", b =>
                {
                    b.Navigation("STLCs");
                });

            modelBuilder.Entity("DataAccess.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("DataAccess.Entities.Student", b =>
                {
                    b.Navigation("STLCs");

                    b.Navigation("StudentContact");
                });

            modelBuilder.Entity("DataAccess.Entities.Teacher", b =>
                {
                    b.Navigation("STLCs");

                    b.Navigation("TeacherContact");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyApp.Models;

namespace MyApp.Migrations
{
    [DbContext(typeof(MyAppContext))]
    [Migration("20190402192019_DeskOfNewsInitial")]
    partial class DeskOfNewsInitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyApp.Models.Attendance", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data");

                    b.Property<string>("Lesson");

                    b.Property<int>("Presense");

                    b.Property<DateTime>("TimeOfDelay");

                    b.HasKey("ID");

                    b.ToTable("Attendance");
                });

            modelBuilder.Entity("MyApp.Models.DeskOfNew", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HeaderOfNews");

                    b.Property<string>("TextOfNews");

                    b.HasKey("ID");

                    b.ToTable("DeskOfNew");
                });

            modelBuilder.Entity("MyApp.Models.GroupTable", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameOfGroup");

                    b.Property<string>("Speciality");

                    b.HasKey("ID");

                    b.ToTable("GroupTable");
                });

            modelBuilder.Entity("MyApp.Models.KindOfWork", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameOfWork");

                    b.HasKey("ID");

                    b.ToTable("KindOfWork");
                });

            modelBuilder.Entity("MyApp.Models.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Genre");

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("MyApp.Models.PassOfWork", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CallOfDiscipline");

                    b.Property<int>("NumberOfWork");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("TypeOfWork");

                    b.HasKey("ID");

                    b.ToTable("PassOfWork");
                });

            modelBuilder.Entity("MyApp.Models.StudentInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress");

                    b.Property<DateTime>("BirthDate");

                    b.Property<DateTime>("EnterDate");

                    b.Property<string>("Group");

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.Property<string>("Notes");

                    b.Property<string>("OrderNumber");

                    b.Property<string>("ParentsNumber");

                    b.Property<string>("Patronymic");

                    b.HasKey("ID");

                    b.ToTable("StudentInfo");
                });

            modelBuilder.Entity("MyApp.Models.TableOfSpeciality", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameOfSpeciality");

                    b.HasKey("ID");

                    b.ToTable("TableOfSpeciality");
                });
#pragma warning restore 612, 618
        }
    }
}

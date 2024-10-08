﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleWebApp.Data;

#nullable disable

namespace SimpleWebApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SimpleWebApp.Data.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Person_Info");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 William Street, Melbourne VIC 6969, Australia",
                            Age = "50",
                            BirthDate = new DateOnly(1950, 1, 1),
                            Name = "Antony Fetucini",
                            Phone = "012345678"
                        },
                        new
                        {
                            Id = 2,
                            Address = "123 William Street, Melbourne VIC 6969, Australia",
                            Age = "49",
                            BirthDate = new DateOnly(1960, 2, 1),
                            Name = "Felipa Fetucini",
                            Phone = "012345678"
                        },
                        new
                        {
                            Id = 3,
                            Address = "123 William Street, Melbourne VIC 6969, Australia",
                            Age = "23",
                            BirthDate = new DateOnly(1990, 9, 30),
                            Name = "Androzy Fetucini",
                            Phone = "012345678"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

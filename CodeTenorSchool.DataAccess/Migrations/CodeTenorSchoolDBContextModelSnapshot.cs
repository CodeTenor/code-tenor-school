﻿// <auto-generated />
using System;
using CodeTenorSchool.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeTenorSchool.DataAccess.Migrations
{
    [DbContext(typeof(CodeTenorSchoolDBContext))]
    partial class CodeTenorSchoolDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CodeTenorSchool.Entities.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            Id = new Guid("915ad581-3c72-4e24-a0ec-f1e30d12fc45"),
                            Age = 26,
                            CreatedDate = new DateTime(2020, 11, 23, 11, 5, 35, 136, DateTimeKind.Utc).AddTicks(9862),
                            Name = "Jason",
                            Surname = "Pietersen"
                        },
                        new
                        {
                            Id = new Guid("6f0713f9-e5a0-408b-8983-c7b4d40c7511"),
                            Age = 23,
                            CreatedDate = new DateTime(2020, 11, 23, 11, 5, 35, 137, DateTimeKind.Utc).AddTicks(1654),
                            Name = "Sean",
                            Surname = "Pietersen"
                        },
                        new
                        {
                            Id = new Guid("1604b6e2-b4a6-4eec-9f30-09229fdebeb4"),
                            Age = 50,
                            CreatedDate = new DateTime(2020, 11, 23, 11, 5, 35, 137, DateTimeKind.Utc).AddTicks(1683),
                            Name = "Claudia",
                            Surname = "Pietersen"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

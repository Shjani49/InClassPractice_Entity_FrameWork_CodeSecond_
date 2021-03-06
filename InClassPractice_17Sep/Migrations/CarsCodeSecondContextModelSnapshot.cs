﻿// <auto-generated />
using System;
using InClassPractice_17Sep.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InClassPractice_17Sep.Migrations
{
    [DbContext(typeof(CarsCodeSecondContext))]
    partial class CarsCodeSecondContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("InClassPractice_17Sep.Models.CodeSecondCar", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("varchar(30)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<int?>("YearFounded")
                        .HasColumnName("YearFounded")
                        .HasColumnType("int(10)");

                    b.HasKey("ID");

                    b.ToTable("Manufacture");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Chevrolet",
                            YearFounded = 1911
                        },
                        new
                        {
                            ID = 2,
                            Name = "Tesla"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Dodge"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Toyota",
                            YearFounded = 1937
                        },
                        new
                        {
                            ID = 5,
                            Name = "Honda",
                            YearFounded = 1946
                        },
                        new
                        {
                            ID = 6,
                            Name = "Mitsubishi"
                        },
                        new
                        {
                            ID = 7,
                            Name = "Nissan"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

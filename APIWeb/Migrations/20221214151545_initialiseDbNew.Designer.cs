﻿// <auto-generated />
using APIWeb.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221214151545_initialiseDbNew")]
    partial class initialiseDbNew
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("APIWeb.Entities.Arms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long>("bonusForce")
                        .HasColumnType("bigint");

                    b.Property<long>("bonusSagesse")
                        .HasColumnType("bigint");

                    b.Property<long>("bonusVitality")
                        .HasColumnType("bigint");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Arms");
                });

            modelBuilder.Entity("APIWeb.Entities.Enemys", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long>("force")
                        .HasColumnType("bigint");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("sagesse")
                        .HasColumnType("bigint");

                    b.Property<long>("vitality")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Enemys");
                });

            modelBuilder.Entity("APIWeb.Entities.Hero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long>("force")
                        .HasColumnType("bigint");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("sagesse")
                        .HasColumnType("bigint");

                    b.Property<long>("vitality")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Heroes");
                });
#pragma warning restore 612, 618
        }
    }
}

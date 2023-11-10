﻿// <auto-generated />
using API_6._0_SQRC.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Repositories_Domain_SQRC.Migrations
{
    [DbContext(typeof(EFcontext))]
    [Migration("20231103074849_cxx")]
    partial class cxx
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("API_6._0_SQRC.Repositories.Entities.District", b =>
                {
                    b.Property<int>("DistrictID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DistrictID"));

                    b.Property<string>("DistrictDescripton")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("DistrictName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("DrovinceID")
                        .HasColumnType("integer");

                    b.Property<int>("ProvinceID")
                        .HasColumnType("integer");

                    b.HasKey("DistrictID");

                    b.HasIndex("ProvinceID");

                    b.ToTable("District");
                });

            modelBuilder.Entity("API_6._0_SQRC.Repositories.Entities.Province", b =>
                {
                    b.Property<int>("ProvinceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProvinceID"));

                    b.Property<string>("ProvinceDescription")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("ProvinceName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("ProvinceID");

                    b.ToTable("Province");
                });

            modelBuilder.Entity("API_6._0_SQRC.Repositories.Entities.Ward", b =>
                {
                    b.Property<int>("WardID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("WardID"));

                    b.Property<int>("DistrictID")
                        .HasColumnType("integer");

                    b.Property<string>("WardDescription")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("WardName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("WardID");

                    b.HasIndex("DistrictID");

                    b.ToTable("Ward");
                });

            modelBuilder.Entity("API_6._0_SQRC.Repositories.Entities.District", b =>
                {
                    b.HasOne("API_6._0_SQRC.Repositories.Entities.Province", "ProvinceEntity")
                        .WithMany()
                        .HasForeignKey("ProvinceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProvinceEntity");
                });

            modelBuilder.Entity("API_6._0_SQRC.Repositories.Entities.Ward", b =>
                {
                    b.HasOne("API_6._0_SQRC.Repositories.Entities.District", "DistrictEntity")
                        .WithMany()
                        .HasForeignKey("DistrictID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DistrictEntity");
                });
#pragma warning restore 612, 618
        }
    }
}

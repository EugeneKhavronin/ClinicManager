﻿// <auto-generated />
using System;
using ClinicManager.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ClinicManager.API.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190704130333_picturemodel")]
    partial class picturemodel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ClinicManager.Database.Models.Clinic", b =>
                {
                    b.Property<Guid>("ClinicGuid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Email");

                    b.Property<string>("PhoneNumber");

                    b.Property<Guid>("PictureGuid");

                    b.Property<string>("Specialisation");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.HasKey("ClinicGuid");

                    b.ToTable("Clinics");
                });

            modelBuilder.Entity("ClinicManager.Database.Models.Picture", b =>
                {
                    b.Property<Guid>("PictureGuid")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ClinicGuid");

                    b.Property<Guid?>("ClinicPicClinicGuid");

                    b.Property<byte[]>("ClinicPicture");

                    b.Property<string>("Title");

                    b.HasKey("PictureGuid");

                    b.HasIndex("ClinicPicClinicGuid");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("ClinicManager.Database.Models.Picture", b =>
                {
                    b.HasOne("ClinicManager.Database.Models.Clinic", "ClinicPic")
                        .WithMany()
                        .HasForeignKey("ClinicPicClinicGuid");
                });
#pragma warning restore 612, 618
        }
    }
}
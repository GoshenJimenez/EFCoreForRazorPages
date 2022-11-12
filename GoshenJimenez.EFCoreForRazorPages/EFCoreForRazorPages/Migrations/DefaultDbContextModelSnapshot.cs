﻿// <auto-generated />
using System;
using EFCoreForRazorPages.Infrastructure.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreForRazorPages.Migrations
{
    [DbContext(typeof(DefaultDbContext))]
    partial class DefaultDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFCoreForRazorPages.Infrastructure.Domain.Models.Role", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Abbreviation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00965ecf-acae-46fe-8775-d7834b07fd96"),
                            Abbreviation = "Stf",
                            Description = "People who work in school but not teaching",
                            Name = "Staff"
                        },
                        new
                        {
                            Id = new Guid("7ce68d5c-5b65-495a-8a63-14aeb48da87d"),
                            Abbreviation = "Fct",
                            Description = "People who teach in school",
                            Name = "Faculty"
                        },
                        new
                        {
                            Id = new Guid("1fb7085a-762f-440c-87de-59f75f85e935"),
                            Abbreviation = "Std",
                            Description = "People who learn in school",
                            Name = "Student"
                        });
                });

            modelBuilder.Entity("EFCoreForRazorPages.Infrastructure.Domain.Models.User", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac0"),
                            DateOfBirth = new DateTime(2022, 11, 5, 9, 26, 7, 790, DateTimeKind.Local).AddTicks(2075),
                            EmailAddress = "avengeant@mailinator.com",
                            Gender = 1,
                            Name = "Ajani",
                            RoleId = new Guid("7ce68d5c-5b65-495a-8a63-14aeb48da87d")
                        },
                        new
                        {
                            Id = new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac1"),
                            DateOfBirth = new DateTime(2022, 11, 5, 9, 26, 7, 790, DateTimeKind.Local).AddTicks(2086),
                            EmailAddress = "lvess@mailinator.com",
                            Gender = 2,
                            Name = "Liliana",
                            RoleId = new Guid("00965ecf-acae-46fe-8775-d7834b07fd96")
                        },
                        new
                        {
                            Id = new Guid("1d72f000-dbbd-419b-8af2-f571e1486ac2"),
                            DateOfBirth = new DateTime(2022, 11, 5, 9, 26, 7, 790, DateTimeKind.Local).AddTicks(2088),
                            EmailAddress = "ktide@mailinator.com",
                            Gender = 2,
                            Name = "Kiora",
                            RoleId = new Guid("1fb7085a-762f-440c-87de-59f75f85e935")
                        });
                });

            modelBuilder.Entity("EFCoreForRazorPages.Infrastructure.Domain.Models.User", b =>
                {
                    b.HasOne("EFCoreForRazorPages.Infrastructure.Domain.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}

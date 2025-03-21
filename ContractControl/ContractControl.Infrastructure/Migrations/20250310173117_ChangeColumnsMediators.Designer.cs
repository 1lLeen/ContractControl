﻿// <auto-generated />
using System;
using ContractControl.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ContractControl.Infrastructure.Migrations
{
    [DbContext(typeof(ContractControlDbContext))]
    [Migration("20250310173117_ChangeColumnsMediators")]
    partial class ChangeColumnsMediators
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ContractControl.Infrastructure.Models.CompanyModels.CompanyModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressCompany")
                        .HasColumnType("text");

                    b.Property<string>("BIINCompany")
                        .HasColumnType("text");

                    b.Property<string>("CompanyName")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("ContractControl.Infrastructure.Models.ContractModels.ContractModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ContractDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ContractName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("MediatorModelId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("MediatorModelId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("ContractControl.Infrastructure.Models.MediatorModels.MediatorModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("FromComapnyId")
                        .HasColumnType("integer");

                    b.Property<bool>("State")
                        .HasColumnType("boolean");

                    b.Property<int?>("ToComapnyId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("FromComapnyId");

                    b.HasIndex("ToComapnyId");

                    b.ToTable("Mediator");
                });

            modelBuilder.Entity("ContractControl.Infrastructure.Models.ContractModels.ContractModel", b =>
                {
                    b.HasOne("ContractControl.Infrastructure.Models.MediatorModels.MediatorModel", null)
                        .WithMany("Contract")
                        .HasForeignKey("MediatorModelId");
                });

            modelBuilder.Entity("ContractControl.Infrastructure.Models.MediatorModels.MediatorModel", b =>
                {
                    b.HasOne("ContractControl.Infrastructure.Models.CompanyModels.CompanyModel", "FromComapny")
                        .WithMany()
                        .HasForeignKey("FromComapnyId");

                    b.HasOne("ContractControl.Infrastructure.Models.CompanyModels.CompanyModel", "ToComapny")
                        .WithMany()
                        .HasForeignKey("ToComapnyId");

                    b.Navigation("FromComapny");

                    b.Navigation("ToComapny");
                });

            modelBuilder.Entity("ContractControl.Infrastructure.Models.MediatorModels.MediatorModel", b =>
                {
                    b.Navigation("Contract");
                });
#pragma warning restore 612, 618
        }
    }
}

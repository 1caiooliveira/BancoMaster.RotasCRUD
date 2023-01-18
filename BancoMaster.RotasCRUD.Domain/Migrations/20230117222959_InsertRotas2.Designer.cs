﻿// <auto-generated />
using System;
using BancoMaster.RotasCRUD.Domain.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BancoMaster.RotasCRUD.Domain.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230117222959_InsertRotas2")]
    partial class InsertRotas2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BancoMaster.RotasCRUD.Domain.Entities.Local", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locais", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("5b9cd049-5a81-45ed-87ff-11d249031f13"),
                            Ativo = true,
                            DataCadastro = new DateTime(2023, 1, 17, 19, 29, 55, 950, DateTimeKind.Local).AddTicks(611),
                            Nome = "GRU"
                        },
                        new
                        {
                            Id = new Guid("5b9cd049-5a81-45ed-87ff-11d249031f14"),
                            Ativo = true,
                            DataCadastro = new DateTime(2023, 1, 17, 19, 29, 55, 950, DateTimeKind.Local).AddTicks(633),
                            Nome = "BRC"
                        },
                        new
                        {
                            Id = new Guid("5b9cd049-5a81-45ed-87ff-11d249031f15"),
                            Ativo = true,
                            DataCadastro = new DateTime(2023, 1, 17, 19, 29, 55, 950, DateTimeKind.Local).AddTicks(638),
                            Nome = "ORL"
                        },
                        new
                        {
                            Id = new Guid("5b9cd049-5a81-45ed-87ff-11d249031f16"),
                            Ativo = true,
                            DataCadastro = new DateTime(2023, 1, 17, 19, 29, 55, 950, DateTimeKind.Local).AddTicks(642),
                            Nome = "SCL"
                        },
                        new
                        {
                            Id = new Guid("5b9cd049-5a81-45ed-87ff-11d249031f17"),
                            Ativo = true,
                            DataCadastro = new DateTime(2023, 1, 17, 19, 29, 55, 950, DateTimeKind.Local).AddTicks(645),
                            Nome = "CDG"
                        });
                });

            modelBuilder.Entity("BancoMaster.RotasCRUD.Domain.Entities.Rota", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LocalDestinoId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("LocalOrigemId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Valor")
                        .HasMaxLength(9)
                        .HasPrecision(10, 2)
                        .HasColumnType("Decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("LocalDestinoId");

                    b.HasIndex("LocalOrigemId");

                    b.ToTable("Rotas", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee8"),
                            Ativo = true,
                            DataCadastro = new DateTime(2023, 1, 17, 19, 29, 55, 954, DateTimeKind.Local).AddTicks(3114),
                            LocalDestinoId = new Guid("5b9cd049-5a81-45ed-87ff-11d249031f14"),
                            LocalOrigemId = new Guid("5b9cd049-5a81-45ed-87ff-11d249031f13"),
                            Valor = 10m
                        },
                        new
                        {
                            Id = new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee7"),
                            Ativo = true,
                            DataCadastro = new DateTime(2023, 1, 17, 19, 29, 55, 954, DateTimeKind.Local).AddTicks(3222),
                            LocalDestinoId = new Guid("5b9cd049-5a81-45ed-87ff-11d249031f16"),
                            LocalOrigemId = new Guid("5b9cd049-5a81-45ed-87ff-11d249031f14"),
                            Valor = 5m
                        },
                        new
                        {
                            Id = new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee6"),
                            Ativo = true,
                            DataCadastro = new DateTime(2023, 1, 17, 19, 29, 55, 954, DateTimeKind.Local).AddTicks(3245),
                            LocalDestinoId = new Guid("5b9cd049-5a81-45ed-87ff-11d249031f17"),
                            LocalOrigemId = new Guid("5b9cd049-5a81-45ed-87ff-11d249031f13"),
                            Valor = 75m
                        },
                        new
                        {
                            Id = new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee5"),
                            Ativo = true,
                            DataCadastro = new DateTime(2023, 1, 17, 19, 29, 55, 954, DateTimeKind.Local).AddTicks(3253),
                            LocalDestinoId = new Guid("5b9cd049-5a81-45ed-87ff-11d249031f16"),
                            LocalOrigemId = new Guid("5b9cd049-5a81-45ed-87ff-11d249031f13"),
                            Valor = 20m
                        },
                        new
                        {
                            Id = new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee4"),
                            Ativo = true,
                            DataCadastro = new DateTime(2023, 1, 17, 19, 29, 55, 954, DateTimeKind.Local).AddTicks(3260),
                            LocalDestinoId = new Guid("5b9cd049-5a81-45ed-87ff-11d249031f15"),
                            LocalOrigemId = new Guid("5b9cd049-5a81-45ed-87ff-11d249031f13"),
                            Valor = 56m
                        },
                        new
                        {
                            Id = new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee3"),
                            Ativo = true,
                            DataCadastro = new DateTime(2023, 1, 17, 19, 29, 55, 954, DateTimeKind.Local).AddTicks(3272),
                            LocalDestinoId = new Guid("5b9cd049-5a81-45ed-87ff-11d249031f17"),
                            LocalOrigemId = new Guid("5b9cd049-5a81-45ed-87ff-11d249031f15"),
                            Valor = 5m
                        },
                        new
                        {
                            Id = new Guid("93004a1a-2f73-4252-a56d-5b4ef37c4ee2"),
                            Ativo = true,
                            DataCadastro = new DateTime(2023, 1, 17, 19, 29, 55, 954, DateTimeKind.Local).AddTicks(3279),
                            LocalDestinoId = new Guid("5b9cd049-5a81-45ed-87ff-11d249031f15"),
                            LocalOrigemId = new Guid("5b9cd049-5a81-45ed-87ff-11d249031f16"),
                            Valor = 20m
                        });
                });

            modelBuilder.Entity("BancoMaster.RotasCRUD.Domain.Entities.Usuario", b =>
                {
                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("BancoMaster.RotasCRUD.Domain.Entities.Rota", b =>
                {
                    b.HasOne("BancoMaster.RotasCRUD.Domain.Entities.Local", "LocalDestino")
                        .WithMany("RotasDestino")
                        .HasForeignKey("LocalDestinoId")
                        .IsRequired();

                    b.HasOne("BancoMaster.RotasCRUD.Domain.Entities.Local", "LocalOrigem")
                        .WithMany("RotasOrigem")
                        .HasForeignKey("LocalOrigemId")
                        .IsRequired();

                    b.Navigation("LocalDestino");

                    b.Navigation("LocalOrigem");
                });

            modelBuilder.Entity("BancoMaster.RotasCRUD.Domain.Entities.Local", b =>
                {
                    b.Navigation("RotasDestino");

                    b.Navigation("RotasOrigem");
                });
#pragma warning restore 612, 618
        }
    }
}
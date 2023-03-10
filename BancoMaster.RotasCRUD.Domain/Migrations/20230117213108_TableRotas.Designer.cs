// <auto-generated />
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
    [Migration("20230117213108_TableRotas")]
    partial class TableRotas
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
                            DataCadastro = new DateTime(2023, 1, 17, 18, 31, 7, 821, DateTimeKind.Local).AddTicks(1358),
                            Nome = "GRU"
                        },
                        new
                        {
                            Id = new Guid("5b9cd049-5a81-45ed-87ff-11d249031f14"),
                            Ativo = true,
                            DataCadastro = new DateTime(2023, 1, 17, 18, 31, 7, 821, DateTimeKind.Local).AddTicks(1371),
                            Nome = "BRC"
                        },
                        new
                        {
                            Id = new Guid("5b9cd049-5a81-45ed-87ff-11d249031f15"),
                            Ativo = true,
                            DataCadastro = new DateTime(2023, 1, 17, 18, 31, 7, 821, DateTimeKind.Local).AddTicks(1374),
                            Nome = "ORL"
                        },
                        new
                        {
                            Id = new Guid("5b9cd049-5a81-45ed-87ff-11d249031f16"),
                            Ativo = true,
                            DataCadastro = new DateTime(2023, 1, 17, 18, 31, 7, 821, DateTimeKind.Local).AddTicks(1376),
                            Nome = "SCL"
                        },
                        new
                        {
                            Id = new Guid("5b9cd049-5a81-45ed-87ff-11d249031f17"),
                            Ativo = true,
                            DataCadastro = new DateTime(2023, 1, 17, 18, 31, 7, 821, DateTimeKind.Local).AddTicks(1378),
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
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("LocalDestinoId");

                    b.HasIndex("LocalOrigemId");

                    b.ToTable("Rotas", (string)null);
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

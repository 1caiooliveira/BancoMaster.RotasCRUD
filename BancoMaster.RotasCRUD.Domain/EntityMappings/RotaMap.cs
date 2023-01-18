using BancoMaster.RotasCRUD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMaster.RotasCRUD.Domain.EntityMappings
{
    public class RotaMap : IEntityTypeConfiguration<Rota>
    {
        public void Configure(EntityTypeBuilder<Rota> builder)
        {
            #region Definições da Tabela

            builder.ToTable("Rotas");
            builder.HasKey(c => c.Id);

            builder.HasOne(r => r.LocalDestino)
                .WithMany(l => l.RotasDestino)
                .HasForeignKey(r => r.LocalDestinoId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(r => r.LocalOrigem)
                .WithMany(l => l.RotasOrigem)
                .HasForeignKey(r => r.LocalOrigemId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            #endregion

            #region Propriedades
                builder.Property(u => u.Valor)
                    .IsRequired()
                    .HasColumnType("Decimal")
                    .HasMaxLength(9)
                    .HasPrecision(10, 2);
            #endregion

            #region Dados
            builder.HasData(new List<Rota> {
            new Rota
            {
                Id = Guid.Parse("93004A1A-2F73-4252-A56D-5B4EF37C4EE8"),
                Ativo = true,
                DataCadastro = DateTime.Now,
                LocalOrigemId = Guid.Parse("5B9CD049-5A81-45ED-87FF-11D249031F13"),
                LocalDestinoId = Guid.Parse("5B9CD049-5A81-45ED-87FF-11D249031F14"),
                Valor = 10
            },
            new Rota
            {
                Id = Guid.Parse("93004A1A-2F73-4252-A56D-5B4EF37C4EE7"),
                Ativo = true,
                DataCadastro = DateTime.Now,
                LocalOrigemId = Guid.Parse("5B9CD049-5A81-45ED-87FF-11D249031F14"),
                LocalDestinoId = Guid.Parse("5B9CD049-5A81-45ED-87FF-11D249031F16"),
                Valor = 5
            },
            new Rota
            {
                Id = Guid.Parse("93004A1A-2F73-4252-A56D-5B4EF37C4EE6"),
                Ativo = true,
                DataCadastro = DateTime.Now,
                LocalOrigemId = Guid.Parse("5B9CD049-5A81-45ED-87FF-11D249031F13"),
                LocalDestinoId = Guid.Parse("5B9CD049-5A81-45ED-87FF-11D249031F17"),
                Valor = 75
            },
            new Rota
            {
                Id = Guid.Parse("93004A1A-2F73-4252-A56D-5B4EF37C4EE5"),
                Ativo = true,
                DataCadastro = DateTime.Now,
                LocalOrigemId = Guid.Parse("5B9CD049-5A81-45ED-87FF-11D249031F13"),
                LocalDestinoId = Guid.Parse("5B9CD049-5A81-45ED-87FF-11D249031F16"),
                Valor = 20
            },
            new Rota
            {
                Id = Guid.Parse("93004A1A-2F73-4252-A56D-5B4EF37C4EE4"),
                Ativo = true,
                DataCadastro = DateTime.Now,
                LocalOrigemId = Guid.Parse("5B9CD049-5A81-45ED-87FF-11D249031F13"),
                LocalDestinoId = Guid.Parse("5B9CD049-5A81-45ED-87FF-11D249031F15"),
                Valor = 56
            },
            new Rota
            {
                Id = Guid.Parse("93004A1A-2F73-4252-A56D-5B4EF37C4EE3"),
                Ativo = true,
                DataCadastro = DateTime.Now,
                LocalOrigemId = Guid.Parse("5B9CD049-5A81-45ED-87FF-11D249031F15"),
                LocalDestinoId = Guid.Parse("5B9CD049-5A81-45ED-87FF-11D249031F17"),
                Valor = 5
            },
            new Rota
            {
                Id = Guid.Parse("93004A1A-2F73-4252-A56D-5B4EF37C4EE2"),
                Ativo = true,
                DataCadastro = DateTime.Now,
                LocalOrigemId = Guid.Parse("5B9CD049-5A81-45ED-87FF-11D249031F16"),
                LocalDestinoId = Guid.Parse("5B9CD049-5A81-45ED-87FF-11D249031F15"),
                Valor = 20
            }});
            
            #endregion
        }
    }
}

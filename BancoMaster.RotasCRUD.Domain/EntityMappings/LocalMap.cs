using BancoMaster.RotasCRUD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BancoMaster.RotasCRUD.Domain.EntityMappings
{
    public class LocalMap : IEntityTypeConfiguration<Local>
    {
        public void Configure(EntityTypeBuilder<Local> builder)
        {
            #region Definições da Tabela

            builder.ToTable("Locais");
            builder.HasKey(c => c.Id);

            #endregion

            #region Dados

            builder.HasData(new List<Local> { 
            new Local {
                Id = Guid.Parse("5B9CD049-5A81-45ED-87FF-11D249031F13"),
                Ativo = true,
                DataCadastro = DateTime.Now,
                Nome = "GRU"
            },
            new Local {
                Id = Guid.Parse("5B9CD049-5A81-45ED-87FF-11D249031F14"),
                Ativo = true,
                DataCadastro = DateTime.Now,
                Nome = "BRC"
            },
            new Local {
                Id = Guid.Parse("5B9CD049-5A81-45ED-87FF-11D249031F15"),
                Ativo = true,
                DataCadastro = DateTime.Now,
                Nome = "ORL"
            },
            new Local {
                Id = Guid.Parse("5B9CD049-5A81-45ED-87FF-11D249031F16"),
                Ativo = true,
                DataCadastro = DateTime.Now,
                Nome = "SCL"
            },
            new Local {
                Id = Guid.Parse("5B9CD049-5A81-45ED-87FF-11D249031F17"),
                Ativo = true,
                DataCadastro = DateTime.Now,
                Nome = "CDG"
            }
            });

            #endregion
        }
    }
}

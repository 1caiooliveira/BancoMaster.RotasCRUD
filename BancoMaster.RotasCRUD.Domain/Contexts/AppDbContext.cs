using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using BancoMaster.RotasCRUD.Domain.Entities;

namespace BancoMaster.RotasCRUD.Domain.Contexts;
#nullable disable
public class AppDbContext : DbContext
{
    private readonly IConfiguration _configuration;
    public AppDbContext(DbContextOptions<AppDbContext> options)
          : base(options) 
    {
    }
    public AppDbContext(DbContextOptions<AppDbContext> options,
            IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Usuario>().HasNoKey();
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Local> Locais { get; set; }
    public DbSet<Rota> Rotas { get; set; }

}

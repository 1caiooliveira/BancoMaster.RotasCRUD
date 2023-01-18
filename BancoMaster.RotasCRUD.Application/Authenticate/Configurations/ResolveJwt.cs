using Microsoft.Extensions.DependencyInjection;
using BancoMaster.RotasCRUD.Application.Authenticate.Services;

namespace BancoMaster.RotasCRUD.Application.Authenticate.Configurations;

public static class ResolveJwt
{
    public static void ResolveJwtConfig(this IServiceCollection services)
    {
        services.AddScoped<IGeneratorToken, GeneratorToken>();
    }
}

using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace BancoMaster.RotasCRUD.Services.Api.Configurations
{
    public class ConfigureSwaggerVersions : IConfigureNamedOptions<SwaggerGenOptions>
    {
        private readonly IApiVersionDescriptionProvider _provider;

        public ConfigureSwaggerVersions(
            IApiVersionDescriptionProvider provider)
        {
            _provider = provider;
        }

        public void Configure(SwaggerGenOptions options)
        {
            foreach (var description in _provider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(
                    description.GroupName,
                    CreateVersionInfo(description));
            }
        }

        public void Configure(string name, SwaggerGenOptions options)
        {
            Configure(options);
        }

        private OpenApiInfo CreateVersionInfo(
                ApiVersionDescription desc)
        {
            var info = new OpenApiInfo()
            {
                Title = "Banco Master - CRUD Rotas",
                Description = "Documentação da API de CRUD de rotas. Para acessar os métodos da API é necessária autenticação do usuário com login e senha de acesso. <br> Login: adm-master <br> Senha: 123mudar@ ",
                Contact = new OpenApiContact { Name = "Banco Master", Email = "contato@bancomaster.com.br", Url = new Uri("https://bancomaster.com.br/") },
                Version = desc.ApiVersion.ToString()
            };

            if (desc.IsDeprecated)
            {
                info.Description += " <strong>Esta versão da API foi descontinuada. Por favor, use uma das novas APIs disponíveis no explorador do Swagger.</strong>";
            }

            return info;
        }
    }

}

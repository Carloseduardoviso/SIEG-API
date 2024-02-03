using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace CrossCutting.IoC.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class ApiVersioningExtension
    {
        public static WebApplicationBuilder AddApiVersioning(this WebApplicationBuilder builder)
        {
            builder.Services.AddApiVersioning(options =>
            {
                // Retorna os headers "api-supported-versions" e "api-deprecated-versions"
                // indicando versões suportadas pela API e o que está como deprecated
                options.ReportApiVersions = true;
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new ApiVersion(1, 0);
            });

            builder.Services.AddVersionedApiExplorer(options =>
            {
                // Agrupar por número de versão
                options.GroupNameFormat = "'v'VVV";
                // Necessário para o correto funcionamento das rotas
                options.SubstituteApiVersionInUrl = true;
            });

            return builder;
        }
    }
}

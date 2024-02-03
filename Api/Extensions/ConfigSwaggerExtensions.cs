using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.OpenApi.Models;
using System.Diagnostics.CodeAnalysis;

namespace API.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class ConfigSwaggerExtensions
    {
        public static WebApplicationBuilder AddConfigSwagger(this WebApplicationBuilder builder, string title)
        {
            builder.Services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = title,
                    Description = "-",
                    Version = "1.0"
                });
            });

            return builder;
        }

        public static WebApplication UseConfigSwagger(this WebApplication app, IApiVersionDescriptionProvider provider)
        {
            if (app.Environment.IsDevelopment() || app.Environment.IsStaging())
            {
                app.UseSwagger();
                app.UseSwaggerUI(options =>
                {
                    // Geração de um endpoint do Swagger para cada versão descoberta
                    foreach (var description in provider.ApiVersionDescriptions.Select(x => x.GroupName))
                    {
                        options.SwaggerEndpoint($"/swagger/{description}/swagger.json",
                          description.ToUpperInvariant());
                    }
                });
            }

            return app;
        }
    }
}

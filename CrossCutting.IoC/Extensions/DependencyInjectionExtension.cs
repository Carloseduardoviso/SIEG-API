using Adaptadores.Context;
using Dominio.Entidades;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;
using Historias.Produto.Criar;
using Adaptadores.Constantes;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace CrossCutting.IoC.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class DependencyInjectionExtension
    {
        public static WebApplicationBuilder DependencyInjection(this WebApplicationBuilder builder, IConfiguration configuration)
        {
            //Entidades
            builder.Services.AddScoped<CriarProdutoDto>();

            //contexto
            builder.Services.AddDbContext<SiegContext>(options =>
            {
                options.EnableSensitiveDataLogging();
                options.UseSqlServer(builder.Configuration.GetConnectionString(nameof(SiegContext)),
                    optionsSqlServer =>
                    {
                        optionsSqlServer.MigrationsHistoryTable("HistoricoDasMigrations", SchemeConstantes.SIEG);
                        optionsSqlServer.CommandTimeout(120).EnableRetryOnFailure(
                            maxRetryCount: 2,
                            maxRetryDelay: TimeSpan.FromSeconds(5),
                            errorNumbersToAdd: null);
                    });
            });


            return builder;
        }      
    }
}

using Adaptadores.Context;
using Dominio.Entidades;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;
using Historias.Produto.Criar;


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
            
            return builder;
        }      
    }
}

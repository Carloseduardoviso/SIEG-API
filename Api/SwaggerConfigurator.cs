using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace API
{
    public class SwaggerConfigurator
    {
        static public void ConfigurarSwagger(IServiceCollection services)
        {
            // Registrando Swagger
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo { Title = "SIEG API", Version = "1.0", TermsOfService = null });

                try
                {
                    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

                    if (File.Exists(xmlPath))
                    {
                        x.IncludeXmlComments(xmlPath);
                    }
                    else
                    {
                        Console.WriteLine($"XML documentation file not found at: {xmlPath}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error while configuring Swagger: {ex.Message}");
                }

                x.EnableAnnotations();
            });
        }
    }
}

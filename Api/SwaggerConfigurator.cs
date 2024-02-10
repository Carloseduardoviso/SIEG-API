using Microsoft.OpenApi.Models;
using System.Reflection;

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
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                x.IncludeXmlComments(xmlPath);
                x.EnableAnnotations();
            });
        }
    }
}

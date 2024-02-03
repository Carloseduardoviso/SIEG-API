using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace CrossCutting.IoC.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class RequestLocalizationCulturePtBrExtension
    {
        public static IApplicationBuilder UserRequestLocalizationCulturePtBr(this IApplicationBuilder builder)
        {
            var culturaBrasileira = new[] {new CultureInfo("pt-BR") };
            return builder.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("pt-BR"),
                SupportedCultures = culturaBrasileira,
                SupportedUICultures = culturaBrasileira
            });
        }
    }
}

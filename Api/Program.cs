using Adaptadores.Context;
using API;
using API.Extensions;
using CrossCutting.IoC.Extensions;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.DependencyInjection(builder.Configuration);

SwaggerConfigurator.ConfigurarSwagger(builder.Services);
builder.AddApiVersioning();

//builder.Services.AddDbContext<SiegContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("SiegContext")));

var app = builder.Build();
var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
    app.UseHttpsRedirection();
}

app.UserRequestLocalizationCulturePtBr();
app.UseAuthorization();
app.UseConfigSwagger(provider);

app.MapControllers();
app.Run();
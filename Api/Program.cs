using API;
using API.Extensions;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
SwaggerConfigurator.ConfigurarSwagger(builder.Services);

var app = builder.Build();
var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHsts();
    app.UseHttpsRedirection();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseConfigSwagger(provider);
app.MapControllers();

app.Run();

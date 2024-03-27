using Core.AspNetCoreWebApi;
using Develop_Challenge_API;
using Infraestrutura;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Swashbuckle.Swagger;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ConextoDoBancoDeDados>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("DevelopChallenge"),
                builder => builder.EnableRetryOnFailure()));

builder.Services.IncluirTodasAsDependencias();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Develop Challenge API", Version = "v1" });

    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI(opt =>
    {
        opt.SwaggerEndpoint("/swagger/v1/swagger.json", "Develop Challenge API V1");
    });

    app.UseSwaggerUI();
}

app.UseMiddleware(typeof(MiddlewareDeErros));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

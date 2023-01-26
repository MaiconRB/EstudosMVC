using EstudosMVC.Models;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<Context>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo { Title = "CursoAPI", Version = "v1" }); });//COFINGURAÇÃO DO CURSO

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwagger();
app.UseSwaggerUI(c => { c.SwaggerEndpoint(url: "/swegger/v1/swegger.json", name: "CursoAPI"); });//COFINGURAÇÃO DO CURSO


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

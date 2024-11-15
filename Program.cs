using dofus_unity_rendering_back.Models.Metadata.Monster;
using dofus_unity_rendering_back;
using dofus_unity_rendering_back.Services;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IMonsterService, MonsterService>();
builder.Services.AddDbContext<AppDbContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(80);  // Permet d'écouter sur le port 80 de toutes les interfaces réseau
});

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("WebApiDatabase")));

var app = builder.Build();

// DataLoaderService.LoadDataFromJSon(app);

// Configure the HTTP request pipeline.
/* if (app.Environment.IsDevelopment())
{
} */

app.UseSwagger();
app.UseSwaggerUI();

// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
using Microsoft.EntityFrameworkCore;
using PacientesApi.Data;
using PacientesApi.Modules.Pacientes.Interface;
using PacientesApi.Modules.Pacientes.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Configurar Entity Framework Core con SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registrar el servicio de pacientes
builder.Services.AddScoped<IPacienteService, PacienteService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();

app.Run();

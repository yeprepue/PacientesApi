using Microsoft.EntityFrameworkCore;
using PacientesApi.Modules.Pacientes.Models;

namespace PacientesApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        
        public DbSet<Paciente> Pacientes { get; set; }    
    }
}
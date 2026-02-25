using Microsoft.EntityFrameworkCore;
using AgendaApi.Data;
using PacientesApi.Modules.Pacientes.Interface;
using PacientesApi.Modules.Pacientes.Models;

namespace PacientesApi.Modules.Pacientes.Service
{
    public class PacienteService : IPacienteService
    {
        private readonly ApplicationDbContext _context;

        public PacienteService(ApplicationDbContext context)
        {
            _context = context;
        }

        // 🔹 Obtener todos
        public async Task<IEnumerable<Paciente>> GetAll()
        {
            return await _context.Pacientes.ToListAsync();
        }

        // 🔹 Obtener por Id
        public async Task<Paciente?> GetById(int id)
        {
            return await _context.Pacientes.FindAsync(id);
        }

        // 🔹 Crear
        public async Task<Paciente> Create(Paciente paciente)
        {
            _using Microsoft.EntityFrameworkCore;
using AgendaApi.Data;
using PacientesApi.Modules.Pacientes.Interface;
using PacientesApi.Modules.Pacientes.Models;

namespace PacientesApi.Modules.Pacientes.Service
{
    public class PacienteService : IPacienteService
    {
        private readonly ApplicationDbContext _context;

        public PacienteService(ApplicationDbContext context)
        {
            _context = context;
        }

        // 🔹 Obtener todos
        public async Task<IEnumerable<Paciente>> GetAll()
        {
            return await _context.Pacientes.ToListAsync();
        }

        // 🔹 Obtener por Id
        public async Task<Paciente?> GetById(int id)
        {
            return await _context.Pacientes.FindAsync(id);
        }

        // 🔹 Crear
        public async Task<Paciente> Create(Paciente paciente)
        {
            var existing = await _context.Pacientes.FindAsync(id);

            if (existing == null)
                return null;

            existing.TipoDocumento = paciente.TipoDocumento

        }

    }
}
using Microsoft.EntityFrameworkCore;
using PacientesApi.Data;
using PacientesApi.Modules.Pacientes.Interface;
using PacientesApi.Modules.Pacientes.Models;

namespace PacientesApi.Modules.Pacientes.Services
{
    public class PacienteService : IPacienteService
    {
        private readonly ApplicationDbContext _context;

        public PacienteService(ApplicationDbContext context)
        {
            _context = context;
        }

        // Obtener todos los pacientes
        public async Task<IEnumerable<Paciente>> GetAll()
        {
            return await _context.Pacientes.ToListAsync();
        }

        // Obtener paciente por Id
        public async Task<Paciente?> GetById(int id)
        {
            return await _context.Pacientes.FindAsync(id);
        }

        // Crear un nuevo paciente
        public async Task<Paciente> Create(Paciente paciente)
        {
            _context.Pacientes.Add(paciente);
            await _context.SaveChangesAsync();
            return paciente;
        }

        // Actualizar un paciente existente
        public async Task<Paciente?> Update(int id, Paciente paciente)
        {
            var existing = await _context.Pacientes.FindAsync(id);

            if (existing == null)
                return null;

            existing.TipoDocumento = paciente.TipoDocumento;
            existing.NumeroDocumento = paciente.NumeroDocumento;
            existing.NombrePaciente = paciente.NombrePaciente;
            existing.EmailCandidato = paciente.EmailCandidato;
            existing.FechaNacimiento = paciente.FechaNacimiento;
            existing.Genero = paciente.Genero;
            existing.Telefono = paciente.Telefono;
            existing.Direccion = paciente.Direccion;

            await _context.SaveChangesAsync();
            return existing;
        }

        // Eliminar un paciente
        public async Task<bool> Delete(int id)
        {
            var paciente = await _context.Pacientes.FindAsync(id);

            if (paciente == null)
                return false;

            _context.Pacientes.Remove(paciente);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

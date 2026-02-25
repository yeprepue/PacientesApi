using PacientesApi.Modules.Pacientes.Models;

namespace PacientesApi.Modules.Pacientes.Interface
{
    public interface IPacienteService
    {
        Task<IEnumerable<Paciente>> GetAll();

        Task<Paciente?> GetById(int id);

        Task<Paciente> Create(Paciente paciente);

        Task<Paciente?> Update(int id, Paciente paciente);

        Task<bool> Delete(int id);
    }
}
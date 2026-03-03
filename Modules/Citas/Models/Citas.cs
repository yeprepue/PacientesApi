using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
// Importamos los namespaces de los otros módulos para poder usar sus modelos
using PacientesApi.Modules.Pacientes.Models;
using PacientesApi.Modules.Medicos.Models;

namespace PacientesApi.Modules.Citas.Models
{
    public class Cita
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime FechaHora { get; set; }

        [Required]
        [MaxLength(500)]
        public string MotivoConsulta { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Estado { get; set; } = "Programada";
        [Required]
        public int PacienteId { get; set; }
        
        [ForeignKey("PacienteId")]
        public Paciente? Paciente { get; set; }

        [Required]
        public int MedicoId { get; set; }
        
        [ForeignKey("MedicoId")]
        public ICollection<Cita>? Citas { get; set; }
    }
}
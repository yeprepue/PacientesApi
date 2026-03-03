using System.ComponentModel.DataAnnotations;
using PacientesApi.Modules.Citas.Models;

namespace PacientesApi.Modules.Medicos.Models
{
    public class Medicos
    {
        [Key]
        [Required]
        public String NombreCompleto { get; set; } = string.Empty;
        [Required]
        public String Especialidad { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public String EmailMedico { get; set; } = string.Empty;

        public ICollection<Cita>? Citas { get; set; }

        

        
    }
}
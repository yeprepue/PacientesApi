using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PacientesApi.Modules.Pacientes.Models
{
    public class Paciente
    {
        // ID del paciente
        // Tipo de documento
        // Número de documento
        // Nombre del paciente

        // Fecha de nacimiento
        // Correo electrónico
        // Genero
        // Dirección
        // Número de teléfono



        [Key]
        public int Id { get; set; }

        [Required]
        public string TipoDocumento { get; set; } = string.Empty;

        [Required]
        public string NumeroDocumento { get; set; } = string.Empty;
        [Required]
        public string NombrePaciente { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string EmailCandidato { get; set; } = string.Empty;

        [Required]
        public DateOnly FechaNacimiento { get; set; }

        [Required]
        public string Genero { get; set; }


        [Required]
        public string Direccion { get; set; }

        [Required]
        public string Telefono { get; set; }

    }
}
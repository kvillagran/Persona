using System.ComponentModel.DataAnnotations;

namespace Persona.Models
{
    public class Persona
    {
        [Key]
        public string DUI { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Apellido { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [StringLength(200)]
        public string Direccion { get; set; }

        [EmailAddress]
        public string CorreoElectronico { get; set; }
    }
}

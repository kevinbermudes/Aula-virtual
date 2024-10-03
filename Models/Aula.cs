using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webvs2.Models
{
    public class Aula
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string? Nombre { get; set; }
        
        
        [ForeignKey("Alumno")]
        public string? NombreAlumnoEnAula { get; set; }

        public ICollection<Alumno>? Alumnos { get; set; } = new List<Alumno>();
    }
}

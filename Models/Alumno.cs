using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webvs2.Models
{
    public class Alumno
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="varchar(100)")]
        public string? NombreAlumno { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string? Apellido { get; set; }

        [ForeignKey("AulaId")]
        public int? AulaId { get; set; }
        public virtual Aula? Aula { get; set; }

        public ICollection<AlumnoTarea> AlumnoTareas { get; set; } = new List<AlumnoTarea>();

    }
}

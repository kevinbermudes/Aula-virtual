using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.JavaScript;

namespace Webvs2.Models
{
    public class Tareas
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string? Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string? Descripcion { get; set; }
        public DateTime  FechaEx { get; set; }
        
        public ICollection<AlumnoTarea> AlumnoTareas { get; set; } = new List<AlumnoTarea>();


    }
}

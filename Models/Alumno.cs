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
        public string? Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string? Apellido { get; set; }


        /*
        [ForeignKey("Aula")]
        */
        /*
        public int? AulaId { get; set; } 
        */
        public virtual Aula? Aula { get; set; }
        
        [ForeignKey("Tareas")]
        public int? TareaId { get; set; }
        public Tareas? Tareas { get; set; } 

    }
}

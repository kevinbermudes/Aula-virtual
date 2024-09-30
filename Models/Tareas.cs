using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Required]
        public DateOnly FechaEx { get; set; }

  
    }
}

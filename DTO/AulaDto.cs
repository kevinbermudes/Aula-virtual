using Webvs2.Models;

namespace Webvs2.DTO;

public class AulaDto
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    
   public List<string>? AlumnoNombres { get; set; } = new List<string>();
}
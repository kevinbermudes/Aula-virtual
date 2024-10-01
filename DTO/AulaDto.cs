namespace Webvs2.DTO;

public class AulaDto
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public List<AlumnoDto>? Alumnos { get; set; }
}
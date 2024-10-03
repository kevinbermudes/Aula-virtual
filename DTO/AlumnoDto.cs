namespace Webvs2.DTO;

public class AlumnoDto
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public string? AulaNombre { get; set; }
    public List<string>? Tareas { get; set; } = new List<string>(); 

}

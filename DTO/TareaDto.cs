namespace Webvs2.DTO;

public class TareaDto
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Descripcion { get; set; }
    public DateTime?  FechaEx { get; set; }
    public List<string>? AlumnoNombres { get; set; } = new List<string>();
}
namespace Webvs2.Models;

public class AlumnoTarea
{
    public int AlumnoId { get; set; }
    public Alumno Alumno { get; set; }

    public int TareaId { get; set; }
    public Tareas Tarea { get; set; }
}
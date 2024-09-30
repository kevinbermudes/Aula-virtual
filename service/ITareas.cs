using Webvs2.Models;

namespace Webvs2.Service;

public interface ITareas
{
    IEnumerable<Tareas> GetTarea();
    Tareas? GetTareaById(int id);
    Tareas CreateTarea(Tareas alumno);
    void UpdateTarea(Tareas alumno);
    void DeleteTarea(int id);
}
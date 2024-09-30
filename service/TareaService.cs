using Webvs2.Models;

namespace Webvs2.Service;

public class TareaService : ITareas
{
    private readonly AplicationDbContext _context;

    public TareaService(AplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Tareas> GetTarea() =>
        _context.Tareas.ToList();

    public Tareas? GetTareaById(int id) =>
        _context.Tareas.Find(id);

    public Tareas CreateTarea(Tareas tareas)
    {
        _context.Tareas.Add(tareas);
        _context.SaveChanges();
        return tareas;
    }

    public void UpdateTarea(Tareas tareas)
    {
        _context.Tareas.Update(tareas);
        _context.SaveChanges();
    }

    public void DeleteTarea(int id)
    {
        var tarea = _context.Tareas.Find(id);
        if (tarea != null)
        {
            _context.Tareas.Remove(tarea);
            _context.SaveChanges();
        }
    }
}
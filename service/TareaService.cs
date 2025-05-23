﻿using Microsoft.EntityFrameworkCore;
using Webvs2.DTO;
using Webvs2.Mappers;


namespace Webvs2.Service;

public class TareaService : ITareas
{
    private readonly AplicationDbContext _context;

    public TareaService(AplicationDbContext context)
    {
        _context = context;
     
    }

    public IEnumerable<TareaDto> GetTarea()
    {
        var tareas = _context.Tareas
            .Include(t => t.AlumnoTareas) 
            .ThenInclude(at => at.Alumno) 
            .ToList();

        return tareas.Select(t => t.ToDto()).ToList();
    }

    public IEnumerable<TareaDto> GetTareaPorAlumno()
    {
        var tareas = _context.Tareas
            .Include(t => t.AlumnoTareas)
            .ThenInclude(at => at.Alumno)
            .ToList();
        return tareas.Select(t => t.ToDto()).ToList();
    }
 

}
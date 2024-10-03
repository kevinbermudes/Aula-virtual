using Webvs2.Models;
using Microsoft.EntityFrameworkCore;
using Webvs2.DTO;
using Webvs2.Mappers;

namespace Webvs2.Service
{
    public class AlumnoService : IAlumnoService
    {
        private readonly AplicationDbContext _context;
        
        public AlumnoService(AplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<AlumnoDto> GetAlumnos()
        {
          
            var alumnos = _context.Alumnos
                .Include(a => a.Aula) 
                .Include(a => a.AlumnoTareas)
                .ThenInclude(at => at.Tarea)
                .ToList();

            return alumnos.Select(a => a.ToDto()).ToList();

        }
    }
}
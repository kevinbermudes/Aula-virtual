using Webvs2.Models;
using Microsoft.EntityFrameworkCore;

namespace Webvs2.Service
{
    public class AlumnoService : IAlumnoService
    {
        private readonly AplicationDbContext _context;

        public AlumnoService(AplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Alumno> GetAlumnos() =>
            _context.Alumnos.ToList();

        public Alumno? GetAlumnoById(int id) =>
            _context.Alumnos.Find(id);

        public Alumno CreateAlumno(Alumno alumno)
        {
            _context.Alumnos.Add(alumno);
            _context.SaveChanges();
            return alumno;
        }

        public void UpdateAlumno(Alumno alumno)
        {
            _context.Alumnos.Update(alumno);
            _context.SaveChanges();
        }

        public void DeleteAlumno(int id)
        {
            var alumno = _context.Alumnos.Find(id);
            if (alumno != null)
            {
                _context.Alumnos.Remove(alumno);
                _context.SaveChanges();
            }
        }
    }
}
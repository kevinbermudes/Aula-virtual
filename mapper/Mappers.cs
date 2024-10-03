using Webvs2.DTO;
using Webvs2.Models;
using Webvs2.Service;


namespace Webvs2.Mappers
{
    public static class Mapper
    {
        public static AlumnoDto ToDto(this Alumno alumno)
        {
            return new AlumnoDto
            {
                Id = alumno.Id,
                Nombre = alumno.NombreAlumno,
                Apellido = alumno.Apellido,
                Tareas = alumno.AlumnoTareas?.Select(at => at.Tarea?.Nombre).ToList()
                
            };
        }

        public static AulaDto ToDto(this Aula aula)
        {
            return new AulaDto
            {
                Id = aula.Id,
                Nombre = aula.Nombre,
                AlumnoNombres = aula.Alumnos?.Select(a => a.NombreAlumno).ToList()
            };
        }

        public static TareaDto ToDto(this Tareas tareas)
        {
            return new TareaDto
            {
                Id = tareas.Id,
                Nombre = tareas.Nombre,
                Descripcion = tareas.Descripcion,
                FechaEx = tareas.FechaEx,
                AlumnoNombres = tareas.AlumnoTareas?.Select(at => at.Alumno?.NombreAlumno).ToList()
            };
        }

    }
}
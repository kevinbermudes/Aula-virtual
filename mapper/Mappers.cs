using Webvs2.DTO;
using Webvs2.Models;


namespace Webvs2.Mappers
{
    public static class Mapper
    {
        public static AlumnoDto ToDto(this Alumno alumno)
        {
            return new AlumnoDto
            {
                Id = alumno.Id,
                Nombre = alumno.Nombre,
                Apellido = alumno.Apellido,
                AulaId = alumno.AulaId,
                TareaId = alumno.TareaId
            };
        }

        public static AulaDto ToDto(this Aula aula)
        {
            return new AulaDto
            {
                Id = aula.Id,
                Nombre = aula.Nombre,
            };
        }

        public static TareaDto ToDto(this Tareas tareas)
        {
            return new TareaDto
            {
                Id = tareas.Id,
                Nombre = tareas.Nombre,
                Descripcion = tareas.Descripcion,
                FechaEx = tareas.FechaEx
            };
        }

        public static Alumno ToModel(this AlumnoDto alumnoDto)
        {
            return new Alumno
            {
                Id = alumnoDto.Id,
                Nombre = alumnoDto.Nombre,
                Apellido = alumnoDto.Apellido,
                AulaId = alumnoDto.AulaId,
                TareaId = alumnoDto.TareaId
            };
        }

        public static Aula ToModel(this AulaDto aulaDto)
        {
            return new Aula
            {
                Id = aulaDto.Id,
                Nombre = aulaDto.Nombre,
            };
        }

        public static Tareas ToModel(this TareaDto tareasDto)
        {
            return new Tareas
            {
                Id = tareasDto.Id,
                Nombre = tareasDto.Nombre,
                Descripcion = tareasDto.Descripcion,
                FechaEx = tareasDto.FechaEx
            };
        }
    }
}
using Webvs2.Models;


public interface IAlumnoService
{
    IEnumerable<Alumno> GetAlumnos();
    Alumno? GetAlumnoById(int id);
    Alumno CreateAlumno(Alumno alumno);
    void UpdateAlumno(Alumno alumno);
    void DeleteAlumno(int id);
}

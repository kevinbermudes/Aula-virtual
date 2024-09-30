using Webvs2.Models;

namespace Webvs2.Service;

public interface IAula
{
    IEnumerable<Aula> GetAula();
    Aula? GetAulaById(int id);
    Aula CreateAula(Aula alumno);
    void UpdateAula(Aula alumno);
    void DeleteAula(int id);
}
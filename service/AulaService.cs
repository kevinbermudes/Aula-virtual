using Webvs2.Models;

namespace Webvs2.Service;

public class AulaService : IAula
    {
        private readonly AplicationDbContext _context;
        public AulaService(AplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Aula> GetAula() =>
            _context.Aulas.ToList();

        public Aula? GetAulaById(int id) =>
            _context.Aulas.Find(id);

        public Aula CreateAula(Aula aula)
        {
            _context.Aulas.Add(aula);
            _context.SaveChanges();
            return aula;
        }

        public void UpdateAula(Aula aula)
        {
            _context.Aulas.Update(aula);
            _context.SaveChanges();
        }

        public void DeleteAula(int id)
        {
            var aula = _context.Aulas.Find(id);
            if (aula !=null)
            {
                _context.Aulas.Remove(aula);
                _context.SaveChanges();
            }
        }
    }

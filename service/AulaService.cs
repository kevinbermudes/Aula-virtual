using Webvs2.DTO;
using Webvs2.Mappers;
using Webvs2.Models;

namespace Webvs2.Service;

public class AulaService : IAula
    {
        private readonly AplicationDbContext _context;
        public AulaService(AplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<AulaDto> GetAula()
        {
            var aula = _context.Aulas.ToList();
            return aula.Select(t => t.ToDto()).ToList();
        }

      
    }

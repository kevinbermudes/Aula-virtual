using Microsoft.EntityFrameworkCore;
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
            var aulas = _context.Aulas
                .Include(a => a.Alumnos) 
                .ToList();

            return aulas.Select(a => a.ToDto()).ToList();
        }

      
    }

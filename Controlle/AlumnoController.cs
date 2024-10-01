using Microsoft.AspNetCore.Mvc;
using Webvs2.DTO;
using Webvs2.Models;
using Webvs2.Service;

namespace Webvs2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        private readonly IAlumnoService _alumnoService;

        public AlumnosController(IAlumnoService alumnoService)
        {
            _alumnoService = alumnoService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AlumnoDto>> Get() =>
            Ok(_alumnoService.GetAlumnos());

        [HttpGet("{id}")]
        public ActionResult<AlumnoDto> Get(int id)
        {
            var alumno = _alumnoService.GetAlumnoById(id);
            return alumno != null ? Ok(alumno) : NotFound();
        }

        [HttpPost]
        public ActionResult<AlumnoDto> Post(Alumno alumno)
        {
            var createdAlumno = _alumnoService.CreateAlumno(alumno);
            return CreatedAtAction(nameof(Get), new { id = createdAlumno.Id }, createdAlumno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Alumno alumno)
        {
            if (id != alumno.Id) return BadRequest();
            _alumnoService.UpdateAlumno(alumno);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _alumnoService.DeleteAlumno(id);
            return NoContent();
        }
    }
}
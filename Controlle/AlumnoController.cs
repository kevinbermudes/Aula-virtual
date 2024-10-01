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

    }
}
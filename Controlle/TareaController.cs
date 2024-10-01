using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Webvs2.DTO;
using Webvs2.Models;
using Webvs2.Service;

namespace Webvs2.Controllers;

[Route("api/tarea1")]
[ApiController]
public class TareaController : ControllerBase
{
    private readonly ITareas _tareas;

    public TareaController(ITareas tareas)
    {
        _tareas = tareas;
    }

    [HttpGet]
    public ActionResult<IEnumerable<TareaDto>> Get() => 
        Ok(_tareas.GetTarea());

  

}
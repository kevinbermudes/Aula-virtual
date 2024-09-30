using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Webvs2.Models;
using Webvs2.Service;

namespace Webvs2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TareaController : ControllerBase
{
    private readonly ITareas _tareas;

    public TareaController(ITareas tareas)
    {
        _tareas = tareas;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Tareas>> Get() => 
        Ok(_tareas.GetTarea());

    [HttpGet("{id}")]
    public ActionResult<Tareas> Get(int id)
    {
        var tarea = _tareas.GetTareaById(id);
        return tarea != null ? Ok(tarea) : NotFound();
    }
    
    [HttpPost]
    public ActionResult<Tareas> Post(Tareas tareas)
    {
        var createtareas = _tareas.CreateTarea(tareas);
        return CreatedAtAction(nameof(Get), new { id = tareas.Id });
    }
    [HttpPut("id")]
    public IActionResult Put(int id, Tareas tareas)
    {
        if (id != tareas.Id) return BadRequest();
        return NoContent();
    }
    [HttpDelete]
    public IActionResult Delete(int id)
    {
        _tareas.DeleteTarea(id);
        return NoContent();
    }


}
using Microsoft.AspNetCore.Mvc;
using Webvs2.Models;
using Webvs2.Service;

namespace Webvs2.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AulaController: ControllerBase
{
   private readonly IAula _aulaService;

   public AulaController(IAula aulaService)
   {
      _aulaService = aulaService;
   }

   [HttpGet]
   public ActionResult<IEnumerable<Aula>> Get() =>
      Ok(_aulaService.GetAula());

   [HttpGet("{id}")]
   public ActionResult<Aula> Get(int id)
   {
      var aula = _aulaService.GetAulaById(id);
      return aula != null ? Ok(aula) : NotFound();
      
   }

   [HttpPost]
   public ActionResult<Aula> Post(Aula aula)
   {
      var createAula = _aulaService.CreateAula(aula);
      return CreatedAtAction(nameof(Get), new { id = createAula.Id });
   }

   [HttpPut("id")]
   public IActionResult Put(int id, Aula aula)
   {
      if (id != aula.Id) return BadRequest();
      return NoContent();
   }

   [HttpDelete]
   public IActionResult Delete(int id)
   {
      _aulaService.DeleteAula(id);
      return NoContent();
   }
}
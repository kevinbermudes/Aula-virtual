using Microsoft.AspNetCore.Mvc;
using Webvs2.DTO;
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
   public ActionResult<IEnumerable<AulaDto>> Get() =>
      Ok(_aulaService.GetAula());

 
}
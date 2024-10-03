using Webvs2.DTO;
using Webvs2.Models;

namespace Webvs2.Service;

public interface ITareas
{
    IEnumerable<TareaDto> GetTarea();
    

}
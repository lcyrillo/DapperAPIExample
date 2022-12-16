using Microsoft.AspNetCore.Mvc;
using Repository;

namespace API.Controllers;

[Route("api/v1/[controller]")]
public class AlunoController : Controller
{
    private readonly IAlunoRepository _repository;

    public AlunoController(IAlunoRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    [Route("[action]")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _repository.GetAll();
        return Ok(result);
    }
}

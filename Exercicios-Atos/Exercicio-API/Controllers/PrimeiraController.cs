using Microsoft.AspNetCore.Mvc;

namespace Exercicio_API.Controllers;

[ApiController]
[Route("[controller]")]
public class PrimeiraController : ControllerBase
{
    [HttpGet]
    public string PrimeiroEndpoint()
    {
        return "Aula de REST API";
    }
}

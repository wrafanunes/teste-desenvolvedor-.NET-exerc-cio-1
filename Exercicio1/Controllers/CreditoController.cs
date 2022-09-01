using Banco.Classes;
using Banco.Services;
using Microsoft.AspNetCore.Mvc;

namespace Exercicio1.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CreditoController : ControllerBase
{
    private readonly ICreditoService _creditoService;

    public CreditoController (ICreditoService creditoService)
    {
        _creditoService = creditoService;
    }

    [HttpGet]
    public IActionResult ObterResultadoCredito ([FromQuery] Credito credito)
    {
        var creditoViewModel = _creditoService.ExibirResultadoCredito(credito);
        return Ok(creditoViewModel);
    }
}

using Microsoft.AspNetCore.Mvc;
using numerosPares.Services;

namespace numerosPares.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NumerosController : ControllerBase
    {
        private readonly INumerosService _numerosService;

        public NumerosController(INumerosService numerosService)
        {
            _numerosService = numerosService;
        }

        [HttpGet("parimpar")]
        public IActionResult VerificarParImpar(int numero)
        {
            var resultado = _numerosService.VerificarParImpar(numero);
            return Ok(new { numero, resultado });
        }
    }
}

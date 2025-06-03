using Microsoft.AspNetCore.Mvc;
using ApiPalindromos.Services;

namespace ApiPalindromos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PalindromoController : ControllerBase
    {
        private readonly IPalindromoService _palindromoService;

        public PalindromoController(IPalindromoService palindromoService)
        {
            _palindromoService = palindromoService;
        }

        [HttpGet("{texto}")]
        public IActionResult Verificar(string texto)
        {
            var esPalindromo = _palindromoService.EsPalindromo(texto);
            return Ok(new { texto, esPalindromo });
        }
    }
}

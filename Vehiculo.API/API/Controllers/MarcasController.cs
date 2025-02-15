using Abstracciones.Interfaces.API.Marcas;
using Abstracciones.Interfaces.Flujo.Marcas;
using Abstracciones.Interfaces.Flujo.Vehiculos;
using Abstracciones.Modelos;
using Flujo.Vehiculos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcasController : ControllerBase, IMarcasController
    {
        private IMarcasFlujo _marcasFlujo;
        private ILogger<MarcasController> _logger;

        public MarcasController(IMarcasFlujo marcasFlujo, ILogger<MarcasController> logger)
        {
            _marcasFlujo = marcasFlujo;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Obtener()
        {
            var resultado = await _marcasFlujo.Obtener();
            if (!resultado.Any())
            {
                return NoContent();
            }
            return Ok(resultado);
        }
    }
}

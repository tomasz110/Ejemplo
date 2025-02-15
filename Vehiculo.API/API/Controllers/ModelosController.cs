using Abstracciones.Interfaces.API.Modelos;
using Abstracciones.Interfaces.Flujo.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelosController : ControllerBase, IModelosController
    {
        private IModelosFlujo _modelosFlujo;
        private ILogger<ModelosController> _logger;

        public ModelosController(IModelosFlujo modelosFlujo, ILogger<ModelosController> logger)
        {
            _modelosFlujo = modelosFlujo;
            _logger = logger;
        }
        // GET: api/<ModelosController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<ModelosController>/5
        [HttpGet("{IdMarca}")]
        public async Task<IActionResult> Obtener([FromRoute] Guid IdMarca)
        {
            var resultado = await _modelosFlujo.Obtener(IdMarca);
            return Ok(resultado);
        }

        //// POST api/<ModelosController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<ModelosController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ModelosController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}

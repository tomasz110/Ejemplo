//using Abstracciones.Interfaces.API.Persona;
//using Abstracciones.Interfaces.Flujo.Persona;
//using Abstracciones.Modelos;
//using Microsoft.AspNetCore.Mvc;

//namespace API.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class PersonaController : ControllerBase, IPersonaController

//    {
//        private IPersonaFlujo  _personaFlujo;
//        private ILogger<PersonaController> _logger;

//        public PersonaController(IPersonaFlujo personaFlujo, ILogger<PersonaController> logger)
//        {
//            _personaFlujo = personaFlujo;
//            _logger = logger;
//        }
//        public Task<IActionResult> Agregar(PersonaBase persona)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<IActionResult> Editar(Guid Id, PersonaBase persona)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<IActionResult> Eliminar(Guid Id)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<IActionResult> Obtener()
//        {
//            throw new NotImplementedException();
//        }

//        public Task<IActionResult> Obtener(Guid Id)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}

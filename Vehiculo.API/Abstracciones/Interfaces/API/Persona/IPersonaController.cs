using Abstracciones.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace Abstracciones.Interfaces.API.Persona
{
    public interface IPersonaController
    {
        Task<IActionResult> Obtener();
        Task<IActionResult> Obtener(Guid Id);
        Task<IActionResult> Agregar(PersonaBase persona);
        Task<IActionResult> Editar(Guid Id, PersonaBase persona);

        Task<IActionResult> Eliminar(Guid Id);
    }
}


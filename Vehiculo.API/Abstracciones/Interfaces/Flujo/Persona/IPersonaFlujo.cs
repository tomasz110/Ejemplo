using Abstracciones.Modelos;

namespace Abstracciones.Interfaces.Flujo.Persona
{
    public interface IPersonaFlujo
    {
        Task<IEnumerable<PersonaResponse>> Obtener();
        Task<PersonaResponse> Obtener(Guid Id);
        Task<Guid> Agregar(PersonaBase persona);
        Task<Guid> Editar(Guid Id, PersonaBase persona);

        Task<Guid> Eliminar(Guid Id);
    }
}

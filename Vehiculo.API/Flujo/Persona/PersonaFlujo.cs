using Abstracciones.Interfaces.DA.Persona;
using Abstracciones.Interfaces.Flujo.Persona;
using Abstracciones.Modelos;

namespace Flujo.Persona
{
    public class PersonaFlujo : IPersonaFlujo
    {
        private IPersonaDA _personaDA;


        public PersonaFlujo(IPersonaDA personaDA)
        {
            _personaDA = personaDA;
        }

        public Task<Guid> Agregar(PersonaBase persona)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> Editar(Guid Id, PersonaBase persona)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> Eliminar(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PersonaResponse>> Obtener()
        {
            throw new NotImplementedException();
        }

        public Task<PersonaResponse> Obtener(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
